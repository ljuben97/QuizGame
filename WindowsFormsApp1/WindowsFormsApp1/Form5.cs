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
    public partial class Form5 : Form
    {
        private Igrachi igrachi;

        public Form5()
        {
            InitializeComponent();
        }

        public void send(Igrachi igrachi1)
        {
            this.igrachi = igrachi1;
            List<Igrach> listaVreme = igrachi.getIgrachVreme().OrderByDescending(p => p.getPoeni()).ToList();
            List<Igrach1> listaMilioner = igrachi.getIgrachMilioner().OrderByDescending(p => p.getDobivka()).ToList();
            foreach (Igrach igrach in listaVreme) listBox1.Items.Add(igrach.getName() + " - " + igrach.getPoeni() + " поени");
            foreach (Igrach1 igrach in listaMilioner) listBox2.Items.Add(igrach.getName() + " - " + igrach.getDobivka() + " денари");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
