using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public int n = 0;
        private float f = 0.1f;
        public char c = 'A';
        private string s = "hello";

        public Form1()
        {
            InitializeComponent();

            //생성자란 클래스를 생성할때 기본으로 자동 실행되는 함수
            //생성자는 리턴타입이 없는 함수이다.
            //생성자는 클래스명이랑 똑같아야만 한다. 즉 함수명이 클래스명이랑 똑같다
            TestClass t = new TestClass();

            t.n = 1;
            t.c = 'B';
            //t.f와 t.s는 private라서 직접 접근이 불가능하다.
            t.setFandS(0.2f, "world");

            //이후 t클래스 안에 변수 값은?
            //t.n = 1; , t.c = 'B', t.f = 0.2f;, t.s = "world";

            TestClass tc = new TestClass(112);
            //tc.n 의 값은 112
            //왜냐하면 new 뒤에 숫자 인자값을 넣는 생성자로 생성됐기 때문이다.

            TestClass tc2 = new TestClass('Z', "abcd");
            //tc2.n의 값은 1234
            //tc2.c = Z tc2.s = abcd
            //왜냐하면 new 뒤에 문자와 문자열을 넣는 생성자로 생성했기 때문이다.

            //변수는 총 3개이다 t. tc .tc2
            //클래스는 그저 자료형에 불과하다

            ChildClass c = new ChildClass();


            var v1 = 2;
            var v2 = 'C';
            var v3 = 0.5f;
            var v4 = "good";
            //var는 변수의 자료형을 자동으로 알아서 저장한다.
            //오직 함수 안에서만 쓰인다. (지금은 Form1 생성자 함수 안에서 사용중)

            //단점은 자동으로 알아서 처리하기 때문에 메모리가 더 많이 든다.
            //에러가 났을때, 명시적으로 자룧ㅇ을 선언한것보다 디버깅이 어려워진다.

            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            array[0] = 3;
            array[1] = 5;
            //이 배열에 결과 3, 5, 3, 4, 5

            for(int i = 0; i < 5; i++) 
            {
                array[i] = 3;
            }
            //이 배열의 결과값은 3, 3, 3, 3, 3

            for (int i = 0; i < 5; i++)
            {
                array[i] = i%2; //%는 뒤의 수로 나눈 나머지 값
            }
            //이 배열의 결과값은 0, 1, 0, 1, 0

            List<string> list = new List<string>();
            list.Add("사과");
            list.Add("귤");
            list.Add("포도");
            list.Add("딸기");
            list.Add("수박");

            int listCount = list.Count();
            //listCount의 결과값은 5
            
            for(int i = 0; i<listCount; i++)
            {
                string row = list[i];
                if("포도".Equals(row)) //row.Equals("포도") 이것과 같다.
                {
                    list[i] = "샤인머스켓";
                }
            }
            //list[2]의 결과값은 "샤인머스켓"


            //딕션어리는 키와 값으로 이루어져있음 키를 통해 값을 출력 찾아올수 있다.
            //키는 중복이 되면안됨
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("20250001", "홍길동");
            d.Add("20250002", "짱구");
            d.Add("20250003", "맹구");
            d.Add("20250004", "김강찬");

            string person = d["20250003"];
            //person의 결과값은? 맹구

            d["20250001"] = "이순신";
            //d["20250001"]의 값은 이순신
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timo t = new Timo();

            label1.Text = "버튼1 클릭";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //버튼2를 클릭하면 팝업창을 띄운다.
            MessageBox.Show("버튼2 클릭");

            Form2 f = new Form2();

            var result = f.ShowDialog();
            if(result == DialogResult.OK)
            {
                textBox2.Text = f.result;
            }

        }

    }



    public class Champion
    {
        protected string name = "";
        protected int damage = 0;
        protected int speed = 0;

        public Champion()
        {

        }

        public void attack()
        {

        }

        public void move()
        {

        }
    }

    public class Garen : Champion
    {
        public Garen()
        {
            this.name = "가렌";
            this.damage = 200;
            this.speed = 5;
        }
    }

    public class Timo : Champion
    {
        public Timo()
        {
            this.name = "티모";
            this.damage = 100;
            this.speed = 7;
        }
    }

    public class TestClass 
    {
        public int n = 0;
        private float f = 0.1f;
        public char c = 'A';
        protected string s = "hello";

        //private var = 0;
        //var는 함수 안에서만 사용가능

        public void setFandS(float f, string s)
        {
            this.f = f;
            this.s = s;

        }

        //생성자는 여러개가 될 수 있다.
        public TestClass()
        {

        }
        public TestClass(int n)
        {
            this.n = n;
            this.s = "ddd";

        }

        public TestClass(char c, string s)
        {
            this.c = c;
            this.s = s;
            this.n = 1234;
        }
    }

    public class ChildClass : TestClass 
    {
        public ChildClass()
        {
            //부모 클래스인 TestClass에서 s 는 protected 선언 되어있기 때문에
            //외부에서는 접근이 불가능하지만 자식클래스에서 가져올수 있음
            this.s = "tttt";//protected라서 가능
            this.n = 1;
            //this.f = 0.3f; //private라서 안됨
            this.c = 'a';
        }
    }


}
