using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoMall
{
    public partial class OrderPayAct : Form
    {
        private LoginAct loginAct;
        public OrderPayAct()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loginAct = new LoginAct();
            this.Hide();
            loginAct.Show();
        }
    }
}
