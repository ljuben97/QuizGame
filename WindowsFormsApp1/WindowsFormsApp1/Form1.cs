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
        private Igrachi igrachi;
        private Igrach1 igrach1;
        private Label[] denari;

        private void nextQuestion()
        {
            if (igrach1.getCounter() == 15)
            {
                endGame(3);
            }
            else
            {
                changeColor(igrach1.getCounter());
                igrach1.nextQuestion();
                anw1.Text = igrach1.getAnswer1();
                btnQuestion.Text = igrach1.getQuestion();
                anws2.Text = igrach1.getAnswer2();
                answ3.Text = igrach1.getAnswer3();
                answ4.Text = igrach1.getAnswer4();
            }
        }

        private void changeColor(int i)
        {
            if (i > 0)
            {
                denari[i-1].ForeColor=Color.Yellow;
            }
            denari[i].ForeColor = Color.Red;
        }

        private void addPari()
        {
            denari = new Label[15];
            denari[0] = label1;
            denari[1] = label2;
            denari[2] = label3;
            denari[3] = label4;
            denari[4] = label5;
            denari[5] = label6;
            denari[6] = label7;
            denari[7] = label8;
            denari[8] = label9;
            denari[9] = label10;
            denari[10] = label11;
            denari[11] = label12;
            denari[12] = label13;
            denari[13] = label14;
            denari[14] = label15;
            for (int i = 0; i < 15; i++)
            {
                denari[i].BackColor = Color.Transparent;
                denari[i].ForeColor = Color.Yellow;
            }
        }

        public Form1()
        {
            InitializeComponent();
            addPari();
        }

        public void accept(Igrachi igrachi, String name)
        {
            this.igrachi = igrachi;
            igrach1 = new Igrach1(name);
            nextQuestion();
        }

        private void checkAnswer(int n)
        {
            if (igrach1.getAnswer() == n)
            {
                MessageBox.Show("Точен одговор!");
                nextQuestion();
            }
            else endGame(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkAnswer(1);
        }

        private void anws2_Click(object sender, EventArgs e)
        {
            checkAnswer(2);
        }

        private void answ3_Click(object sender, EventArgs e)
        {
            checkAnswer(3);
        }

        private void answ4_Click(object sender, EventArgs e)
        {
            checkAnswer(4);
        }

        private void endGame(int stat)
        {
            MessageBox.Show(igrach1.endGame(stat));
            igrachi.addIgrachMilioner(igrach1);
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Form3 form3=new Form3();
            form3.Send(igrach1);
            form3.ShowDialog();
            if (igrach1.getOtkaz()) endGame(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

public class Igrach1
{
    private List<List<String>> questionsLow;
    private List<List<String>> questionsMedium;
    private List<List<String>> questionsHigh;
    private List<String> question;
    private String question1;
    private String answer1;
    private String answer2;
    private String answer3;
    private String answer4;
    private String tochen;
    private Random random;
    private String name;
    private int i;
    private String dobivka;
    private String[] pari;
    private int count;
    private int answer;
    private int counter;
    private int poz;
    private int poeni;
    private bool otkaz;
    private String endText;
    private int grupa;

    public Igrach1(String name)
    {
        this.name = name;
        grupa = 15;
        initPari();
        counter = 0;
        questionsLow = new List<List<String>>();
        questionsMedium = new List<List<String>>();
        questionsHigh = new List<List<String>>();
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
                questionsHigh.Add(red);
                count = 0;
                red = new List<String>();
            }
        }
    }

    public String getName()
    {
        return name;
    }

    private void initPari()
    {
        pari = new String[16];
        pari[0] = "100";
        pari[1] = "200";
        pari[2] = "300";
        pari[3] = "500";
        pari[4] = "1.000";
        pari[5] = "2.000";
        pari[6] = "4.000";
        pari[7] = "8.000";
        pari[8] = "16.000";
        pari[9] = "32.000";
        pari[10] = "64.000";
        pari[11] = "125.000";
        pari[12] = "250.000";
        pari[13] = "500.000";
        pari[14] = "1.000.000";
        pari[15] = "0";
    }

    public void setOtkaz(bool otkaz)
    {
        this.otkaz = otkaz;
    }

    public bool getOtkaz()
    {
        return otkaz;
    }

    public int getCounter()
    {
        return counter;
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

    public int getDobivka()
    {
        List<Char> lista = new List<Char>();
        int i;
        for(i=0; i<dobivka.Length; i++)
        {
            if (dobivka.ElementAt(i) != '.') lista.Add(dobivka.ElementAt(i));
        }
        char[] valuta = lista.ToArray();
        String fin = new string(valuta);
        System.Diagnostics.Debug.WriteLine("Test");
        System.Diagnostics.Debug.WriteLine(fin);
        return Int32.Parse(fin);
    }

    public String endGame(int stat)
    {
        if (stat == 1)
        {
            if (counter > 1)
            {
                dobivka = pari[counter - 2];
            }
            else dobivka = "0";
            return "Се откажавте и играта заврши, освоивте " + dobivka + " денари!";
        }

        if (stat == 2)
        {
            tochen = question.ElementAt(answer);
            dobivka = pari[grupa];
            return "Неточен одговор одговорот што го баравме е " + tochen + "!\n"+ "Играта заврши, освоивте " + dobivka + " денари!";
        }

        if(stat == 3)
        {
            dobivka = "1.000.000";
            return "Честитки ги поминавте сите прашања! Играта заврши и вие станавте Милионер!";
        }
        return "Играта заврши, освоивте " + dobivka + " денари";
    }

    public void nextQuestion()
    {
        if (counter == 5) grupa = counter-1;
        if (counter == 10) grupa = counter-1;

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
        else
        {
            poz = random.Next(0, questionsHigh.Count);
            question = questionsHigh.ElementAt(poz);
            questionsHigh.RemoveAt(poz);
        }
        question1 = question.ElementAt(0);
        answer1 = question.ElementAt(1);
        answer2 = question.ElementAt(2);
        answer3 = question.ElementAt(3);
        answer4 = question.ElementAt(4);
        answer = Int32.Parse(question.ElementAt(5));
        counter++;
    }

}
