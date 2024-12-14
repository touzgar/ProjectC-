namespace ProjectC_
{
    partial class Tournament
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTournamentName = new System.Windows.Forms.TextBox();
            this.tournamentName = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.prize_pool = new System.Windows.Forms.Label();
            this.Format = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textBoxPrize_Pool = new System.Windows.Forms.TextBox();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.dateEnd = new System.Windows.Forms.Label();
            this.dateTimePickerDateStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTeamToTournament = new System.Windows.Forms.Button();
            this.RemoveTeamFromTournament = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1473, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBoxTournamentName
            // 
            this.textBoxTournamentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTournamentName.Location = new System.Drawing.Point(208, 150);
            this.textBoxTournamentName.Name = "textBoxTournamentName";
            this.textBoxTournamentName.Size = new System.Drawing.Size(308, 34);
            this.textBoxTournamentName.TabIndex = 1;
            this.textBoxTournamentName.TextChanged += new System.EventHandler(this.textBoxTournamentName_TextChanged);
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.Location = new System.Drawing.Point(22, 150);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(168, 28);
            this.tournamentName.TabIndex = 2;
            this.tournamentName.Text = "TournamentName";
            this.tournamentName.Click += new System.EventHandler(this.tournamentName_Click);
            // 
            // dateStart
            // 
            this.dateStart.AutoSize = true;
            this.dateStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(35, 516);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(94, 28);
            this.dateStart.TabIndex = 3;
            this.dateStart.Text = "DateStart";
            this.dateStart.Click += new System.EventHandler(this.dateStart_Click);
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(42, 424);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(87, 28);
            this.capacity.TabIndex = 4;
            this.capacity.Text = "Capacity";
            this.capacity.Click += new System.EventHandler(this.capacity_Click);
            // 
            // prize_pool
            // 
            this.prize_pool.AutoSize = true;
            this.prize_pool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prize_pool.Location = new System.Drawing.Point(35, 331);
            this.prize_pool.Name = "prize_pool";
            this.prize_pool.Size = new System.Drawing.Size(101, 28);
            this.prize_pool.TabIndex = 5;
            this.prize_pool.Text = "Prize_Pool";
            this.prize_pool.Click += new System.EventHandler(this.prize_pool_Click);
            // 
            // Format
            // 
            this.Format.AutoSize = true;
            this.Format.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Format.Location = new System.Drawing.Point(35, 234);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(75, 28);
            this.Format.TabIndex = 6;
            this.Format.Text = "Format";
            this.Format.Click += new System.EventHandler(this.Format_Click);
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCapacity.Location = new System.Drawing.Point(208, 424);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(308, 34);
            this.textBoxCapacity.TabIndex = 9;
            this.textBoxCapacity.TextChanged += new System.EventHandler(this.textBoxCapacity_TextChanged);
            // 
            // textBoxPrize_Pool
            // 
            this.textBoxPrize_Pool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrize_Pool.Location = new System.Drawing.Point(208, 328);
            this.textBoxPrize_Pool.Name = "textBoxPrize_Pool";
            this.textBoxPrize_Pool.Size = new System.Drawing.Size(308, 34);
            this.textBoxPrize_Pool.TabIndex = 10;
            this.textBoxPrize_Pool.TextChanged += new System.EventHandler(this.textBoxPrize_Pool_TextChanged);
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFormat.Location = new System.Drawing.Point(209, 234);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(307, 34);
            this.textBoxFormat.TabIndex = 11;
            this.textBoxFormat.TextChanged += new System.EventHandler(this.textBoxFormat_TextChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.AutoSize = true;
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(42, 616);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(86, 28);
            this.dateEnd.TabIndex = 12;
            this.dateEnd.Text = "DateEnd";
            this.dateEnd.Click += new System.EventHandler(this.dateEnd_Click);
            // 
            // dateTimePickerDateStart
            // 
            this.dateTimePickerDateStart.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateStart.Location = new System.Drawing.Point(208, 531);
            this.dateTimePickerDateStart.Name = "dateTimePickerDateStart";
            this.dateTimePickerDateStart.Size = new System.Drawing.Size(308, 22);
            this.dateTimePickerDateStart.TabIndex = 13;
            this.dateTimePickerDateStart.ValueChanged += new System.EventHandler(this.dateTimePickerDateStart_ValueChanged);
            // 
            // dateTimePickerDateEnd
            // 
            this.dateTimePickerDateEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateEnd.Location = new System.Drawing.Point(209, 622);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.Size = new System.Drawing.Size(307, 22);
            this.dateTimePickerDateEnd.TabIndex = 14;
            this.dateTimePickerDateEnd.ValueChanged += new System.EventHandler(this.dateTimePickerDateEnd_ValueChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(719, 128);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(329, 34);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(625, 131);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 28);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
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
            this.Create.ForeColor = System.Drawing.Color.White;
            this.Create.Location = new System.Drawing.Point(40, 679);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(111, 42);
            this.Create.TabIndex = 17;
            this.Create.Text = "Save";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
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
            this.Delete.Location = new System.Drawing.Point(323, 679);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 42);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
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
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(190, 679);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(111, 42);
            this.Update.TabIndex = 19;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
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
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(564, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(897, 599);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "IdTournament";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "TournamentName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Format";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Prize_Poll";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Capacity";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "DateStart";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "DateEnd";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "TeamName";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // addTeamToTournament
            // 
            this.addTeamToTournament.BackColor = System.Drawing.Color.Gray;
            this.addTeamToTournament.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addTeamToTournament.FlatAppearance.BorderSize = 0;
            this.addTeamToTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addTeamToTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addTeamToTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamToTournament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamToTournament.Location = new System.Drawing.Point(12, 749);
            this.addTeamToTournament.Name = "addTeamToTournament";
            this.addTeamToTournament.Size = new System.Drawing.Size(233, 51);
            this.addTeamToTournament.TabIndex = 21;
            this.addTeamToTournament.Text = "AddTeamToTournament";
            this.addTeamToTournament.UseVisualStyleBackColor = false;
            this.addTeamToTournament.Click += new System.EventHandler(this.addTeamToTournament_Click);
            // 
            // RemoveTeamFromTournament
            // 
            this.RemoveTeamFromTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveTeamFromTournament.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveTeamFromTournament.FlatAppearance.BorderSize = 0;
            this.RemoveTeamFromTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemoveTeamFromTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveTeamFromTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveTeamFromTournament.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTeamFromTournament.Location = new System.Drawing.Point(251, 749);
            this.RemoveTeamFromTournament.Name = "RemoveTeamFromTournament";
            this.RemoveTeamFromTournament.Size = new System.Drawing.Size(288, 51);
            this.RemoveTeamFromTournament.TabIndex = 22;
            this.RemoveTeamFromTournament.Text = "RemoveTeamFromTournament";
            this.RemoveTeamFromTournament.UseVisualStyleBackColor = false;
            this.RemoveTeamFromTournament.Click += new System.EventHandler(this.RemoveTeamFromTournament_Click);
            // 
            // Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 821);
            this.Controls.Add(this.RemoveTeamFromTournament);
            this.Controls.Add(this.addTeamToTournament);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dateTimePickerDateEnd);
            this.Controls.Add(this.dateTimePickerDateStart);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.textBoxFormat);
            this.Controls.Add(this.textBoxPrize_Pool);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.prize_pool);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.textBoxTournamentName);
            this.Controls.Add(this.panel1);
            this.Name = "Tournament";
            this.Text = "Tournament";
            this.Load += new System.EventHandler(this.Tournament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTournamentName;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label dateStart;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label prize_pool;
        private System.Windows.Forms.Label Format;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.TextBox textBoxPrize_Pool;
        private System.Windows.Forms.TextBox textBoxFormat;
        private System.Windows.Forms.Label dateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEnd;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button addTeamToTournament;
        private System.Windows.Forms.Button RemoveTeamFromTournament;
    }
}