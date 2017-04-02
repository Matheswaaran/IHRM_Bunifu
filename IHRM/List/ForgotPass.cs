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
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void forgotpass_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forgotpass_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
