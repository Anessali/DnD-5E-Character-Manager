namespace CharacterSheet
{
    partial class Main
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
            this.charSheetMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxRace = new System.Windows.Forms.ComboBox();
            this.cbBoxSubrace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.charSheetMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // charSheetMenu
            // 
            this.charSheetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.rollToolStripMenuItem});
            this.charSheetMenu.Location = new System.Drawing.Point(0, 0);
            this.charSheetMenu.Name = "charSheetMenu";
            this.charSheetMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.charSheetMenu.Size = new System.Drawing.Size(562, 25);
            this.charSheetMenu.TabIndex = 0;
            this.charSheetMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // rollToolStripMenuItem
            // 
            this.rollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.d20ToolStripMenuItem,
            this.d12ToolStripMenuItem,
            this.d10ToolStripMenuItem,
            this.d8ToolStripMenuItem,
            this.d6ToolStripMenuItem,
            this.d4ToolStripMenuItem});
            this.rollToolStripMenuItem.Name = "rollToolStripMenuItem";
            this.rollToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.rollToolStripMenuItem.Text = "Roll";
            // 
            // d20ToolStripMenuItem
            // 
            this.d20ToolStripMenuItem.Name = "d20ToolStripMenuItem";
            this.d20ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.d20ToolStripMenuItem.Text = "D20";
            this.d20ToolStripMenuItem.Click += new System.EventHandler(this.d20ToolStripMenuItem_Click);
            // 
            // d12ToolStripMenuItem
            // 
            this.d12ToolStripMenuItem.Name = "d12ToolStripMenuItem";
            this.d12ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.d12ToolStripMenuItem.Text = "D12";
            this.d12ToolStripMenuItem.Click += new System.EventHandler(this.d12ToolStripMenuItem_Click);
            // 
            // d10ToolStripMenuItem
            // 
            this.d10ToolStripMenuItem.Name = "d10ToolStripMenuItem";
            this.d10ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.d10ToolStripMenuItem.Text = "D10";
            this.d10ToolStripMenuItem.Click += new System.EventHandler(this.d10ToolStripMenuItem_Click);
            // 
            // d8ToolStripMenuItem
            // 
            this.d8ToolStripMenuItem.Name = "d8ToolStripMenuItem";
            this.d8ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.d8ToolStripMenuItem.Text = "D8";
            this.d8ToolStripMenuItem.Click += new System.EventHandler(this.d8ToolStripMenuItem_Click);
            // 
            // d6ToolStripMenuItem
            // 
            this.d6ToolStripMenuItem.Name = "d6ToolStripMenuItem";
            this.d6ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.d6ToolStripMenuItem.Text = "D6";
            this.d6ToolStripMenuItem.Click += new System.EventHandler(this.d6ToolStripMenuItem_Click);
            // 
            // d4ToolStripMenuItem
            // 
            this.d4ToolStripMenuItem.Name = "d4ToolStripMenuItem";
            this.d4ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.d4ToolStripMenuItem.Text = "D4";
            this.d4ToolStripMenuItem.Click += new System.EventHandler(this.d4ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 427);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbBoxSubrace);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbBoxRace);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Race:";
            // 
            // cbBoxRace
            // 
            this.cbBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxRace.FormattingEnabled = true;
            this.cbBoxRace.Location = new System.Drawing.Point(99, 92);
            this.cbBoxRace.Name = "cbBoxRace";
            this.cbBoxRace.Size = new System.Drawing.Size(121, 28);
            this.cbBoxRace.TabIndex = 1;
            this.cbBoxRace.TextChanged += new System.EventHandler(this.cbBoxRace_TextChanged);
            // 
            // cbBoxSubrace
            // 
            this.cbBoxSubrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSubrace.FormattingEnabled = true;
            this.cbBoxSubrace.Location = new System.Drawing.Point(99, 136);
            this.cbBoxSubrace.Name = "cbBoxSubrace";
            this.cbBoxSubrace.Size = new System.Drawing.Size(121, 28);
            this.cbBoxSubrace.TabIndex = 3;
            this.cbBoxSubrace.TextChanged += new System.EventHandler(this.Main_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subrace:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.charSheetMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.charSheetMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Character Sheet";
            this.Load += new System.EventHandler(this.Main_Load);
            this.charSheetMenu.ResumeLayout(false);
            this.charSheetMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip charSheetMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d4ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbBoxRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoxSubrace;
        private System.Windows.Forms.Label label2;
    }
}

