namespace ProjectC_
{
    partial class AddCoachToTeam
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
            this.comboBoxTeamName = new System.Windows.Forms.ComboBox();
            this.teamName = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.CoachName = new System.Windows.Forms.Label();
            this.comboBoxCoachName = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTeamName
            // 
            this.comboBoxTeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeamName.FormattingEnabled = true;
            this.comboBoxTeamName.Location = new System.Drawing.Point(199, 137);
            this.comboBoxTeamName.Name = "comboBoxTeamName";
            this.comboBoxTeamName.Size = new System.Drawing.Size(231, 36);
            this.comboBoxTeamName.TabIndex = 0;
            this.comboBoxTeamName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeamName_SelectedIndexChanged);
            // 
            // teamName
            // 
            this.teamName.AutoSize = true;
            this.teamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamName.Location = new System.Drawing.Point(58, 140);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(109, 28);
            this.teamName.TabIndex = 1;
            this.teamName.Text = "TeamName";
            this.teamName.Click += new System.EventHandler(this.teamName_Click);
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
            this.Accept.Location = new System.Drawing.Point(123, 312);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(112, 44);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // CoachName
            // 
            this.CoachName.AutoSize = true;
            this.CoachName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachName.Location = new System.Drawing.Point(58, 239);
            this.CoachName.Name = "CoachName";
            this.CoachName.Size = new System.Drawing.Size(118, 28);
            this.CoachName.TabIndex = 3;
            this.CoachName.Text = "CoachName";
            this.CoachName.Click += new System.EventHandler(this.CoachName_Click);
            // 
            // comboBoxCoachName
            // 
            this.comboBoxCoachName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCoachName.FormattingEnabled = true;
            this.comboBoxCoachName.Location = new System.Drawing.Point(199, 236);
            this.comboBoxCoachName.Name = "comboBoxCoachName";
            this.comboBoxCoachName.Size = new System.Drawing.Size(231, 36);
            this.comboBoxCoachName.TabIndex = 4;
            this.comboBoxCoachName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCoachName_SelectedIndexChanged);
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
            this.Cancel.Location = new System.Drawing.Point(273, 312);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 44);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddCoachToTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.comboBoxCoachName);
            this.Controls.Add(this.CoachName);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.comboBoxTeamName);
            this.Name = "AddCoachToTeam";
            this.Text = "AddCoachToTeam";
            this.Load += new System.EventHandler(this.AddCoachToTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeamName;
        private System.Windows.Forms.Label teamName;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label CoachName;
        private System.Windows.Forms.ComboBox comboBoxCoachName;
        private System.Windows.Forms.Button Cancel;
    }
}