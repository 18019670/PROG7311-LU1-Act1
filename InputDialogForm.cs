using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG_LU_1_Activity_1
{
    public partial class InputDialogForm : Form
    {
        public BtnOKPress btnOKPress;
        public InputDialogForm()
        {
            InitializeComponent();
        }

        public delegate void BtnOKPress(string input);

        private void BtnOK_Click(object sender, EventArgs e)
        {
            btnOKPress(txtLabel.Text);
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
