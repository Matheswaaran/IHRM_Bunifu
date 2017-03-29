using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHRM.Data
{
    public partial class Add_Site : Form
    {
        public Add_Site()
        {
            InitializeComponent();
        }

        private void add_Site_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
