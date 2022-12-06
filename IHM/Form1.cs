using ServicesContracts;
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

namespace IHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factory = new ChannelFactory<IMeteoService>("RecipeEP");
            var proxy = factory.CreateChannel();

            MessageBox.Show(proxy.GetTemperature("Toulouse").ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factory = new ChannelFactory<IMeteoService>("RecipeEP");
            var proxy = factory.CreateChannel();

            dataGridView1.DataSource = proxy.GetTemperatures();
        }
    }
}
