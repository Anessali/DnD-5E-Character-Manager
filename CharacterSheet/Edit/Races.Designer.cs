namespace CharacterSheet.Edit
{
    partial class Races
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.racesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnDataDataSet = new CharacterSheet.DnDataDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.racesTableAdapter = new CharacterSheet.DnDataDataSetTableAdapters.RacesTableAdapter();
            this.dGridRaces = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGridNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dexterityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constitutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intelligenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wisdomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charismaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trait1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trait2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trait3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trait4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDataDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridRaces)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dGridRaces);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(348, 383);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 2;
            // 
            // racesBindingSource
            // 
            this.racesBindingSource.DataMember = "Races";
            this.racesBindingSource.DataSource = this.dnDataDataSetBindingSource;
            // 
            // dnDataDataSetBindingSource
            // 
            this.dnDataDataSetBindingSource.DataSource = this.dnDataDataSet;
            this.dnDataDataSetBindingSource.Position = 0;
            // 
            // dnDataDataSet
            // 
            this.dnDataDataSet.DataSetName = "DnDataDataSet";
            this.dnDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 38);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(90, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(264, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Location = new System.Drawing.Point(177, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // racesTableAdapter
            // 
            this.racesTableAdapter.ClearBeforeFill = true;
            // 
            // dGridRaces
            // 
            this.dGridRaces.AutoGenerateColumns = false;
            this.dGridRaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridRaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridRaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dGridNameColumn,
            this.speedDataGridViewTextBoxColumn,
            this.strengthDataGridViewTextBoxColumn,
            this.dexterityDataGridViewTextBoxColumn,
            this.constitutionDataGridViewTextBoxColumn,
            this.intelligenceDataGridViewTextBoxColumn,
            this.wisdomDataGridViewTextBoxColumn,
            this.charismaDataGridViewTextBoxColumn,
            this.trait1DataGridViewTextBoxColumn,
            this.trait2DataGridViewTextBoxColumn,
            this.trait3DataGridViewTextBoxColumn,
            this.trait4DataGridViewTextBoxColumn});
            this.dGridRaces.DataSource = this.racesBindingSource;
            this.dGridRaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridRaces.Location = new System.Drawing.Point(0, 0);
            this.dGridRaces.Name = "dGridRaces";
            this.dGridRaces.ReadOnly = true;
            this.dGridRaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridRaces.Size = new System.Drawing.Size(348, 341);
            this.dGridRaces.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dGridNameColumn
            // 
            this.dGridNameColumn.DataPropertyName = "Name";
            this.dGridNameColumn.HeaderText = "Name";
            this.dGridNameColumn.Name = "dGridNameColumn";
            this.dGridNameColumn.ReadOnly = true;
            this.dGridNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedDataGridViewTextBoxColumn.Visible = false;
            // 
            // strengthDataGridViewTextBoxColumn
            // 
            this.strengthDataGridViewTextBoxColumn.DataPropertyName = "Strength";
            this.strengthDataGridViewTextBoxColumn.HeaderText = "Strength";
            this.strengthDataGridViewTextBoxColumn.Name = "strengthDataGridViewTextBoxColumn";
            this.strengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.strengthDataGridViewTextBoxColumn.Visible = false;
            // 
            // dexterityDataGridViewTextBoxColumn
            // 
            this.dexterityDataGridViewTextBoxColumn.DataPropertyName = "Dexterity";
            this.dexterityDataGridViewTextBoxColumn.HeaderText = "Dexterity";
            this.dexterityDataGridViewTextBoxColumn.Name = "dexterityDataGridViewTextBoxColumn";
            this.dexterityDataGridViewTextBoxColumn.ReadOnly = true;
            this.dexterityDataGridViewTextBoxColumn.Visible = false;
            // 
            // constitutionDataGridViewTextBoxColumn
            // 
            this.constitutionDataGridViewTextBoxColumn.DataPropertyName = "Constitution";
            this.constitutionDataGridViewTextBoxColumn.HeaderText = "Constitution";
            this.constitutionDataGridViewTextBoxColumn.Name = "constitutionDataGridViewTextBoxColumn";
            this.constitutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.constitutionDataGridViewTextBoxColumn.Visible = false;
            // 
            // intelligenceDataGridViewTextBoxColumn
            // 
            this.intelligenceDataGridViewTextBoxColumn.DataPropertyName = "Intelligence";
            this.intelligenceDataGridViewTextBoxColumn.HeaderText = "Intelligence";
            this.intelligenceDataGridViewTextBoxColumn.Name = "intelligenceDataGridViewTextBoxColumn";
            this.intelligenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.intelligenceDataGridViewTextBoxColumn.Visible = false;
            // 
            // wisdomDataGridViewTextBoxColumn
            // 
            this.wisdomDataGridViewTextBoxColumn.DataPropertyName = "Wisdom";
            this.wisdomDataGridViewTextBoxColumn.HeaderText = "Wisdom";
            this.wisdomDataGridViewTextBoxColumn.Name = "wisdomDataGridViewTextBoxColumn";
            this.wisdomDataGridViewTextBoxColumn.ReadOnly = true;
            this.wisdomDataGridViewTextBoxColumn.Visible = false;
            // 
            // charismaDataGridViewTextBoxColumn
            // 
            this.charismaDataGridViewTextBoxColumn.DataPropertyName = "Charisma";
            this.charismaDataGridViewTextBoxColumn.HeaderText = "Charisma";
            this.charismaDataGridViewTextBoxColumn.Name = "charismaDataGridViewTextBoxColumn";
            this.charismaDataGridViewTextBoxColumn.ReadOnly = true;
            this.charismaDataGridViewTextBoxColumn.Visible = false;
            // 
            // trait1DataGridViewTextBoxColumn
            // 
            this.trait1DataGridViewTextBoxColumn.DataPropertyName = "Trait1";
            this.trait1DataGridViewTextBoxColumn.HeaderText = "Trait1";
            this.trait1DataGridViewTextBoxColumn.Name = "trait1DataGridViewTextBoxColumn";
            this.trait1DataGridViewTextBoxColumn.ReadOnly = true;
            this.trait1DataGridViewTextBoxColumn.Visible = false;
            // 
            // trait2DataGridViewTextBoxColumn
            // 
            this.trait2DataGridViewTextBoxColumn.DataPropertyName = "Trait2";
            this.trait2DataGridViewTextBoxColumn.HeaderText = "Trait2";
            this.trait2DataGridViewTextBoxColumn.Name = "trait2DataGridViewTextBoxColumn";
            this.trait2DataGridViewTextBoxColumn.ReadOnly = true;
            this.trait2DataGridViewTextBoxColumn.Visible = false;
            // 
            // trait3DataGridViewTextBoxColumn
            // 
            this.trait3DataGridViewTextBoxColumn.DataPropertyName = "Trait3";
            this.trait3DataGridViewTextBoxColumn.HeaderText = "Trait3";
            this.trait3DataGridViewTextBoxColumn.Name = "trait3DataGridViewTextBoxColumn";
            this.trait3DataGridViewTextBoxColumn.ReadOnly = true;
            this.trait3DataGridViewTextBoxColumn.Visible = false;
            // 
            // trait4DataGridViewTextBoxColumn
            // 
            this.trait4DataGridViewTextBoxColumn.DataPropertyName = "Trait4";
            this.trait4DataGridViewTextBoxColumn.HeaderText = "Trait4";
            this.trait4DataGridViewTextBoxColumn.Name = "trait4DataGridViewTextBoxColumn";
            this.trait4DataGridViewTextBoxColumn.ReadOnly = true;
            this.trait4DataGridViewTextBoxColumn.Visible = false;
            // 
            // Races
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 383);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Races";
            this.Text = "Races";
            this.Load += new System.EventHandler(this.Races_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnDataDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridRaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private DnDataDataSet dnDataDataSet;
        private System.Windows.Forms.BindingSource dnDataDataSetBindingSource;
        private System.Windows.Forms.BindingSource racesBindingSource;
        private DnDataDataSetTableAdapters.RacesTableAdapter racesTableAdapter;
        private System.Windows.Forms.DataGridView dGridRaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGridNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dexterityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constitutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intelligenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wisdomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charismaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trait1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trait2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trait3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trait4DataGridViewTextBoxColumn;
    }
}