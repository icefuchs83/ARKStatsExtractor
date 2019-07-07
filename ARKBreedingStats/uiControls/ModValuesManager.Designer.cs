﻿namespace ARKBreedingStats.uiControls
{
    partial class ModValuesManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbModList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMoveDown = new System.Windows.Forms.Button();
            this.btMoveUp = new System.Windows.Forms.Button();
            this.btRemoveModFile = new System.Windows.Forms.Button();
            this.btLoadModFile = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.llbSteamPage = new System.Windows.Forms.LinkLabel();
            this.lbModId = new System.Windows.Forms.Label();
            this.lbModTag = new System.Windows.Forms.Label();
            this.lbModName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbModList
            // 
            this.lbModList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModList.FormattingEnabled = true;
            this.lbModList.Location = new System.Drawing.Point(6, 6);
            this.lbModList.Margin = new System.Windows.Forms.Padding(6);
            this.lbModList.Name = "lbModList";
            this.tableLayoutPanel1.SetRowSpan(this.lbModList, 3);
            this.lbModList.Size = new System.Drawing.Size(388, 438);
            this.lbModList.TabIndex = 0;
            this.lbModList.SelectedIndexChanged += new System.EventHandler(this.LbModList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbModList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btClose, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btMoveDown);
            this.panel1.Controls.Add(this.btMoveUp);
            this.panel1.Controls.Add(this.btRemoveModFile);
            this.panel1.Controls.Add(this.btLoadModFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(403, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 201);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mod values are loaded from top to bottom. If multiple mods change the same value," +
    " the value of the mod lower in the list will be used.";
            // 
            // btMoveDown
            // 
            this.btMoveDown.Location = new System.Drawing.Point(3, 96);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(50, 23);
            this.btMoveDown.TabIndex = 3;
            this.btMoveDown.Text = "▼";
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.Click += new System.EventHandler(this.BtMoveDown_Click);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Location = new System.Drawing.Point(3, 67);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(50, 23);
            this.btMoveUp.TabIndex = 2;
            this.btMoveUp.Text = "▲";
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.Click += new System.EventHandler(this.BtMoveUp_Click);
            // 
            // btRemoveModFile
            // 
            this.btRemoveModFile.Location = new System.Drawing.Point(3, 38);
            this.btRemoveModFile.Name = "btRemoveModFile";
            this.btRemoveModFile.Size = new System.Drawing.Size(145, 23);
            this.btRemoveModFile.TabIndex = 1;
            this.btRemoveModFile.Text = "Remove selected Mod-file";
            this.btRemoveModFile.UseVisualStyleBackColor = true;
            this.btRemoveModFile.Click += new System.EventHandler(this.BtRemoveModFile_Click);
            // 
            // btLoadModFile
            // 
            this.btLoadModFile.Location = new System.Drawing.Point(3, 9);
            this.btLoadModFile.Name = "btLoadModFile";
            this.btLoadModFile.Size = new System.Drawing.Size(145, 23);
            this.btLoadModFile.TabIndex = 0;
            this.btLoadModFile.Text = "Load Mod-Values file";
            this.btLoadModFile.UseVisualStyleBackColor = true;
            this.btLoadModFile.Click += new System.EventHandler(this.BtLoadModFile_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(703, 424);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // llbSteamPage
            // 
            this.llbSteamPage.AutoSize = true;
            this.llbSteamPage.Location = new System.Drawing.Point(6, 79);
            this.llbSteamPage.Name = "llbSteamPage";
            this.llbSteamPage.Size = new System.Drawing.Size(88, 13);
            this.llbSteamPage.TabIndex = 6;
            this.llbSteamPage.TabStop = true;
            this.llbSteamPage.Text = "Mod Steam page";
            this.llbSteamPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbSteamPage_LinkClicked);
            // 
            // lbModId
            // 
            this.lbModId.AutoSize = true;
            this.lbModId.Location = new System.Drawing.Point(106, 61);
            this.lbModId.Name = "lbModId";
            this.lbModId.Size = new System.Drawing.Size(15, 13);
            this.lbModId.TabIndex = 5;
            this.lbModId.Text = "id";
            // 
            // lbModTag
            // 
            this.lbModTag.AutoSize = true;
            this.lbModTag.Location = new System.Drawing.Point(106, 43);
            this.lbModTag.Name = "lbModTag";
            this.lbModTag.Size = new System.Drawing.Size(22, 13);
            this.lbModTag.TabIndex = 4;
            this.lbModTag.Text = "tag";
            // 
            // lbModName
            // 
            this.lbModName.AutoSize = true;
            this.lbModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModName.Location = new System.Drawing.Point(106, 25);
            this.lbModName.Name = "lbModName";
            this.lbModName.Size = new System.Drawing.Size(46, 16);
            this.lbModName.TabIndex = 3;
            this.lbModName.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mod tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mod id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mod-name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.llbSteamPage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbModId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbModTag);
            this.groupBox1.Controls.Add(this.lbModName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(403, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mod info";
            // 
            // ModValuesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ModValuesManager";
            this.Text = "ModValuesManager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbModList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMoveDown;
        private System.Windows.Forms.Button btMoveUp;
        private System.Windows.Forms.Button btRemoveModFile;
        private System.Windows.Forms.Button btLoadModFile;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel llbSteamPage;
        private System.Windows.Forms.Label lbModId;
        private System.Windows.Forms.Label lbModTag;
        private System.Windows.Forms.Label lbModName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}