using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficLight
{
    public partial class LightTraffic : Form
    {
        int interval = 1000;
        public LightTraffic()
        {
            InitializeComponent();
        }

        private void tmrLight_Tick(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Red)
            {
                this.BackColor = Color.Orange;
                interval = 1000;
            }
            else if(this.BackColor == Color.Orange)
            {
                this.BackColor = Color.Green;
                interval = 2000;
            }
            else
            {
                this.BackColor = Color.Red;
                interval = 1000;
            }
            tmrLight.Interval = interval;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrLight.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrLight.Stop();
            this.BackColor = Color.Red;
            interval = 1000;
            tmrLight.Interval = interval;
        }
    }
}
