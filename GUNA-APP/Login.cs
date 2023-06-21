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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sportsLink = new Form1();
            sportsLink.Closed += (s, args) => this.Close();
            sportsLink.Show();
        }
    }
}
