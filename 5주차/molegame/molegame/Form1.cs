using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace molegame
{
    public partial class Form1 : Form

    {

        //점수를 담을 변수

        private int mScore = 0;



        //두더지 클래스 배열

        private Mole[] mMoleArray = null;



        public Form1()

        {

            InitializeComponent();



            //이 프로젝트의 생성자에서 두더지 9개를 만들고 초기화해준다.

            mMoleArray = new Mole[9];

            mMoleArray[0] = new Mole(pictureBox1);

            mMoleArray[1] = new Mole(pictureBox2);

            mMoleArray[2] = new Mole(pictureBox3);

            mMoleArray[3] = new Mole(pictureBox4);

            mMoleArray[4] = new Mole(pictureBox5);

            mMoleArray[5] = new Mole(pictureBox6);

            mMoleArray[6] = new Mole(pictureBox7);

            mMoleArray[7] = new Mole(pictureBox8);

            mMoleArray[8] = new Mole(pictureBox9);

            label2.Text = mScore + "점";
            label4.Text = "";

        }



        private void pictureBox1_Click(object sender, EventArgs e)

        {

            clickMole(0);

        }



        private void pictureBox2_Click(object sender, EventArgs e)

        {

            clickMole(1);

        }



        private void pictureBox3_Click(object sender, EventArgs e)

        {

            clickMole(2);

        }



        private void pictureBox4_Click(object sender, EventArgs e)

        {

            clickMole(3);

        }



        private void pictureBox5_Click(object sender, EventArgs e)

        {

            clickMole(4);

        }



        private void pictureBox6_Click(object sender, EventArgs e)

        {

            clickMole(5);

        }



        private void pictureBox7_Click(object sender, EventArgs e)

        {

            clickMole(6);

        }



        private void pictureBox8_Click(object sender, EventArgs e)

        {

            clickMole(7);

        }



        private void pictureBox9_Click(object sender, EventArgs e)

        {

            clickMole(8);

        }



        private void clickMole(int position)

        {

            bool isAttack = mMoleArray[position].attack();

            if (isAttack)

            {
                mScore += 1;
                label2.Text = mScore + "점";
            }

        }



        private void button1_Click(object sender, EventArgs e)

        {

            //시작버튼을 누르면 시작버튼은 사라지고 종료버튼만 보인다.

            button1.Visible = false;

            button2.Visible = true;



            timer1.Start();

        }



        private void button2_Click(object sender, EventArgs e)

        {

            //종료버튼을 누르면 종료버튼은 사라지고 시작버튼만 보인다.

            button1.Visible = true;

            button2.Visible = false;



            timer1.Stop();



            //종료되는 순간에 모든 두더지의 상태 초기화

            for (int i = 0; i < 9; i++)

            {

                mMoleArray[i].clear();

            }

            label2.Text = "";

            label4.Text = mScore + "점";

            mScore = 0;

        }





        //이 함수는 시작버튼을 누르면 타이머가 실행될때 자동으로 실행

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)

            {

                mMoleArray[i].move();

            }
        }
    }





    public class Mole

    {

        private int mIndex = 0;

        private PictureBox mPictureBox = null;



        public Mole(PictureBox pictureBox)

        {

            mPictureBox = pictureBox;

        }



        public void updateImage()

        {

            //예외처리

            if (mPictureBox == null)

            {

                mIndex = 0;

                return;

            }





            //0:



            if (mIndex >= 0 && mIndex < 3)

            {

                //0,1,2: 완전히 들어감

                mPictureBox.Image = Properties.Resources.mole0;

            }

            else if (mIndex == 3)

            {

                //3: 빼꼼

                mPictureBox.Image = Properties.Resources.mole1;

            }

            else if (mIndex == 4)

            {

                //4: 반쯤 나옴

                mPictureBox.Image = Properties.Resources.mole2;

            }

            else if (mIndex == 5)

            {

                //5: 완전히 나옴

                mPictureBox.Image = Properties.Resources.mole3;

            }

            else if (mIndex == 6)

            {

                //6: 반쯤 나옴

                mPictureBox.Image = Properties.Resources.mole2;

            }

            else if (mIndex == 7)

            {

                //7: 빼꼼

                mPictureBox.Image = Properties.Resources.mole1;

            }

            else if (mIndex == 8)

            {

                //완전히 들어감

                mPictureBox.Image = Properties.Resources.mole0;

            }

            else

            {

                //조건에 없는건 두더지가 잡히는 액션

                mPictureBox.Image = Properties.Resources.MOLE4;

            }

        }



        public void move()

        {



            if (mIndex >= 0 && mIndex < 3)

            {

                //0,1,2가 완전 들어간 상태이므로, 이때 랜덤함수를 써서 3이 될 가능성을 준다.

                //3이면 빼꼼 나오기 시작하면서 +1씩 증가하기 시작

                Random random = new Random(Guid.NewGuid().GetHashCode());

                mIndex = random.Next(0, 4);

            }

            else

            {

                //이미 출력중일 경우에는 +1씩 증가시켜서 다음그림으로 변경한다.

                mIndex++;

            }



            if (mIndex > 8)

            {

                //8보다 큰 경우의 수에서는 0으로 바꿔버린다.

                mIndex = 0;

            }

            updateImage();

        }



        public bool attack()

        {

            if (mIndex < 3 || mIndex > 7)

            {

                //3,4,5,6,7 이 아니면 때려도 무효

                return false;

            }



            //맞으면 3턴은 맞은이미지로 바뀜

            mIndex = -3;

            updateImage();



            return true;

        }



        public void clear()

        {

            mIndex = 0;

            updateImage();

            

        }

    }
}
