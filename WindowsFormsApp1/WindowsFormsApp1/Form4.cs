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
    public partial class Form4 : Form
    {
        private Igrachi igrachi;

        public Form4()
        {
            InitializeComponent();
            igrachi=new Igrachi();
        }

        private void btnQuizTime_Click(object sender, EventArgs e)
        {
            if (txtIme.Text.Length == 0)
            {
                MessageBox.Show("Внесете име во полето!");
                return;
            }

            Form2 form2 = new Form2();
            form2.accept(igrachi, txtIme.Text);
            form2.Show();
        }

        private void btnQuizMillioner_Click(object sender, EventArgs e)
        {
            if (txtIme.Text.Length == 0)
            {
                MessageBox.Show("Внесете име во полето!");
                return;
            }
            Form1 form1=new Form1();
            form1.accept(igrachi, txtIme.Text);
            form1.Show();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.send(igrachi);
            form5.Show();
        }
    }
}

public class Igrachi
{
    private List<Igrach> igrachiVreme;
    private List<Igrach1> igrachiMilioner;

    public Igrachi()
    {
        igrachiVreme = new List<Igrach>();
        igrachiMilioner=new List<Igrach1>();
    }

    public List<Igrach> getIgrachVreme()
    {
        return igrachiVreme;
    }

    public List<Igrach1> getIgrachMilioner()
    {
        return igrachiMilioner;
    }

    public void addIgrachVreme(Igrach igrach)
    {
        igrachiVreme.Add(igrach);
    }

    public void addIgrachMilioner(Igrach1 igrach)
    {
        igrachiMilioner.Add(igrach);
    }
}
