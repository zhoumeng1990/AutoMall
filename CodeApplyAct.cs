using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoMall
{
    public partial class CodeApplyAct : Form
    {

        private LoginAct loginAct;
        public CodeApplyAct()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            SetBoxValue(nodeIndexBox,new ArrayList(){"15","30","50","100"});
            SetBoxValue(userTimeBox, new ArrayList() { "31", "61", "92", "184","365" });
            SetBoxValue(userIndexBox, new ArrayList() { "10", "20", "50", "100" });
        }

        public void SetBoxValue(ComboBox box,ArrayList arrayList)
        {
            foreach(string item in arrayList)
            {
                box.Items.Add(item);
            }
            box.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            loginAct = new LoginAct();
            this.Hide();
            loginAct.Show();
        }
    }
}
