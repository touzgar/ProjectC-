using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectC_
{
    public partial class usercs : Form
    {
        bool sideBarExpand;

        private string userRole; // Store the role of the logged-in user

        // Constructor that receives the role of the user
        public usercs(string role)
        {
            InitializeComponent();
            userRole = role; // Set the user role
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usercs_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (userRole == "MANAGER")
            {
                MessageBox.Show("Managers are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }

            // If the user is not an MANAGER, open the utilisateur form
            utilisateur utilisateurForm = new utilisateur();
            utilisateurForm.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    SideBarTimer.Stop();
                }

            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void AdminTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void AdminTimer_Tick_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (userRole == "MANAGER")
            {
                MessageBox.Show("Managers are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            Club clubForm = new Club();
            clubForm.Show();
        }

        private void team_Click(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            Team teamForm = new Team();
            teamForm.Show();
        }

        private void AchivementTeam_Click(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            AchivementTeam achivementTeamForm = new AchivementTeam();
            achivementTeamForm.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            Player PlayerForm = new Player();
            PlayerForm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            AchivementPlayer AchivementPlayerForm = new AchivementPlayer();
            AchivementPlayerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            ContractPlayer ContractPlayerForm = new ContractPlayer();
            ContractPlayerForm.Show();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            Tournament TournamentForm = new Tournament();
            TournamentForm.Show();
        }

        private void Caoch_Click(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            Coach CoachForm = new Coach();
            CoachForm.Show();
        }

        private void Session_Click(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            Session2 SessionForm = new Session2();
            SessionForm.Show();
        }

        private void Logiciel_Click(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            Logiciel LogicielForm = new Logiciel();
            LogicielForm.Show();
        }

        private void Materiel_Click(object sender, EventArgs e)
        {
            if (userRole == "ADMIN")
            {
                MessageBox.Show("Admins are not allowed to access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent the user from accessing the form
            }
            Materiel MaterielForm = new Materiel();
            MaterielForm.Show();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 Form1Form = new Form1();
            Form1Form.Show();
        }
    }
}
