using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lbresult.Text = "클릭 완료";
            /*
            string id = tbid.Text;
            string pw = tbpw.Text;
            
            if(id == "test" && pw == "1234")
            {
                MessageBox.Show("로그인 성공!\n" + "아이디: " + id + "비밀번호: " + pw);
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
            */
            /*
            ChromeOptions options = new ChromeOptions();
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeDriver driver = new ChromeDriver(driverService, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.naver.com";
            */
            /*
            //크롬 라이브러리 이용 야구 순위 검색
            var searchBoxElement = driver.FindElement(By.Id("query"));
            searchBoxElement.SendKeys("2023 프로야구 순위");
            Thread.Sleep(1000);

            var searchButtonElement = driver.FindElement(By.ClassName("btn_search"));
            searchButtonElement.Click();

            Thread.Sleep(5000);
            */

            // 크롬 라이브러리 이용 날씨 검색
            /*
            var searchBoxElement = driver.FindElement(By.Id("query"));
            searchBoxElement.SendKeys("날씨");
            Thread.Sleep(1000);

            var searchButtonElement = driver.FindElement(By.ClassName("btn_search"));
            searchButtonElement.Click();

            Thread.Sleep(3000);

            var temperatureTextElement = driver.FindElement(By.ClassName("temperature_text"));
            MessageBox.Show(temperatureTextElement.Text);

            driver.Quit();
            */

            lv.BeginUpdate();

            /*
            ListViewItem item1 = new ListViewItem("치토스");
            ListViewItem item2 = new ListViewItem("썬칩");
            ListViewItem item3 = new ListViewItem("오감자");
            ListViewItem item4 = new ListViewItem("콘칩");

            lv.Items.Add(item1);
            lv.Items.Add(item2);
            lv.Items.Add(item3);
            lv.Items.Add(item4);
            */

            /*
            string temp = tbid.Text;
            ListViewItem item1 = new ListViewItem(temp);

            lv.Items.Add(item1);
            */

            /*
            string[] data = { "치토스", "썬칩", "오감자", "콘칩" };
            cb.Items.AddRange(data);
            cb.SelectedItem = data[1];
            */

            string temp = cb.SelectedItem.ToString();
            ListViewItem item1 = new ListViewItem(temp);

            lv.Items.Add(item1);

            lv.EndUpdate();

        }
    }
}
