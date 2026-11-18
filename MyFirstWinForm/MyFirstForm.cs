using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class MyFirstForm : Form
    {
        int interval = 1000;
        public bool flag = false;

        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void MyFirstForm_Load(object sender, EventArgs e)
        {
            lblTime.Visible = true;
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
                btnClickMe.BackColor = Color.FromArgb(74, 119, 122);
                btnClickMe.ForeColor = Color.White;
                flag = false;
            }
            else
            {
                this.BackColor = Color.FromArgb(240, 243, 246);
                this.ForeColor = Color.FromArgb(32, 33, 36);
                btnClickMe.BackColor = Color.FromArgb(0, 122, 204);
                btnClickMe.ForeColor = Color.White;
                flag = true;
            }
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You Entered :" + txtName.Text);
        }

        private void tmrMyTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblTime.Visible = true;
            tmrMyTimer.Interval = interval;
            tmrMyTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrMyTimer.Stop();
        }
    }
}