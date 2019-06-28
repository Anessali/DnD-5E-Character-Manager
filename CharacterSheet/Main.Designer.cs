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
            this.components = new System.ComponentModel.Container();
            this.charSheetMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editRacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.subracesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCharacter = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBoxSubrace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxRace = new System.Windows.Forms.ComboBox();
            this.lblSubrace = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCha = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblInt = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCon = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDex = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblWis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetAttributes = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dGridInventory = new System.Windows.Forms.DataGridView();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGridTypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnDataDataSet = new CharacterSheet.DnDataDataSet();
            this.dnDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new CharacterSheet.DnDataDataSetTableAdapters.InventoryTableAdapter();
            this.tabSpells = new System.Windows.Forms.TabPage();
            this.charSheetMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCharacter.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // charSheetMenu
            // 
            this.charSheetMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charSheetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.rollToolStripMenuItem});
            this.charSheetMenu.Location = new System.Drawing.Point(0, 0);
            this.charSheetMenu.Name = "charSheetMenu";
            this.charSheetMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.charSheetMenu.Size = new System.Drawing.Size(562, 35);
            this.charSheetMenu.TabIndex = 0;
            this.charSheetMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.newToolStripMenuItem.Text = "New";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCharacterToolStripMenuItem,
            this.toolStripSeparator1,
            this.editRacesToolStripMenuItem,
            this.toolStripSeparator2,
            this.subracesToolStripMenuItem,
            this.toolStripSeparator3,
            this.addClassToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editCharacterToolStripMenuItem
            // 
            this.editCharacterToolStripMenuItem.Name = "editCharacterToolStripMenuItem";
            this.editCharacterToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.editCharacterToolStripMenuItem.Text = "Character";
            this.editCharacterToolStripMenuItem.Click += new System.EventHandler(this.EditCharacterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // editRacesToolStripMenuItem
            // 
            this.editRacesToolStripMenuItem.Name = "editRacesToolStripMenuItem";
            this.editRacesToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.editRacesToolStripMenuItem.Text = "Races";
            this.editRacesToolStripMenuItem.Click += new System.EventHandler(this.editRacesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // subracesToolStripMenuItem
            // 
            this.subracesToolStripMenuItem.Name = "subracesToolStripMenuItem";
            this.subracesToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.subracesToolStripMenuItem.Text = "Subraces";
            this.subracesToolStripMenuItem.Click += new System.EventHandler(this.subracesToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.addClassToolStripMenuItem.Text = "Add Class";
            // 
            // rollToolStripMenuItem
            // 
            this.rollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.d20ToolStripMenuItem,
            this.d12ToolStripMenuItem,
            this.d10ToolStripMenuItem,
            this.d8ToolStripMenuItem,
            this.d6ToolStripMenuItem,
            this.d4ToolStripMenuItem,
            this.attributeToolStripMenuItem});
            this.rollToolStripMenuItem.Name = "rollToolStripMenuItem";
            this.rollToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.rollToolStripMenuItem.Text = "Roll";
            // 
            // d20ToolStripMenuItem
            // 
            this.d20ToolStripMenuItem.Name = "d20ToolStripMenuItem";
            this.d20ToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.d20ToolStripMenuItem.Text = "D20";
            this.d20ToolStripMenuItem.Click += new System.EventHandler(this.d20ToolStripMenuItem_Click);
            // 
            // d12ToolStripMenuItem
            // 
            this.d12ToolStripMenuItem.Name = "d12ToolStripMenuItem";
            this.d12ToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.d12ToolStripMenuItem.Text = "D12";
            this.d12ToolStripMenuItem.Click += new System.EventHandler(this.d12ToolStripMenuItem_Click);
            // 
            // d10ToolStripMenuItem
            // 
            this.d10ToolStripMenuItem.Name = "d10ToolStripMenuItem";
            this.d10ToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.d10ToolStripMenuItem.Text = "D10";
            this.d10ToolStripMenuItem.Click += new System.EventHandler(this.d10ToolStripMenuItem_Click);
            // 
            // d8ToolStripMenuItem
            // 
            this.d8ToolStripMenuItem.Name = "d8ToolStripMenuItem";
            this.d8ToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.d8ToolStripMenuItem.Text = "D8";
            this.d8ToolStripMenuItem.Click += new System.EventHandler(this.d8ToolStripMenuItem_Click);
            // 
            // d6ToolStripMenuItem
            // 
            this.d6ToolStripMenuItem.Name = "d6ToolStripMenuItem";
            this.d6ToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.d6ToolStripMenuItem.Text = "D6";
            this.d6ToolStripMenuItem.Click += new System.EventHandler(this.d6ToolStripMenuItem_Click);
            // 
            // d4ToolStripMenuItem
            // 
            this.d4ToolStripMenuItem.Name = "d4ToolStripMenuItem";
            this.d4ToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.d4ToolStripMenuItem.Text = "D4";
            this.d4ToolStripMenuItem.Click += new System.EventHandler(this.d4ToolStripMenuItem_Click);
            // 
            // attributeToolStripMenuItem
            // 
            this.attributeToolStripMenuItem.Name = "attributeToolStripMenuItem";
            this.attributeToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.attributeToolStripMenuItem.Text = "Attribute";
            this.attributeToolStripMenuItem.Click += new System.EventHandler(this.attributeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCharacter);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabSpells);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 417);
            this.tabControl1.TabIndex = 2;
            // 
            // tabCharacter
            // 
            this.tabCharacter.Controls.Add(this.label9);
            this.tabCharacter.Controls.Add(this.button1);
            this.tabCharacter.Controls.Add(this.cbBoxSubrace);
            this.tabCharacter.Controls.Add(this.label2);
            this.tabCharacter.Controls.Add(this.cbBoxRace);
            this.tabCharacter.Controls.Add(this.lblSubrace);
            this.tabCharacter.Location = new System.Drawing.Point(4, 29);
            this.tabCharacter.Name = "tabCharacter";
            this.tabCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacter.Size = new System.Drawing.Size(554, 384);
            this.tabCharacter.TabIndex = 0;
            this.tabCharacter.Text = "Character";
            this.tabCharacter.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 31);
            this.label9.TabIndex = 5;
            this.label9.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBoxSubrace
            // 
            this.cbBoxSubrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSubrace.FormattingEnabled = true;
            this.cbBoxSubrace.Location = new System.Drawing.Point(99, 212);
            this.cbBoxSubrace.Name = "cbBoxSubrace";
            this.cbBoxSubrace.Size = new System.Drawing.Size(145, 28);
            this.cbBoxSubrace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subrace:";
            // 
            // cbBoxRace
            // 
            this.cbBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxRace.FormattingEnabled = true;
            this.cbBoxRace.Location = new System.Drawing.Point(99, 168);
            this.cbBoxRace.Name = "cbBoxRace";
            this.cbBoxRace.Size = new System.Drawing.Size(145, 28);
            this.cbBoxRace.TabIndex = 1;
            this.cbBoxRace.TextChanged += new System.EventHandler(this.cbBoxRace_TextChanged);
            // 
            // lblSubrace
            // 
            this.lblSubrace.AutoSize = true;
            this.lblSubrace.Location = new System.Drawing.Point(10, 34);
            this.lblSubrace.Name = "lblSubrace";
            this.lblSubrace.Size = new System.Drawing.Size(69, 20);
            this.lblSubrace.TabIndex = 0;
            this.lblSubrace.Text = "Subrace";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attributes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.05839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.15328F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 139);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblCha);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(458, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(87, 87);
            this.panel7.TabIndex = 14;
            // 
            // lblCha
            // 
            this.lblCha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCha.Location = new System.Drawing.Point(0, 0);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(83, 83);
            this.lblCha.TabIndex = 0;
            this.lblCha.Text = "0";
            this.lblCha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblInt);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(273, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 87);
            this.panel5.TabIndex = 6;
            // 
            // lblInt
            // 
            this.lblInt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInt.Location = new System.Drawing.Point(0, 0);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(84, 83);
            this.lblInt.TabIndex = 0;
            this.lblInt.Text = "0";
            this.lblInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblCon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(185, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 87);
            this.panel4.TabIndex = 5;
            // 
            // lblCon
            // 
            this.lblCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(0, 0);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(78, 83);
            this.lblCon.TabIndex = 0;
            this.lblCon.Text = "0";
            this.lblCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblDex);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(94, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 87);
            this.panel3.TabIndex = 4;
            // 
            // lblDex
            // 
            this.lblDex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDex.Location = new System.Drawing.Point(0, 0);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(81, 83);
            this.lblDex.TabIndex = 0;
            this.lblDex.Text = "0";
            this.lblDex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblStr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 87);
            this.panel2.TabIndex = 3;
            // 
            // lblStr
            // 
            this.lblStr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStr.Location = new System.Drawing.Point(0, 0);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(81, 83);
            this.lblStr.TabIndex = 0;
            this.lblStr.Text = "0";
            this.lblStr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 46);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 46);
            this.label7.TabIndex = 12;
            this.label7.Text = "Wis";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "Int";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "Con";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dex";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Str";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblWis);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(367, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(85, 87);
            this.panel6.TabIndex = 7;
            // 
            // lblWis
            // 
            this.lblWis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWis.Location = new System.Drawing.Point(0, 0);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(81, 83);
            this.lblWis.TabIndex = 0;
            this.lblWis.Text = "0";
            this.lblWis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSetAttributes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 63);
            this.panel1.TabIndex = 1;
            // 
            // btnSetAttributes
            // 
            this.btnSetAttributes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetAttributes.Location = new System.Drawing.Point(0, 0);
            this.btnSetAttributes.Name = "btnSetAttributes";
            this.btnSetAttributes.Size = new System.Drawing.Size(138, 63);
            this.btnSetAttributes.TabIndex = 0;
            this.btnSetAttributes.Text = "Set Attributes";
            this.btnSetAttributes.UseVisualStyleBackColor = true;
            this.btnSetAttributes.Click += new System.EventHandler(this.btnSetAttributes_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(554, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Traits";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(554, 384);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Equipped";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dGridInventory);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(554, 384);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Inventory";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dGridInventory
            // 
            this.dGridInventory.AutoGenerateColumns = false;
            this.dGridInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGridInventory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dGridTypeColumn});
            this.dGridInventory.DataSource = this.inventoryBindingSource;
            this.dGridInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridInventory.Location = new System.Drawing.Point(3, 3);
            this.dGridInventory.Name = "dGridInventory";
            this.dGridInventory.Size = new System.Drawing.Size(548, 378);
            this.dGridInventory.TabIndex = 0;
            this.dGridInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridInventory_CellClick);
            this.dGridInventory.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridInventory_CellEndEdit);
            this.dGridInventory.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridInventory_CellValueChanged);
            this.dGridInventory.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGridInventory_RowsRemoved);
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.Width = 66;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // dGridTypeColumn
            // 
            this.dGridTypeColumn.DataPropertyName = "Type";
            this.dGridTypeColumn.HeaderText = "Type";
            this.dGridTypeColumn.Items.AddRange(new object[] {
            "Weapon",
            "Armor",
            "Item"});
            this.dGridTypeColumn.Name = "dGridTypeColumn";
            this.dGridTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridTypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.dnDataDataSet;
            // 
            // dnDataDataSet
            // 
            this.dnDataDataSet.DataSetName = "DnDataDataSet";
            this.dnDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tabSpells
            // 
            this.tabSpells.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabSpells.Location = new System.Drawing.Point(4, 29);
            this.tabSpells.Name = "tabSpells";
            this.tabSpells.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpells.Size = new System.Drawing.Size(554, 384);
            this.tabSpells.TabIndex = 5;
            this.tabSpells.Text = "Spells";
            this.tabSpells.UseVisualStyleBackColor = true;
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
            this.Text = "Character Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.charSheetMenu.ResumeLayout(false);
            this.charSheetMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCharacter.ResumeLayout(false);
            this.tabCharacter.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip charSheetMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem d4ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCharacter;
        private System.Windows.Forms.Label lblSubrace;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSetAttributes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem editCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbBoxSubrace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoxRace;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dGridInventory;
        private System.Windows.Forms.BindingSource dnDataDataSetBindingSource;
        private System.Windows.Forms.ToolStripMenuItem attributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DnDataDataSet dnDataDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private DnDataDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dGridTypeColumn;
        private System.Windows.Forms.ToolStripMenuItem subracesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabSpells;
    }
}

