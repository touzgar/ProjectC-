namespace ProjectC_
{
    partial class usercs
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
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.club = new System.Windows.Forms.Button();
            this.team = new System.Windows.Forms.Button();
            this.AchivementTeam = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Caoch = new System.Windows.Forms.Button();
            this.Session = new System.Windows.Forms.Button();
            this.Logiciel = new System.Windows.Forms.Button();
            this.Materiel = new System.Windows.Forms.Button();
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AdminTimer = new System.Windows.Forms.Timer(this.components);
            this.LogOut = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.button);
            this.SideBar.Controls.Add(this.user);
            this.SideBar.Controls.Add(this.club);
            this.SideBar.Controls.Add(this.team);
            this.SideBar.Controls.Add(this.AchivementTeam);
            this.SideBar.Controls.Add(this.Player);
            this.SideBar.Controls.Add(this.button1);
            this.SideBar.Controls.Add(this.button2);
            this.SideBar.Controls.Add(this.button3);
            this.SideBar.Controls.Add(this.Caoch);
            this.SideBar.Controls.Add(this.Session);
            this.SideBar.Controls.Add(this.Logiciel);
            this.SideBar.Controls.Add(this.Materiel);
            this.SideBar.Controls.Add(this.LogOut);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.MaximumSize = new System.Drawing.Size(245, 900);
            this.SideBar.MinimumSize = new System.Drawing.Size(70, 530);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(245, 833);
            this.SideBar.TabIndex = 0;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(49, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Snow;
            this.MenuButton.Image = global::ProjectC_.Properties.Resources.menu_bar;
            this.MenuButton.Location = new System.Drawing.Point(3, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(40, 33);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // button
            // 
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(3, 63);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(242, 50);
            this.button.TabIndex = 1;
            this.button.Text = "Home";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(3, 119);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(242, 48);
            this.user.TabIndex = 2;
            this.user.Text = "user";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // club
            // 
            this.club.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.club.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.club.ForeColor = System.Drawing.Color.White;
            this.club.Location = new System.Drawing.Point(3, 173);
            this.club.Name = "club";
            this.club.Size = new System.Drawing.Size(242, 50);
            this.club.TabIndex = 3;
            this.club.Text = "club";
            this.club.UseVisualStyleBackColor = true;
            this.club.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // team
            // 
            this.team.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.team.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.team.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team.ForeColor = System.Drawing.Color.White;
            this.team.Location = new System.Drawing.Point(3, 229);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(242, 50);
            this.team.TabIndex = 2;
            this.team.Text = "Team";
            this.team.UseVisualStyleBackColor = false;
            this.team.Click += new System.EventHandler(this.team_Click);
            // 
            // AchivementTeam
            // 
            this.AchivementTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AchivementTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AchivementTeam.ForeColor = System.Drawing.Color.White;
            this.AchivementTeam.Location = new System.Drawing.Point(3, 285);
            this.AchivementTeam.Name = "AchivementTeam";
            this.AchivementTeam.Size = new System.Drawing.Size(242, 50);
            this.AchivementTeam.TabIndex = 1;
            this.AchivementTeam.Text = "AchivementTeam";
            this.AchivementTeam.UseVisualStyleBackColor = true;
            this.AchivementTeam.Click += new System.EventHandler(this.AchivementTeam_Click);
            // 
            // Player
            // 
            this.Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.ForeColor = System.Drawing.Color.White;
            this.Player.Location = new System.Drawing.Point(3, 341);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(242, 50);
            this.Player.TabIndex = 1;
            this.Player.Text = "Player";
            this.Player.UseVisualStyleBackColor = true;
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "AchivementPlayer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "ContractPlayer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "Tournament";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // Caoch
            // 
            this.Caoch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Caoch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caoch.ForeColor = System.Drawing.Color.White;
            this.Caoch.Location = new System.Drawing.Point(3, 565);
            this.Caoch.Name = "Caoch";
            this.Caoch.Size = new System.Drawing.Size(242, 50);
            this.Caoch.TabIndex = 1;
            this.Caoch.Text = "Coach";
            this.Caoch.UseVisualStyleBackColor = true;
            this.Caoch.Click += new System.EventHandler(this.Caoch_Click);
            // 
            // Session
            // 
            this.Session.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Session.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Session.ForeColor = System.Drawing.Color.White;
            this.Session.Location = new System.Drawing.Point(3, 621);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(242, 50);
            this.Session.TabIndex = 2;
            this.Session.Text = "Session";
            this.Session.UseVisualStyleBackColor = true;
            this.Session.Click += new System.EventHandler(this.Session_Click);
            // 
            // Logiciel
            // 
            this.Logiciel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logiciel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logiciel.ForeColor = System.Drawing.Color.White;
            this.Logiciel.Location = new System.Drawing.Point(3, 677);
            this.Logiciel.Name = "Logiciel";
            this.Logiciel.Size = new System.Drawing.Size(242, 50);
            this.Logiciel.TabIndex = 1;
            this.Logiciel.Text = "Logiciel";
            this.Logiciel.UseVisualStyleBackColor = true;
            this.Logiciel.Click += new System.EventHandler(this.Logiciel_Click);
            // 
            // Materiel
            // 
            this.Materiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Materiel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Materiel.ForeColor = System.Drawing.Color.White;
            this.Materiel.Location = new System.Drawing.Point(3, 733);
            this.Materiel.Name = "Materiel";
            this.Materiel.Size = new System.Drawing.Size(242, 47);
            this.Materiel.TabIndex = 3;
            this.Materiel.Text = "Materiel";
            this.Materiel.UseVisualStyleBackColor = true;
            this.Materiel.Click += new System.EventHandler(this.Materiel_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            this.SideBarTimer.Tick += new System.EventHandler(this.SideBarTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminTimer
            // 
            this.AdminTimer.Interval = 10;
            this.AdminTimer.Tick += new System.EventHandler(this.AdminTimer_Tick_1);
            // 
            // LogOut
            // 
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.Location = new System.Drawing.Point(3, 786);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(242, 47);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // usercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1385, 833);
            this.Controls.Add(this.SideBar);
            this.Name = "usercs";
            this.Text = "usercs";
            this.Load += new System.EventHandler(this.usercs_Load);
            this.SideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button club;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer AdminTimer;
        private System.Windows.Forms.Button team;
        private System.Windows.Forms.Button AchivementTeam;
        private System.Windows.Forms.Button Player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Caoch;
        private System.Windows.Forms.Button Logiciel;
        private System.Windows.Forms.Button Session;
        private System.Windows.Forms.Button Materiel;
        private System.Windows.Forms.Button LogOut;
    }
}