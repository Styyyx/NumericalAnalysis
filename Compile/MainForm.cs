using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;

namespace Compile
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        //private NumAnal_TaylorSeries.TaylorSeries TaylorSeries;

        //private bool IsActivatedWithShow = true;

        //private void FormMain_Load(object sender, EventArgs e)
        //{
        //    TaylorSeries = new TaylorSeries();
        //}

        private void btnTaylor_Click(object sender, EventArgs e)
        {
            //if (IsActivatedWithShow)
            //{
            //    TaylorSeries.Show();
            //}
            //else
            //{
            //    Process.Start("TaylorSeries");
            //}
            new FormTaylor().Show();
            this.Hide();
        }

        private void btnSecant_Click(object sender, EventArgs e)
        {
            new FormSecant().Show();
            this.Hide();
        }

        private void btnIntegration_Click(object sender, EventArgs e)
        {
            new FormIntegration().Show();
            this.Hide();
        }
    }
}
