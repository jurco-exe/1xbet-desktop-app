using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNA_APP
{
    public partial class Live : Form
    {
        public Live()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnSports_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sportsLink = new Sports();
            sportsLink.Closed += (s, args) => this.Close();
            sportsLink.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var liveLink = new Live();
            liveLink.Closed += (s, args) => this.Close();
            liveLink.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var casinoLink = new Casino();
            casinoLink.Closed += (s, args) => this.Close();
            casinoLink.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var promotionsLink = new Promotions();
            promotionsLink.Closed += (s, args) => this.Close();
            promotionsLink.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var contactLink = new Contact();
            contactLink.Closed += (s, args) => this.Close();
            contactLink.Show();
        }
    }
}
