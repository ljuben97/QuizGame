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
    public partial class Form2 : Form
    {
        private Igrach igrach;
        private String name;
        private Igrachi igrachi;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void accept(Igrachi igrachi, String name)
        {
            this.igrachi = igrachi;
            this.name = name;
            igrach = new Igrach(name);
            nextQuestion();
        }

        private void nextQuestion()
        {
            igrach.nextQuestion();
            btnQuestion.Text = igrach.getQuestion();
            anw1.Text = igrach.getAnswer1();
            anws2.Text = igrach.getAnswer2();
            answ3.Text = igrach.getAnswer3();
            answ4.Text = igrach.getAnswer4();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            timer1.Stop();
            anw1.Enabled = false;
            answ3.Enabled = false;
            answ4.Enabled = false;
            anws2.Enabled = false;
            igrachi.addIgrachVreme(igrach);
            btnClose.Enabled = true;
        }

        private bool evaluateifEmpty()
        {
            if (igrach.getEmpty())
            {
                lblKraj.Text = igrach.getEndText();
                return true;
            }
            else return false;
        }

        private void evaluate()
        {
            if (evaluateifEmpty()) endGame();
            else nextQuestion();
        }

        private void click(int n)
        {
            if (igrach.getAnswer() == n)
            {
                igrach.increasePoints();
                lblPoeni.Text = igrach.getPoeni().ToString();
            }
            evaluate();
        }

        private void anw1_Click(object sender, EventArgs e)
        {
            click(1);
        }

        private void anws2_Click(object sender, EventArgs e)
        {
            click(2);
        }

        private void answ3_Click(object sender, EventArgs e)
        {
            click(3);
        }

        private void answ4_Click(object sender, EventArgs e)
        {
            click(4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                lblKraj.Text = "Играта заврши времето ви истече";
                endGame();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

public class Igrach
{
    private List<List<String>> questionsLow;
    private List<List<String>> questionsMedium;
    private List<List<String>> questionHigh;
    private List<String> question;
    private String question1;
    private String answer1;
    private String answer2;
    private String answer3;
    private String answer4;
    private Random random;
    private int i;
    private int count;
    private int answer;
    private int counter;
    private int vkupno;
    private int grupa;
    private int poz;
    private int poeni;
    private bool empty;
    private String endText;
    private String name;

    public Igrach(String name)
    {
        this.name = name;
        empty = false;
        endText = "Играта заврши ги поминавте сите прашања!";
        vkupno = 0;
        questionsLow = new List<List<String>>();
        questionsMedium = new List<List<String>>();
        questionHigh = new List<List<String>>();
        random = new Random();
        count = 0;
        StreamReader sr = new StreamReader("prasanja.txt");
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

        for (i = 0; i < 120; i++)
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

        for (i = 0; i < 90; i++)
        {
            red.Add(sr.ReadLine());
            count++;
            if (count == 6)
            {
                questionHigh.Add(red);
                count = 0;
                red = new List<String>();
            }
        }
    }

    public String getName()
    {
        return name;
    }

    public int getPoeni()
    {
        return vkupno;
    }

    public String getQuestion()
    {
        return question1;
    }

    public String getAnswer1()
    {
        return answer1;
    }

    public String getAnswer2()
    {
        return answer2;
    }

    public String getAnswer3()
    {
        return answer3;
    }

    public String getAnswer4()
    {
        return answer4;
    }

    public String getEndText()
    {
        return endText;
    }

    public int getAnswer()
    {
        return answer;
    }

    public bool getEmpty()
    {
        return empty;
    }

    public void nextQuestion()
    {
        grupa = random.Next(1, 4);
        if (grupa==3 && questionHigh.Count == 0) grupa = 2;
        if (grupa==2 && questionsMedium.Count == 0) grupa = 1;
        if (questionsLow.Count == 0 && questionsMedium.Count == 0 && questionHigh.Count==0)
        {
            empty = true;
        }
        if (grupa == 1)
        {
            poz = random.Next(0, questionsLow.Count);
            question = questionsLow.ElementAt(poz);
            questionsLow.RemoveAt(poz);
            poeni = 1;
        }
        else if (grupa == 2)
        {
            poz = random.Next(0, questionsMedium.Count);
            question = questionsMedium.ElementAt(poz);
            questionsMedium.RemoveAt(poz);
            poeni = 3;
        }
        else if(grupa==3)
        {
            poz = random.Next(0, questionHigh.Count);
            question = questionHigh.ElementAt(poz);
            questionHigh.RemoveAt(poz);
            poeni = 5;
        }
        question1 = question.ElementAt(0);
        answer1 = question.ElementAt(1);
        answer2 = question.ElementAt(2);
        answer3 = question.ElementAt(3);
        answer4 = question.ElementAt(4);
        answer = Int32.Parse(question.ElementAt(5));
    }

    public void increasePoints()
    {
        vkupno += poeni;
    }
}
