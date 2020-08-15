﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ARKBreedingStats.utils
{
    /// <summary>
    /// Used to find the folder of exported creature files.
    /// </summary>
    internal static class ExportFolderLocation
    {
        internal static bool GetListOfExportFolders(out (string path, string steamPlayerName)[] exportFolders)
        {
            exportFolders = null;

            if (GetSteamInstallationPath(out var steamPath)
                && ReadSteamPlayerIdsAndArkInstallPaths(Path.Combine(steamPath, "config", "config.vdf"),
                    out (string steamPlayerName, string steamPlayerId)[] steamNamesIds, out string[] arkInstallFolders))
            {
                if (!steamNamesIds.Any()) return false;

                var relativeArkPath = Path.Combine("steamapps", "common", "ARK");
                var possibleArkPaths = new List<string> { Path.Combine(steamPath, relativeArkPath) };
                possibleArkPaths.AddRange(arkInstallFolders.Select(f => Path.Combine(f, relativeArkPath)));

                var existingArkPaths = possibleArkPaths.Where(Directory.Exists).ToArray();

                if (!existingArkPaths.Any()) return false;

                var relativeExportFolder = Path.Combine("ShooterGame", "Saved", "DinoExports");

                // there can be multiple steam users, so list the possible export folder for each user
                exportFolders = new (string, string)[existingArkPaths.Length * steamNamesIds.Length];
                int i = 0;
                foreach (var arkPath in existingArkPaths)
                {
                    foreach (var steamNameId in steamNamesIds)
                        exportFolders[i++] = (Path.Combine(arkPath, relativeExportFolder, steamNameId.steamPlayerId), steamNameId.steamPlayerName);
                }

                return true;
            }

            return false;
        }

        private static bool GetSteamInstallationPath(out string steamPath)
        {
            steamPath = null;

            // try to get registry key for steam installation path
            string keyName = (Environment.Is64BitOperatingSystem ?
                @"SOFTWARE\Wow6432Node\Valve\Steam\" :
                @"SOFTWARE\Valve\Steam\");
            using (var key = Registry.LocalMachine.OpenSubKey(keyName))
            {
                if (key == null) return false;
                steamPath = (string)key.GetValue("InstallPath");
                return !string.IsNullOrEmpty(steamPath);
            }
        }

        /// <summary>
        /// Reads the steam config file (config.vdf) and returns a list of player ids and Ark install locations.
        /// </summary>
        /// <param name="steamConfigFilePath"></param>
        /// <param name="steamPlayerIds"></param>
        /// <param name="arkInstallPaths"></param>
        /// <returns></returns>
        private static bool ReadSteamPlayerIdsAndArkInstallPaths(string steamConfigFilePath, out (string steamPlayerName, string steamPlayerId)[] steamPlayerIds,
            out string[] arkInstallPaths)
        {
            steamPlayerIds = null;
            arkInstallPaths = null;

            if (!File.Exists(steamConfigFilePath)) return false;

            string configFileContent = File.ReadAllText(steamConfigFilePath);
            if (string.IsNullOrEmpty(configFileContent)) return false;

            var steamAccountRegEx = new Regex(@"""InstallConfigStore"".+""Software"".+""Valve"".+""Steam"".+""Accounts""\s*\{", RegexOptions.Singleline);
            var m = steamAccountRegEx.Match(configFileContent);
            if (!m.Success) return false;

            var playerIdRegEx = new Regex(@"\s*""([^""]+)""\s*\{\s*""SteamID""\s*""(\d+)""\s*\}", RegexOptions.Singleline);
            var mm = playerIdRegEx.Matches(configFileContent, m.Length);

            steamPlayerIds = (from Match mi in mm select (mi.Groups[1].Value, mi.Groups[2].Value)).ToArray();

            // steam library locations
            var libraryRegEx = new Regex(@"""BaseInstallFolder_\d+""\s*""([^""]+)""");
            mm = libraryRegEx.Matches(configFileContent);
            var removeEscapeBackslashes = new Regex(@"\\(.)");
            arkInstallPaths = (from Match mi in mm select removeEscapeBackslashes.Replace(mi.Groups[1].Value, "$1")).ToArray();

            return steamPlayerIds.Any();
        }
    }
}
