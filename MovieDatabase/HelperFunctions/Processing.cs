using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace MovieDatabase.HelperFunctions
{
    public partial class ProcessingForm : Form
    {
        public System.Timers.Timer timer = new System.Timers.Timer();
        private int count = 0;

        private void processTimer_Tick(object sender, EventArgs e)
        {
            if (count == 4)
            {
                count = 0;
            }
            if (count == 0)
            {
                if (this.processLabel.InvokeRequired)
                {
                    this.processLabel.BeginInvoke((MethodInvoker)delegate() { this.processLabel.Text = "Processing"; ;});
                }
                count++;
            }
            else if (count == 1)
            {
                if (this.processLabel.InvokeRequired)
                {
                    this.processLabel.BeginInvoke((MethodInvoker)delegate() { this.processLabel.Text = "Processing."; ;});
                }
                count++;
            }
            else if (count == 2)
            {
                if (this.processLabel.InvokeRequired)
                {
                    this.processLabel.BeginInvoke((MethodInvoker)delegate() { this.processLabel.Text = "Processing.."; ;});
                }
                count++;
            }
            else if (count == 3)
            {
                if (this.processLabel.InvokeRequired)
                {
                    this.processLabel.BeginInvoke((MethodInvoker)delegate() { this.processLabel.Text = "Processing..."; ;});
                }
                count++;
            }
        }

        public ProcessingForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(processTimer_Tick);
            timer.Enabled = true;
            timer.Start();
        }
    }
}
