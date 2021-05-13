using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compile
{
    public partial class FormSecantResult : Form
    {
        static public List<(int n, double x0, double x1, double fx0, double fx1, double x2, double err)> secantResult;

        public FormSecantResult(List<(int n, double x0, double x1, double fx0, double fx1, double x2, double err)> result)
        {
            InitializeComponent();
            secantResult = result;
        }

        private void FormSecantResult_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < secantResult.Count; i++)
            {
                var (n, x0, x1, fx0, fx1, x2, err) = secantResult[i];
                dgvResult.Rows.Add(n, x0, x1, fx0, fx1, x2, err);
            }
        }
    }
}
