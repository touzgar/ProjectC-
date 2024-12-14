namespace ProjectC_
{
    partial class Materiel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMaterielName = new System.Windows.Forms.TextBox();
            this.MaterielName = new System.Windows.Forms.Label();
            this.dateTimePickerDateCreation = new System.Windows.Forms.DateTimePicker();
            this.comboBoxClubName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Create = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.Quantite = new System.Windows.Forms.Label();
            this.dateCreation = new System.Windows.Forms.Label();
            this.ClubName = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBoxMaterielName
            // 
            this.textBoxMaterielName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaterielName.Location = new System.Drawing.Point(194, 165);
            this.textBoxMaterielName.Name = "textBoxMaterielName";
            this.textBoxMaterielName.Size = new System.Drawing.Size(314, 34);
            this.textBoxMaterielName.TabIndex = 1;
            this.textBoxMaterielName.TextChanged += new System.EventHandler(this.textBoxMaterielName_TextChanged);
            // 
            // MaterielName
            // 
            this.MaterielName.AutoSize = true;
            this.MaterielName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterielName.Location = new System.Drawing.Point(32, 168);
            this.MaterielName.Name = "MaterielName";
            this.MaterielName.Size = new System.Drawing.Size(136, 28);
            this.MaterielName.TabIndex = 2;
            this.MaterielName.Text = "MaterielName";
            this.MaterielName.Click += new System.EventHandler(this.MaterielName_Click);
            // 
            // dateTimePickerDateCreation
            // 
            this.dateTimePickerDateCreation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateCreation.Location = new System.Drawing.Point(194, 381);
            this.dateTimePickerDateCreation.Name = "dateTimePickerDateCreation";
            this.dateTimePickerDateCreation.Size = new System.Drawing.Size(314, 34);
            this.dateTimePickerDateCreation.TabIndex = 3;
            this.dateTimePickerDateCreation.ValueChanged += new System.EventHandler(this.dateTimePickerDateCreation_ValueChanged);
            // 
            // comboBoxClubName
            // 
            this.comboBoxClubName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClubName.FormattingEnabled = true;
            this.comboBoxClubName.Location = new System.Drawing.Point(194, 523);
            this.comboBoxClubName.Name = "comboBoxClubName";
            this.comboBoxClubName.Size = new System.Drawing.Size(314, 36);
            this.comboBoxClubName.TabIndex = 4;
            this.comboBoxClubName.SelectedIndexChanged += new System.EventHandler(this.comboBoxClubName_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(543, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(915, 604);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.Highlight;
            this.Create.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Create.FlatAppearance.BorderSize = 0;
            this.Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(37, 648);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(104, 38);
            this.Create.TabIndex = 6;
            this.Create.Text = "Save";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(817, 124);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(329, 34);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantite.Location = new System.Drawing.Point(194, 275);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(314, 34);
            this.textBoxQuantite.TabIndex = 8;
            this.textBoxQuantite.TextChanged += new System.EventHandler(this.textBoxQuantite_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(703, 130);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 28);
            this.Search.TabIndex = 9;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Quantite
            // 
            this.Quantite.AutoSize = true;
            this.Quantite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantite.Location = new System.Drawing.Point(32, 275);
            this.Quantite.Name = "Quantite";
            this.Quantite.Size = new System.Drawing.Size(88, 28);
            this.Quantite.TabIndex = 10;
            this.Quantite.Text = "Quantite";
            this.Quantite.Click += new System.EventHandler(this.Quantite_Click);
            // 
            // dateCreation
            // 
            this.dateCreation.AutoSize = true;
            this.dateCreation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreation.Location = new System.Drawing.Point(12, 387);
            this.dateCreation.Name = "dateCreation";
            this.dateCreation.Size = new System.Drawing.Size(127, 28);
            this.dateCreation.TabIndex = 11;
            this.dateCreation.Text = "DateCreation";
            this.dateCreation.Click += new System.EventHandler(this.dateCreation_Click);
            // 
            // ClubName
            // 
            this.ClubName.AutoSize = true;
            this.ClubName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClubName.Location = new System.Drawing.Point(32, 531);
            this.ClubName.Name = "ClubName";
            this.ClubName.Size = new System.Drawing.Size(104, 28);
            this.ClubName.TabIndex = 12;
            this.ClubName.Text = "ClubName";
            this.ClubName.Click += new System.EventHandler(this.ClubName_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(212, 648);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(104, 38);
            this.Update.TabIndex = 13;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(386, 648);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(104, 38);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "IdMateriel";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "MaterielName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Quantite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "DateCreation";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ClubName";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Materiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 799);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.ClubName);
            this.Controls.Add(this.dateCreation);
            this.Controls.Add(this.Quantite);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxQuantite);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxClubName);
            this.Controls.Add(this.dateTimePickerDateCreation);
            this.Controls.Add(this.MaterielName);
            this.Controls.Add(this.textBoxMaterielName);
            this.Controls.Add(this.panel1);
            this.Name = "Materiel";
            this.Text = "Materiel";
            this.Load += new System.EventHandler(this.Materiel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMaterielName;
        private System.Windows.Forms.Label MaterielName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreation;
        private System.Windows.Forms.ComboBox comboBoxClubName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label Quantite;
        private System.Windows.Forms.Label dateCreation;
        private System.Windows.Forms.Label ClubName;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}