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

        private void login_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            list_contract.Visible = false;
            list_home.Visible = true;
        }

        private void btn_contract_Click(object sender, EventArgs e)
        {
            list_contract.Visible = true;
        }

        private void List_Load(object sender, EventArgs e)
        {
            list_home.Visible = true;
            list_contract.Visible = false;
        }
    }
}
