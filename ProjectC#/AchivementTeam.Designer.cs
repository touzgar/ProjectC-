namespace ProjectC_
{
    partial class AchivementTeam
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
            this.textBoxTrophie = new System.Windows.Forms.TextBox();
            this.Trophie = new System.Windows.Forms.Label();
            this.comboBoxTeamName = new System.Windows.Forms.ComboBox();
            this.DateAchived = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.Label();
            this.dateTimePickerAchived = new System.Windows.Forms.DateTimePicker();
            this.Create = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(1454, 89);
            this.panel1.TabIndex = 0;
            // 
            // textBoxTrophie
            // 
            this.textBoxTrophie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrophie.Location = new System.Drawing.Point(152, 199);
            this.textBoxTrophie.Multiline = true;
            this.textBoxTrophie.Name = "textBoxTrophie";
            this.textBoxTrophie.Size = new System.Drawing.Size(281, 43);
            this.textBoxTrophie.TabIndex = 1;
            this.textBoxTrophie.TextChanged += new System.EventHandler(this.textBoxTrophie_TextChanged);
            // 
            // Trophie
            // 
            this.Trophie.AutoSize = true;
            this.Trophie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trophie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trophie.Location = new System.Drawing.Point(48, 214);
            this.Trophie.Name = "Trophie";
            this.Trophie.Size = new System.Drawing.Size(77, 28);
            this.Trophie.TabIndex = 2;
            this.Trophie.Text = "Trophie";
            this.Trophie.Click += new System.EventHandler(this.Trophie_Click);
            // 
            // comboBoxTeamName
            // 
            this.comboBoxTeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeamName.FormattingEnabled = true;
            this.comboBoxTeamName.Location = new System.Drawing.Point(152, 405);
            this.comboBoxTeamName.Name = "comboBoxTeamName";
            this.comboBoxTeamName.Size = new System.Drawing.Size(281, 36);
            this.comboBoxTeamName.TabIndex = 3;
            this.comboBoxTeamName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeamName_SelectedIndexChanged);
            // 
            // DateAchived
            // 
            this.DateAchived.AutoSize = true;
            this.DateAchived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateAchived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAchived.Location = new System.Drawing.Point(23, 300);
            this.DateAchived.Name = "DateAchived";
            this.DateAchived.Size = new System.Drawing.Size(123, 28);
            this.DateAchived.TabIndex = 4;
            this.DateAchived.Text = "DateAchived";
            this.DateAchived.Click += new System.EventHandler(this.DateAchived_Click);
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(37, 405);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(109, 28);
            this.TeamName.TabIndex = 5;
            this.TeamName.Text = "TeamName";
            this.TeamName.Click += new System.EventHandler(this.TeamName_Click);
            // 
            // dateTimePickerAchived
            // 
            this.dateTimePickerAchived.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAchived.Location = new System.Drawing.Point(152, 305);
            this.dateTimePickerAchived.Name = "dateTimePickerAchived";
            this.dateTimePickerAchived.Size = new System.Drawing.Size(281, 22);
            this.dateTimePickerAchived.TabIndex = 6;
            this.dateTimePickerAchived.ValueChanged += new System.EventHandler(this.dateTimePickerAchived_ValueChanged);
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
            this.Create.ForeColor = System.Drawing.Color.White;
            this.Create.Location = new System.Drawing.Point(53, 563);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(97, 41);
            this.Create.TabIndex = 7;
            this.Create.Text = "Save";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(191, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(321, 563);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 41);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(709, 116);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 28);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(813, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 34);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(519, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 621);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "idAchivementTeam";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Trophie";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DateAchived";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "TeamName";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // AchivementTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 808);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.dateTimePickerAchived);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.DateAchived);
            this.Controls.Add(this.comboBoxTeamName);
            this.Controls.Add(this.Trophie);
            this.Controls.Add(this.textBoxTrophie);
            this.Controls.Add(this.panel1);
            this.Name = "AchivementTeam";
            this.Text = "AchivementTeam";
            this.Load += new System.EventHandler(this.AchivementTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTrophie;
        private System.Windows.Forms.Label Trophie;
        private System.Windows.Forms.ComboBox comboBoxTeamName;
        private System.Windows.Forms.Label DateAchived;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.DateTimePicker dateTimePickerAchived;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}