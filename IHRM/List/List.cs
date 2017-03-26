using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHRM.List
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void login_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void list_navigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel_contract.Visible = false;
            panel_home.Visible = true;
        }

        private void btn_contract_Click(object sender, EventArgs e)
        {
            panel_contract.Visible = true;
        }

        private void List_Load(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            panel_contract.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {

        }

        private void panel_empVerification_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_username_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void list_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
