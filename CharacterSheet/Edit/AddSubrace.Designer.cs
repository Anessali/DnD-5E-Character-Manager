namespace CharacterSheet.Edit
{
    partial class AddSubrace
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxRace = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStr = new System.Windows.Forms.NumericUpDown();
            this.txtDex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCon = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.NumericUpDown();
            this.txtCha = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWis = new System.Windows.Forms.NumericUpDown();
            this.txtSpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAccept, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 421);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 53);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(310, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(302, 47);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAccept.Location = new System.Drawing.Point(3, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(301, 47);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 26);
            this.txtName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Subrace Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Race Derived From";
            // 
            // cbBoxRace
            // 
            this.cbBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxRace.FormattingEnabled = true;
            this.cbBoxRace.Location = new System.Drawing.Point(189, 78);
            this.cbBoxRace.Name = "cbBoxRace";
            this.cbBoxRace.Size = new System.Drawing.Size(153, 28);
            this.cbBoxRace.TabIndex = 21;
            this.cbBoxRace.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Strength";
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(125, 173);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(96, 26);
            this.txtStr.TabIndex = 22;
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(313, 173);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(96, 26);
            this.txtDex.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dexterity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Constitution";
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(125, 256);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(96, 26);
            this.txtCon.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Intelligence";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(313, 256);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(96, 26);
            this.txtInt.TabIndex = 29;
            // 
            // txtCha
            // 
            this.txtCha.Location = new System.Drawing.Point(313, 336);
            this.txtCha.Name = "txtCha";
            this.txtCha.Size = new System.Drawing.Size(96, 26);
            this.txtCha.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Charisma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Wisdom";
            // 
            // txtWis
            // 
            this.txtWis.Location = new System.Drawing.Point(125, 336);
            this.txtWis.Name = "txtWis";
            this.txtWis.Size = new System.Drawing.Size(96, 26);
            this.txtWis.TabIndex = 32;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtSpeed.Location = new System.Drawing.Point(495, 173);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(96, 26);
            this.txtSpeed.TabIndex = 34;
            this.txtSpeed.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Speed";
            // 
            // AddSubrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 474);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.cbBoxRace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSubrace";
            this.Text = "Subrace";
            this.Load += new System.EventHandler(this.AddSubrace_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAccept;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbBoxRace;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown txtStr;
        public System.Windows.Forms.NumericUpDown txtDex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown txtCon;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown txtInt;
        public System.Windows.Forms.NumericUpDown txtCha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown txtWis;
        public System.Windows.Forms.NumericUpDown txtSpeed;
        private System.Windows.Forms.Label label9;
    }
}