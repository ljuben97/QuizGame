using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<List<String>> questionsLow;
        private List<List<String>> questionsMedium;
        private List<String> question;
        private Random random;
        private int i;
        private int count;
        private int answer;
        private int counter;

        private void nextQuestion()
        {
            int poz;
            if (counter < 5)
            {
                poz = random.Next(0, questionsLow.Count);
                question = questionsLow.ElementAt(poz);
                questionsLow.RemoveAt(poz);
            }
            else if (counter < 10)
            {
                poz = random.Next(0, questionsMedium.Count);
                question = questionsMedium.ElementAt(poz);
                questionsMedium.RemoveAt(poz);
            }
            btnQuestion.Text = question.ElementAt(0);
            anw1.Text = question.ElementAt(1);
            anws2.Text = question.ElementAt(2);
            answ3.Text = question.ElementAt(3);
            answ4.Text = question.ElementAt(4);
            answer=Int32.Parse(question.ElementAt(5));
            counter++;
        }

        private void init()
        {
            count = 0;
            StreamReader sr=new StreamReader("prasanja.txt");
            List<String> red = new List<String>();
            for (i = 0; i < 120; i++)
            {
                red.Add(sr.ReadLine());
                count++;
                if (count == 6)
                {
                    questionsLow.Add(red);
                    count = 0;
                    red = new List<String>();
                }
            }
           
            for (i = 0; i < 90; i++)
            {
                red.Add(sr.ReadLine());
                count++;
                if (count == 6)
                {
                    questionsMedium.Add(red);
                    count = 0;
                    red = new List<String>();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            questionsLow = new List<List<String>>();
            questionsMedium = new List<List<String>>();
            counter = 0;
            random = new Random();
            init();
            nextQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answer == 1) MessageBox.Show("Tochen odgovor");
            else MessageBox.Show("Netochen odgovor");
            nextQuestion();
        }

        private void anws2_Click(object sender, EventArgs e)
        {
            if (answer == 2) MessageBox.Show("Tochen odgovor");
            else MessageBox.Show("Netochen odgovor");
            nextQuestion();
        }

        private void answ3_Click(object sender, EventArgs e)
        {
            if (answer == 3) MessageBox.Show("Tochen odgovor");
            else MessageBox.Show("Netochen odgovor");
            nextQuestion();
        }

        private void answ4_Click(object sender, EventArgs e)
        {
            if (answer == 4) MessageBox.Show("Tochen odgovor");
            else MessageBox.Show("Netochen odgovor");
            nextQuestion();
        }
    }
}
