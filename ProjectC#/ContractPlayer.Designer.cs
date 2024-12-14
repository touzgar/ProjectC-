namespace ProjectC_
{
    partial class ContractPlayer
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
            this.textBoxContractName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateStart = new System.Windows.Forms.DateTimePicker();
            this.contractName = new System.Windows.Forms.Label();
            this.comboBoxPlayerName = new System.Windows.Forms.ComboBox();
            this.Create = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxTermesFinanciere = new System.Windows.Forms.TextBox();
            this.termesFinanciere = new System.Windows.Forms.Label();
            this.textBoxObjective = new System.Windows.Forms.TextBox();
            this.objective = new System.Windows.Forms.Label();
            this.dateTimePickerDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 112);
            this.panel1.TabIndex = 0;
            // 
            // textBoxContractName
            // 
            this.textBoxContractName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContractName.Location = new System.Drawing.Point(175, 202);
            this.textBoxContractName.Name = "textBoxContractName";
            this.textBoxContractName.Size = new System.Drawing.Size(289, 34);
            this.textBoxContractName.TabIndex = 1;
            this.textBoxContractName.TextChanged += new System.EventHandler(this.textBoxContractName_TextChanged);
            // 
            // dateTimePickerDateStart
            // 
            this.dateTimePickerDateStart.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateStart.Location = new System.Drawing.Point(175, 465);
            this.dateTimePickerDateStart.Name = "dateTimePickerDateStart";
            this.dateTimePickerDateStart.Size = new System.Drawing.Size(289, 22);
            this.dateTimePickerDateStart.TabIndex = 2;
            this.dateTimePickerDateStart.ValueChanged += new System.EventHandler(this.dateTimePickerDateStart_ValueChanged);
            // 
            // contractName
            // 
            this.contractName.AutoSize = true;
            this.contractName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractName.Location = new System.Drawing.Point(9, 205);
            this.contractName.Name = "contractName";
            this.contractName.Size = new System.Drawing.Size(139, 28);
            this.contractName.TabIndex = 3;
            this.contractName.Text = "ContractName";
            this.contractName.Click += new System.EventHandler(this.contractName_Click);
            // 
            // comboBoxPlayerName
            // 
            this.comboBoxPlayerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayerName.FormattingEnabled = true;
            this.comboBoxPlayerName.Location = new System.Drawing.Point(175, 604);
            this.comboBoxPlayerName.Name = "comboBoxPlayerName";
            this.comboBoxPlayerName.Size = new System.Drawing.Size(289, 36);
            this.comboBoxPlayerName.TabIndex = 4;
            this.comboBoxPlayerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayerName_SelectedIndexChanged);
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
            this.Create.Location = new System.Drawing.Point(26, 705);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(87, 39);
            this.Create.TabIndex = 5;
            this.Create.Text = "Save";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
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
            this.Column7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(496, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 582);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxTermesFinanciere
            // 
            this.textBoxTermesFinanciere.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTermesFinanciere.Location = new System.Drawing.Point(175, 297);
            this.textBoxTermesFinanciere.Name = "textBoxTermesFinanciere";
            this.textBoxTermesFinanciere.Size = new System.Drawing.Size(289, 34);
            this.textBoxTermesFinanciere.TabIndex = 7;
            this.textBoxTermesFinanciere.TextChanged += new System.EventHandler(this.textBoxTermesFinanciere_TextChanged);
            // 
            // termesFinanciere
            // 
            this.termesFinanciere.AutoSize = true;
            this.termesFinanciere.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termesFinanciere.Location = new System.Drawing.Point(9, 303);
            this.termesFinanciere.Name = "termesFinanciere";
            this.termesFinanciere.Size = new System.Drawing.Size(160, 28);
            this.termesFinanciere.TabIndex = 8;
            this.termesFinanciere.Text = "TermesFinanciere";
            this.termesFinanciere.Click += new System.EventHandler(this.termesFinanciere_Click);
            // 
            // textBoxObjective
            // 
            this.textBoxObjective.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObjective.Location = new System.Drawing.Point(175, 379);
            this.textBoxObjective.Multiline = true;
            this.textBoxObjective.Name = "textBoxObjective";
            this.textBoxObjective.Size = new System.Drawing.Size(289, 44);
            this.textBoxObjective.TabIndex = 9;
            this.textBoxObjective.TextChanged += new System.EventHandler(this.textBoxObjective_TextChanged);
            // 
            // objective
            // 
            this.objective.AutoSize = true;
            this.objective.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objective.Location = new System.Drawing.Point(54, 382);
            this.objective.Name = "objective";
            this.objective.Size = new System.Drawing.Size(95, 28);
            this.objective.TabIndex = 10;
            this.objective.Text = "Objective";
            this.objective.Click += new System.EventHandler(this.objective_Click);
            // 
            // dateTimePickerDateEnd
            // 
            this.dateTimePickerDateEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateEnd.Location = new System.Drawing.Point(175, 534);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.Size = new System.Drawing.Size(289, 30);
            this.dateTimePickerDateEnd.TabIndex = 11;
            this.dateTimePickerDateEnd.ValueChanged += new System.EventHandler(this.dateTimePickerDateEnd_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.AutoSize = true;
            this.dateStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(54, 465);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(94, 28);
            this.dateStart.TabIndex = 12;
            this.dateStart.Text = "DateStart";
            this.dateStart.Click += new System.EventHandler(this.dateStart_Click);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(21, 612);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(117, 28);
            this.playerName.TabIndex = 13;
            this.playerName.Text = "PlayerName";
            this.playerName.Click += new System.EventHandler(this.playerName_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.AutoSize = true;
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(54, 536);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(86, 28);
            this.dateEnd.TabIndex = 14;
            this.dateEnd.Text = "DateEnd";
            this.dateEnd.Click += new System.EventHandler(this.dateEnd_Click);
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
            this.Delete.Location = new System.Drawing.Point(290, 705);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 39);
            this.Delete.TabIndex = 15;
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
            this.Update.Location = new System.Drawing.Point(156, 705);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(87, 39);
            this.Update.TabIndex = 16;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(803, 134);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(278, 34);
            this.textBoxSearch.TabIndex = 17;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(696, 134);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(70, 28);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "IdContractPlayer";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "ContractName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "TermesFinanciere";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Objective";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "DateStart";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "DateEnd";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "PlayerName";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // ContractPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 796);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.dateTimePickerDateEnd);
            this.Controls.Add(this.objective);
            this.Controls.Add(this.textBoxObjective);
            this.Controls.Add(this.termesFinanciere);
            this.Controls.Add(this.textBoxTermesFinanciere);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.comboBoxPlayerName);
            this.Controls.Add(this.contractName);
            this.Controls.Add(this.dateTimePickerDateStart);
            this.Controls.Add(this.textBoxContractName);
            this.Controls.Add(this.panel1);
            this.Name = "ContractPlayer";
            this.Text = "ContractPlayer";
            this.Load += new System.EventHandler(this.ContractPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxContractName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateStart;
        private System.Windows.Forms.Label contractName;
        private System.Windows.Forms.ComboBox comboBoxPlayerName;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTermesFinanciere;
        private System.Windows.Forms.Label termesFinanciere;
        private System.Windows.Forms.TextBox textBoxObjective;
        private System.Windows.Forms.Label objective;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEnd;
        private System.Windows.Forms.Label dateStart;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label dateEnd;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}