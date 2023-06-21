using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace GUNA_APP
{
    public partial class Form1 : Form
    {

        List<Panel> listPanel = new List<Panel>();
        int index;

        public Form1()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
        }

        // Sports BTN:
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sportsLink = new Form1();
            sportsLink.Closed += (s, args) => this.Close();
            sportsLink.Show();

        }

        // Live BTN:
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var liveLink = new Live();
            liveLink.Closed += (s, args) => this.Close();
            liveLink.Show();
        }

        // Casino BTN:
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var casinoLink = new Casino();
            casinoLink.Closed += (s, args) => this.Close();
            casinoLink.Show();
        }

        // Promotions BTN:
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var promotionsLink = new Promotions();
            promotionsLink.Closed += (s, args) => this.Close();
            promotionsLink.Show();
        }

        // Contact BTN:
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var contactLink = new Contact();
            contactLink.Closed += (s, args) => this.Close();
            contactLink.Show();
        }

        // FORM LOAD:
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var liveLink = new Live();
            liveLink.Closed += (s, args) => this.Close();
            liveLink.Show();
        }



        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sportsLink = new Form1();
            sportsLink.Closed += (s, args) => this.Close();
            sportsLink.Show();
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var loginLink = new Login();
            loginLink.Closed += (s, args) => this.Close();
            loginLink.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var registerLink = new Register();
            registerLink.Closed += (s, args) => this.Close();
            registerLink.Show();
        }
    }
}
