namespace CharacterSheet.Edit
{
    partial class Character
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.cbSubrace = new System.Windows.Forms.ComboBox();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAttributes = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.numCha = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numWis = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numInt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numCon = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numDex = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numStr = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBxPointBuy = new System.Windows.Forms.CheckBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabAttributes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStr)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabAttributes);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(340, 418);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.cbSubrace);
            this.tabMain.Controls.Add(this.cbRace);
            this.tabMain.Controls.Add(this.txtName);
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Location = new System.Drawing.Point(4, 29);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(4);
            this.tabMain.Size = new System.Drawing.Size(332, 385);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // cbSubrace
            // 
            this.cbSubrace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubrace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubrace.FormattingEnabled = true;
            this.cbSubrace.Location = new System.Drawing.Point(126, 153);
            this.cbSubrace.MaxDropDownItems = 100;
            this.cbSubrace.Name = "cbSubrace";
            this.cbSubrace.Size = new System.Drawing.Size(151, 28);
            this.cbSubrace.TabIndex = 5;
            // 
            // cbRace
            // 
            this.cbRace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Location = new System.Drawing.Point(126, 105);
            this.cbRace.MaxDropDownItems = 100;
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(151, 28);
            this.cbRace.TabIndex = 4;
            this.cbRace.TextChanged += new System.EventHandler(this.CbRace_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(126, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subrace:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Race:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabAttributes
            // 
            this.tabAttributes.Controls.Add(this.panel2);
            this.tabAttributes.Controls.Add(this.panel1);
            this.tabAttributes.Location = new System.Drawing.Point(4, 29);
            this.tabAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.tabAttributes.Name = "tabAttributes";
            this.tabAttributes.Padding = new System.Windows.Forms.Padding(4);
            this.tabAttributes.Size = new System.Drawing.Size(332, 385);
            this.tabAttributes.TabIndex = 1;
            this.tabAttributes.Text = "Attributes";
            this.tabAttributes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.numCha);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.numWis);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numInt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numCon);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numDex);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numStr);
            this.panel2.Location = new System.Drawing.Point(15, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 257);
            this.panel2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Strength";
            // 
            // numCha
            // 
            this.numCha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCha.Location = new System.Drawing.Point(148, 205);
            this.numCha.Name = "numCha";
            this.numCha.Size = new System.Drawing.Size(120, 26);
            this.numCha.TabIndex = 25;
            this.numCha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCha.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dexterity";
            // 
            // numWis
            // 
            this.numWis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numWis.Location = new System.Drawing.Point(148, 168);
            this.numWis.Name = "numWis";
            this.numWis.Size = new System.Drawing.Size(120, 26);
            this.numWis.TabIndex = 24;
            this.numWis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWis.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Constitution";
            // 
            // numInt
            // 
            this.numInt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numInt.Location = new System.Drawing.Point(148, 131);
            this.numInt.Name = "numInt";
            this.numInt.Size = new System.Drawing.Size(120, 26);
            this.numInt.TabIndex = 23;
            this.numInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numInt.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Intelligence";
            // 
            // numCon
            // 
            this.numCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCon.Location = new System.Drawing.Point(148, 94);
            this.numCon.Name = "numCon";
            this.numCon.Size = new System.Drawing.Size(120, 26);
            this.numCon.TabIndex = 22;
            this.numCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCon.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Wisdom";
            // 
            // numDex
            // 
            this.numDex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numDex.Location = new System.Drawing.Point(148, 57);
            this.numDex.Name = "numDex";
            this.numDex.Size = new System.Drawing.Size(120, 26);
            this.numDex.TabIndex = 21;
            this.numDex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDex.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Charisma";
            // 
            // numStr
            // 
            this.numStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numStr.Location = new System.Drawing.Point(148, 18);
            this.numStr.Name = "numStr";
            this.numStr.Size = new System.Drawing.Size(120, 26);
            this.numStr.TabIndex = 20;
            this.numStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numStr.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkBxPointBuy);
            this.panel1.Controls.Add(this.lblPoints);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 76);
            this.panel1.TabIndex = 0;
            // 
            // chkBxPointBuy
            // 
            this.chkBxPointBuy.AutoSize = true;
            this.chkBxPointBuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkBxPointBuy.Location = new System.Drawing.Point(229, 0);
            this.chkBxPointBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBxPointBuy.Name = "chkBxPointBuy";
            this.chkBxPointBuy.Size = new System.Drawing.Size(95, 76);
            this.chkBxPointBuy.TabIndex = 3;
            this.chkBxPointBuy.Text = "Point Buy";
            this.chkBxPointBuy.UseVisualStyleBackColor = true;
            // 
            // lblPoints
            // 
            this.lblPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPoints.Location = new System.Drawing.Point(4, 23);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(53, 37);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "27";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(332, 459);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(332, 459);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 418);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Character";
            this.Text = "Character";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabAttributes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabAttributes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSubrace;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.CheckBox chkBxPointBuy;
        private System.Windows.Forms.NumericUpDown numCha;
        private System.Windows.Forms.NumericUpDown numWis;
        private System.Windows.Forms.NumericUpDown numInt;
        private System.Windows.Forms.NumericUpDown numCon;
        private System.Windows.Forms.NumericUpDown numDex;
        private System.Windows.Forms.NumericUpDown numStr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
    }
}