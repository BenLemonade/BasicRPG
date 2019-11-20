using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicRPG
{
    public partial class BasicRPG : Form
    {
        public BasicRPG()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            LabelGold.Text = "123";
        }
    }
}
