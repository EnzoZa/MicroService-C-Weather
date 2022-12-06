using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost host = new ServiceHost(typeof(MeteoService));

        private void Form1_Load(object sender, EventArgs e)
        {
            host.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            host?.Close();
        }
    }
}
