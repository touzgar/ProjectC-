namespace ProjectC_
{
    partial class RemoveTeamFromTournament
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
            this.comboBoxTournamentName = new System.Windows.Forms.ComboBox();
            this.TournamentName = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.TeamName = new System.Windows.Forms.Label();
            this.comboBoxTeamName = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTournamentName
            // 
            this.comboBoxTournamentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTournamentName.FormattingEnabled = true;
            this.comboBoxTournamentName.Location = new System.Drawing.Point(250, 114);
            this.comboBoxTournamentName.Name = "comboBoxTournamentName";
            this.comboBoxTournamentName.Size = new System.Drawing.Size(206, 36);
            this.comboBoxTournamentName.TabIndex = 0;
            this.comboBoxTournamentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTournamentName_SelectedIndexChanged);
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.Location = new System.Drawing.Point(41, 114);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(168, 28);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "TournamentName";
            this.TournamentName.Click += new System.EventHandler(this.TournamentName_Click);
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.Color.LawnGreen;
            this.Accept.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Accept.FlatAppearance.BorderSize = 0;
            this.Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accept.Location = new System.Drawing.Point(115, 300);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(140, 41);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(41, 206);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(109, 28);
            this.TeamName.TabIndex = 3;
            this.TeamName.Text = "TeamName";
            this.TeamName.Click += new System.EventHandler(this.TeamName_Click);
            // 
            // comboBoxTeamName
            // 
            this.comboBoxTeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeamName.FormattingEnabled = true;
            this.comboBoxTeamName.Location = new System.Drawing.Point(250, 206);
            this.comboBoxTeamName.Name = "comboBoxTeamName";
            this.comboBoxTeamName.Size = new System.Drawing.Size(206, 36);
            this.comboBoxTeamName.TabIndex = 4;
            this.comboBoxTeamName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeamName_SelectedIndexChanged);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(307, 300);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(140, 41);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // RemoveTeamFromTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.comboBoxTeamName);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.comboBoxTournamentName);
            this.Name = "RemoveTeamFromTournament";
            this.Text = "RemoveTeamFromTournament";
            this.Load += new System.EventHandler(this.RemoveTeamFromTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTournamentName;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.ComboBox comboBoxTeamName;
        private System.Windows.Forms.Button Cancel;
    }
}