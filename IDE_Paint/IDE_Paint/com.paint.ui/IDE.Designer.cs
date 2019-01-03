﻿namespace IDE_Paint
{
    partial class formIDE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTerminal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.scintilla2 = new ScintillaNET.Scintilla();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRun = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtCommand = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.codeToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(461, 81);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(234, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // txtTerminal
            // 
            this.txtTerminal.Depth = 0;
            this.txtTerminal.Hint = "";
            this.txtTerminal.Location = new System.Drawing.Point(759, 149);
            this.txtTerminal.MaxLength = 32767;
            this.txtTerminal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.PasswordChar = '\0';
            this.txtTerminal.SelectedText = "";
            this.txtTerminal.SelectionLength = 0;
            this.txtTerminal.SelectionStart = 0;
            this.txtTerminal.Size = new System.Drawing.Size(509, 28);
            this.txtTerminal.TabIndex = 2;
            this.txtTerminal.TabStop = false;
            this.txtTerminal.UseSystemPasswordChar = false;
            this.txtTerminal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTerminal_KeyDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(998, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Terminal";
            // 
            // scintilla2
            // 
            this.scintilla2.HScrollBar = false;
            this.scintilla2.Location = new System.Drawing.Point(12, 626);
            this.scintilla2.Name = "scintilla2";
            this.scintilla2.Size = new System.Drawing.Size(1256, 82);
            this.scintilla2.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 599);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Console";
            // 
            // btnRun
            // 
            this.btnRun.AutoSize = true;
            this.btnRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRun.Depth = 0;
            this.btnRun.Icon = null;
            this.btnRun.Location = new System.Drawing.Point(16, 141);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRun.Name = "btnRun";
            this.btnRun.Primary = false;
            this.btnRun.Size = new System.Drawing.Size(56, 36);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 195);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(1256, 388);
            this.txtCommand.TabIndex = 7;
            this.txtCommand.Text = "";
            // 
            // formIDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.scintilla2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formIDE";
            this.Text = "GUI Command Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTerminal;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ScintillaNET.Scintilla scintilla2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnRun;
        private System.Windows.Forms.RichTextBox txtCommand;
    }
}
