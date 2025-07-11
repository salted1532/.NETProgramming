using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //클래스 생성
            champ cmp = new champ();
            cmp.Name = "me";
            cmp.age = 10;
            cmp.hp = 100;

            //변수 선언
            int i = 0;
            int number = 55;
            int number2 = 111;
            int[] array3 = { 1, 2, 3 };

            while (true)
            {
                // 현재 시간 가져오기
                DateTime today = DateTime.Now;

                // 콘솔 화면 지우기
                Console.Clear();

                // 날짜와 시간 출력
                Console.WriteLine("____<시계>_______________________________________________");
                Console.WriteLine(today.Year + "년 " + today.Month + "월 " + today.Day + "일");
                Console.WriteLine(today.Hour + "시 " + today.Minute + "분 " + today.Second + "초");
                Console.WriteLine("끝내려면 space바를 누르시오.");
                Console.WriteLine("_________________________________________________________");

                // 1초 대기
                Thread.Sleep(1000);

                // 키 입력 확인
                if (Console.KeyAvailable)
                {
                    // 스페이스바가 눌렸는지 확인
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        // 스페이스바를 누르면 루프 종료
                        break;
                    }
                }
            }

            //변수 출력
            Console.WriteLine("이것은 숫자입니다. {0} 두번째는 {1}", number, number2);

            while (i < 10)
            {
                Console.WriteLine("집 가고 싶다 {0}", i);
                i++;
            }

            //덧셈 함수 확인
            int a = 12;
            int b = 13;
            int result = 0;
            
            result = addNumber(a, b);
            Console.WriteLine(a + " + " + b + " = " + result);

            //배열 나열 개수확인
            int[] array = { 123, 234, 345, 456, 567 };

            printArray(array);

            cmp.print();


            //try catch 에러코드
            int[] array2 = { 1, 2, 3 };

            try {
                array2[4] = 4;
            }
            catch(Exception e)
            {
                Console.WriteLine("에러 {0}", e.Message);
            }

            //streamWriter 이용 메모장에 글자 적기
            string path = "C:\\test\\a.txt";

            FileStream fileStream = new FileStream
            (
                path,
                FileMode.Create,
                FileAccess.Write
            );

            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
            streamWriter.Write("hello World");
            streamWriter.Close();

        }

        //함수 만들기
        static int addNumber (int a, int b)
        {
            int result = a + b;

            return result;
        }

        //배열 사용
        static void printArray(params int[] array)
        {
            int length = array.Length;
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} 번째 인자는 {1} 입니다.", i, array[i]);
            }
        }
    }

    //클래스 생성
    class champ 
    {
        public String Name;
        public int age;
        public int hp;
        
        public void print()
        {
            Console.WriteLine("이름: " + Name + " 나이: " + age + " 체력: " + hp);
        }
    }

}
