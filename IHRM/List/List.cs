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

        private void btn_contract_Click(object sender, EventArgs e)
        {
            panel_home.Visible = false;
            panel_supervisour.Visible = false;
            panel_contract.Visible = true;
        }

        private void List_Load(object sender, EventArgs e)
        {
            //panel_home.Visible = true;
            //panel_supervisour.Visible = false;
            //panel_contract.Visible = false;
        }

        private void list_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_home.Visible = true;
            panel_supervisour.Visible = false;
            panel_contract.Visible = false;
        }

        private void btn_supervisour_Click(object sender, EventArgs e)
        {
            panel_home.Visible = false;
            panel_supervisour.Visible = true;
            panel_contract.Visible = false;
        }
    }
}
