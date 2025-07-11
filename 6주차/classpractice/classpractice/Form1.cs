using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classpractice
{
    public partial class Form1 : Form
    {
        private string title = "";

        public int totalCount = 0;

        public string loginID = "";
        public string loginPW = "";

        public Form1()
        {
            InitializeComponent();

            Champion c = new Champion(); //생성자 생성

            c.name = "가붕";
            c.damage = 100;

            int result = c.attack();

            Garen G = new Garen();

            G.name = "abc";
            G.damage = 200;

            int result2 = G.attack();
            G.skillName = "붕붕이";
            G.faceImagePath = "https:/www.어쩌구저쩌구.com";



            Timo T = new Timo();

            T.name = "티모";
            T.damage = 50;
            T.skillName = "댄스";
            T.faceImagePath = "https:/www.동물사진저쩌구.com";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "클릭완료";

            /*
            Dictionary<string, string> d = new Dictionary<string, string>()
            {
                {"2020", "가렌" },{"2021", "티모" },{"2022", "리신" },{"2023", "피즈" }
            };

            d.Add("2024", "애쉬");

            label1.Text = d["2024"]; //딕션어리 기본적으로 맵(Map)으로 말함
            */

            loginID = textBox1.Text;
            loginPW = textBox2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "label1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            var result =  f.ShowDialog();
            if(result == DialogResult.OK)
            {
                loginPW = f.result;
                textBox2.Text = f.result;
            }
        }
    }

    public class Champion
    {
        public string name = "";
        public int damage = 0;
        public int speed = 0;

        public string faceImagePath = "";

        //생성자
        public Champion()
        {

        }
        
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public int attack()
        {
            return 1000;
        }

        public void move()
        {

        }

    }

    public class Garen : Champion
    {
        public string skillName = "";

        public Garen() 
        {

        }
    }

    public class Timo : Champion
    {
        public string skillName = "";

        public Timo()
        {

        }
    }

}
