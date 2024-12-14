namespace ProjectC_
{
    partial class AddTeamToTournament
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
            this.TeamName = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTeamName = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTournamentName
            // 
            this.comboBoxTournamentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTournamentName.FormattingEnabled = true;
            this.comboBoxTournamentName.Location = new System.Drawing.Point(238, 137);
            this.comboBoxTournamentName.Name = "comboBoxTournamentName";
            this.comboBoxTournamentName.Size = new System.Drawing.Size(252, 36);
            this.comboBoxTournamentName.TabIndex = 0;
            this.comboBoxTournamentName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTournamentName_SelectedIndexChanged);
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(53, 137);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(168, 28);
            this.TeamName.TabIndex = 1;
            this.TeamName.Text = "TournamentName";
            this.TeamName.Click += new System.EventHandler(this.TeamName_Click);
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
            this.Accept.Location = new System.Drawing.Point(175, 322);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(123, 40);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "TeamName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxTeamName
            // 
            this.comboBoxTeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeamName.FormattingEnabled = true;
            this.comboBoxTeamName.Location = new System.Drawing.Point(238, 234);
            this.comboBoxTeamName.Name = "comboBoxTeamName";
            this.comboBoxTeamName.Size = new System.Drawing.Size(252, 36);
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
            this.Cancel.Location = new System.Drawing.Point(348, 322);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(123, 40);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddTeamToTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.comboBoxTeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.comboBoxTournamentName);
            this.Name = "AddTeamToTournament";
            this.Text = "AddTeamToTournament";
            this.Load += new System.EventHandler(this.AddTeamToTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTournamentName;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTeamName;
        private System.Windows.Forms.Button Cancel;
    }
}