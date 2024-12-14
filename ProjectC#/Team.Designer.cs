namespace ProjectC_
{
    partial class Team
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
            this.textBox1TeamName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.TeamName = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.DateCreation = new System.Windows.Forms.Label();
            this.ClubName = new System.Windows.Forms.Label();
            this.dateTimePickerCreation = new System.Windows.Forms.DateTimePicker();
            this.Create = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxClubName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.removePlayerFromTeam = new System.Windows.Forms.Button();
            this.AddCoachToTeam = new System.Windows.Forms.Button();
            this.RemoveCoachFromTeam = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 81);
            this.panel1.TabIndex = 0;
            // 
            // textBox1TeamName
            // 
            this.textBox1TeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1TeamName.Location = new System.Drawing.Point(164, 169);
            this.textBox1TeamName.Name = "textBox1TeamName";
            this.textBox1TeamName.Size = new System.Drawing.Size(296, 34);
            this.textBox1TeamName.TabIndex = 1;
            this.textBox1TeamName.TextChanged += new System.EventHandler(this.textBox1TeamName_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(164, 240);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(296, 74);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(40, 175);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(108, 28);
            this.TeamName.TabIndex = 5;
            this.TeamName.Text = "teamName";
            this.TeamName.Click += new System.EventHandler(this.TeamName_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(33, 271);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(110, 28);
            this.Description.TabIndex = 6;
            this.Description.Text = "description";
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // DateCreation
            // 
            this.DateCreation.AutoSize = true;
            this.DateCreation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCreation.Location = new System.Drawing.Point(33, 364);
            this.DateCreation.Name = "DateCreation";
            this.DateCreation.Size = new System.Drawing.Size(125, 28);
            this.DateCreation.TabIndex = 7;
            this.DateCreation.Text = "dateCreation";
            this.DateCreation.Click += new System.EventHandler(this.label3_Click);
            // 
            // ClubName
            // 
            this.ClubName.AutoSize = true;
            this.ClubName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClubName.Location = new System.Drawing.Point(42, 448);
            this.ClubName.Name = "ClubName";
            this.ClubName.Size = new System.Drawing.Size(101, 28);
            this.ClubName.TabIndex = 8;
            this.ClubName.Text = "clubName";
            this.ClubName.Click += new System.EventHandler(this.ClubName_Click);
            // 
            // dateTimePickerCreation
            // 
            this.dateTimePickerCreation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCreation.Location = new System.Drawing.Point(164, 359);
            this.dateTimePickerCreation.Name = "dateTimePickerCreation";
            this.dateTimePickerCreation.Size = new System.Drawing.Size(296, 34);
            this.dateTimePickerCreation.TabIndex = 9;
            this.dateTimePickerCreation.ValueChanged += new System.EventHandler(this.dateTimePickerCreation_ValueChanged);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Create.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Create.FlatAppearance.BorderSize = 0;
            this.Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ForeColor = System.Drawing.Color.Black;
            this.Create.Location = new System.Drawing.Point(26, 552);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(117, 39);
            this.Create.TabIndex = 10;
            this.Create.Text = "Save";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
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
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Location = new System.Drawing.Point(175, 552);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(117, 39);
            this.Update.TabIndex = 11;
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
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(322, 552);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(117, 39);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(730, 100);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(304, 34);
            this.textBoxSearch.TabIndex = 13;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(630, 106);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 28);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column6,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(526, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 629);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBoxClubName
            // 
            this.comboBoxClubName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClubName.FormattingEnabled = true;
            this.comboBoxClubName.Location = new System.Drawing.Point(175, 445);
            this.comboBoxClubName.Name = "comboBoxClubName";
            this.comboBoxClubName.Size = new System.Drawing.Size(285, 36);
            this.comboBoxClubName.TabIndex = 16;
            this.comboBoxClubName.SelectedIndexChanged += new System.EventHandler(this.comboBoxClubName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "AddPlayerToTeam";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removePlayerFromTeam
            // 
            this.removePlayerFromTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removePlayerFromTeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removePlayerFromTeam.FlatAppearance.BorderSize = 0;
            this.removePlayerFromTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.removePlayerFromTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.removePlayerFromTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayerFromTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayerFromTeam.ForeColor = System.Drawing.Color.Black;
            this.removePlayerFromTeam.Location = new System.Drawing.Point(247, 643);
            this.removePlayerFromTeam.Name = "removePlayerFromTeam";
            this.removePlayerFromTeam.Size = new System.Drawing.Size(192, 43);
            this.removePlayerFromTeam.TabIndex = 18;
            this.removePlayerFromTeam.Text = "RemovePlayerFromTeam";
            this.removePlayerFromTeam.UseVisualStyleBackColor = false;
            this.removePlayerFromTeam.Click += new System.EventHandler(this.removePlayerFromTeam_Click);
            // 
            // AddCoachToTeam
            // 
            this.AddCoachToTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCoachToTeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddCoachToTeam.FlatAppearance.BorderSize = 0;
            this.AddCoachToTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddCoachToTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddCoachToTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCoachToTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCoachToTeam.ForeColor = System.Drawing.Color.Black;
            this.AddCoachToTeam.Location = new System.Drawing.Point(12, 718);
            this.AddCoachToTeam.Name = "AddCoachToTeam";
            this.AddCoachToTeam.Size = new System.Drawing.Size(192, 43);
            this.AddCoachToTeam.TabIndex = 19;
            this.AddCoachToTeam.Text = "AddCoachToTeam";
            this.AddCoachToTeam.UseVisualStyleBackColor = false;
            this.AddCoachToTeam.Click += new System.EventHandler(this.AddCoachToTeam_Click);
            // 
            // RemoveCoachFromTeam
            // 
            this.RemoveCoachFromTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveCoachFromTeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveCoachFromTeam.FlatAppearance.BorderSize = 0;
            this.RemoveCoachFromTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemoveCoachFromTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveCoachFromTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCoachFromTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCoachFromTeam.ForeColor = System.Drawing.Color.Black;
            this.RemoveCoachFromTeam.Location = new System.Drawing.Point(247, 718);
            this.RemoveCoachFromTeam.Name = "RemoveCoachFromTeam";
            this.RemoveCoachFromTeam.Size = new System.Drawing.Size(192, 43);
            this.RemoveCoachFromTeam.TabIndex = 20;
            this.RemoveCoachFromTeam.Text = "RemoveCoachFromTeam";
            this.RemoveCoachFromTeam.UseVisualStyleBackColor = false;
            this.RemoveCoachFromTeam.Click += new System.EventHandler(this.RemoveCoachFromTeam_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "IdTeam";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "CoachName";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "PlayerName";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "TeamName";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Description";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DateCreation";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "ClubName";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1463, 840);
            this.Controls.Add(this.RemoveCoachFromTeam);
            this.Controls.Add(this.AddCoachToTeam);
            this.Controls.Add(this.removePlayerFromTeam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxClubName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.dateTimePickerCreation);
            this.Controls.Add(this.ClubName);
            this.Controls.Add(this.DateCreation);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBox1TeamName);
            this.Controls.Add(this.panel1);
            this.Name = "Team";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1TeamName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label DateCreation;
        private System.Windows.Forms.Label ClubName;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreation;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxClubName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removePlayerFromTeam;
        private System.Windows.Forms.Button AddCoachToTeam;
        private System.Windows.Forms.Button RemoveCoachFromTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}