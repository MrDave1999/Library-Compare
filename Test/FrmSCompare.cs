using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sCompare;

namespace Test
{
    public partial class FrmSCompare : Form
    {
        public FrmSCompare()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            SCompare txtStr = new SCompare(txtStr1.Text);
            if (txtStr == txtStr2.Text)
                MessageBox.Show("El string1 es igual a string2!");
            else
                MessageBox.Show("El string1 no es igual a string2!");
        }
    }
}
