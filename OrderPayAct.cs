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
        private AutoSizeFormClass asc = new AutoSizeFormClass();
        public OrderPayAct()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);
        }

        private void OrderPayAct_Resize(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            loginAct = new LoginAct();
            this.Hide();
            loginAct.Show();
        }
    }
}
