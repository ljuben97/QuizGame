using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private Igrach1 igrach1;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            igrach1.setOtkaz(true);
            this.Close();
        }

        public void Send(Igrach1 igrach1)
        {
            this.igrach1 = igrach1;
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            igrach1.setOtkaz(false);
            this.Close();
        }
    }
}
