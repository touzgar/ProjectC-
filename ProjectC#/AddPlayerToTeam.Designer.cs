namespace ProjectC_
{
    partial class AddPlayerToTeam
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
            this.comboBoxPlayerName = new System.Windows.Forms.ComboBox();
            this.teamName = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.playerName = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTeamName
            // 
            this.comboBoxTeamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTeamName.FormattingEnabled = true;
            this.comboBoxTeamName.Location = new System.Drawing.Point(269, 113);
            this.comboBoxTeamName.Name = "comboBoxTeamName";
            this.comboBoxTeamName.Size = new System.Drawing.Size(227, 36);
            this.comboBoxTeamName.TabIndex = 0;
            this.comboBoxTeamName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeamName_SelectedIndexChanged);
            // 
            // comboBoxPlayerName
            // 
            this.comboBoxPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlayerName.FormattingEnabled = true;
            this.comboBoxPlayerName.Location = new System.Drawing.Point(269, 243);
            this.comboBoxPlayerName.Name = "comboBoxPlayerName";
            this.comboBoxPlayerName.Size = new System.Drawing.Size(227, 36);
            this.comboBoxPlayerName.TabIndex = 1;
            this.comboBoxPlayerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayerName_SelectedIndexChanged);
            // 
            // teamName
            // 
            this.teamName.AutoSize = true;
            this.teamName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamName.Location = new System.Drawing.Point(132, 116);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(109, 28);
            this.teamName.TabIndex = 2;
            this.teamName.Text = "TeamName";
            this.teamName.Click += new System.EventHandler(this.teamName_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.Highlight;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(177, 339);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(122, 42);
            this.add.TabIndex = 3;
            this.add.Text = "Save";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(132, 243);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(117, 28);
            this.playerName.TabIndex = 4;
            this.playerName.Text = "PlayerName";
            this.playerName.Click += new System.EventHandler(this.playerName_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(355, 339);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(122, 42);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddPlayerToTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.add);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.comboBoxPlayerName);
            this.Controls.Add(this.comboBoxTeamName);
            this.Name = "AddPlayerToTeam";
            this.Text = "AddPlayerToTeam";
            this.Load += new System.EventHandler(this.AddPlayerToTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeamName;
        private System.Windows.Forms.ComboBox comboBoxPlayerName;
        private System.Windows.Forms.Label teamName;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Button cancel;
    }
}