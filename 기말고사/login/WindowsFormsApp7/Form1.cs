using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string password = textBox2.Text;

            if(userId == null || userId.Length == 0)
            {
                MessageBox.Show("아이디를 입력해 주세요.");
                return;
            }

            if (password == null || password.Length < 4)
            {
                MessageBox.Show("비밀번호를 4자리이상 입력해 주세요.");
                return;
            }


            string url = "http://58.145.23.13:5555/toeic/app.do?kind=login&userId="+userId+"&password="+password;
            string response = string.Empty;
            string data = "{datas~~~~}";

            // request setting
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Timeout = 10 * 1000;

            // Data Stream setting
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            request.ContentLength = bytes.Length;

            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(bytes, 0, bytes.Length);
            }

            // POST Request & Response
            string responseText = string.Empty;
            using (HttpWebResponse res = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = res.StatusCode;
                Stream response_stream = res.GetResponseStream();
                using (StreamReader read_stream = new StreamReader(response_stream))
                {
                    response = read_stream.ReadToEnd();
                }
            }


            dynamic json = JObject.Parse(response);
            string isConfirm = json["isConfirm"];
            string name = json["name"];

            if(isConfirm.Equals("Y"))
            {
                this.Visible = false;
                Form2 form2 = new Form2(name);
                form2.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다.");
            }
        }
    }
}
