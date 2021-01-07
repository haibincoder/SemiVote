using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toupiao
{
    public partial class Form1 : Form
    {
        public List<String> ipList = new List<String>();
        public List<String> agentList = new List<String>();
        public String cookies;

        private string[] telStarts = "134,135,136,137,138,139,150,151,152,157,158,159,130,131,132,155,156,133,153,180,181,182,183,185,186,176,187,188,189,177,178".Split(',');

        public Form1()
        {
            InitializeComponent();
            setPhone();
            this.tb_company.Text = "1954";

            ipList.Add("61.135.186.243:80");
            ipList.Add("61.135.185.156:80");
            ipList.Add("220.181.111.37:80");
            ipList.Add("61.135.185.118:80");
            ipList.Add("182.61.62.74:80");
            ipList.Add("202.108.23.174:80");
            ipList.Add("117.185.17.151:80");
            ipList.Add("61.135.185.31:80");
            ipList.Add("218.59.139.238:80");

            agentList.Add("Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36 OPR/26.0.1656.60");
            agentList.Add("Opera/8.0 (Windows NT 5.1; U; en)");
            agentList.Add("Mozilla/5.0 (Windows NT 5.1; U; en; rv:1.8.1) Gecko/20061208 Firefox/2.0.0 Opera 9.50");

        }

        private void setPhone()
        {
            String phone = getRandomTel();
            this.tb_phone.Text = phone;
            this.tb_code.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getImage();
        }

        private void getImage()
        {
            String url = "http://action.cifnews.com/vote/VerifyCode/Index?type=calc&Key=vote_19&IsDistribute=1&a";
            HttpWebResponse resp;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.Timeout = 150000;
            resp = (HttpWebResponse)req.GetResponse();
            this.cookies = resp.Headers.Get("Set-Cookie");
            this.cookies = this.cookies.Split(';')[0].Split('=')[1];
            Image img = new System.Drawing.Bitmap(resp.GetResponseStream());

            this.pic_code.Image = img;
        }

        private void tb_code_TextChanged(object sender, EventArgs e)
        {
            if(this.tb_code.Text != null)
            {
                this.btn_submit.Enabled = true;
            }
            else
            {
                this.btn_submit.Enabled = false;
            }
        }

        /// <summary>
        /// 随机生成电话号码
        /// </summary>
        /// <returns></returns>
        public string getRandomTel()
        {
            Random ran = new Random();
            int n = ran.Next(10, 1000);
            int index = ran.Next(0, telStarts.Length - 1);
            string first = telStarts[index];
            string second = (ran.Next(100, 888) + 10000).ToString().Substring(1);
            string thrid = (ran.Next(1, 9100) + 10000).ToString().Substring(1);
            return first + second + thrid;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            String url = "http://action.cifnews.com/Vote/Add";
            Dictionary<object, object> param = new Dictionary<object, object>();
            param.Add("VoteId", "19");
            param.Add("Code", this.tb_code.Text);
            param.Add("Tel", this.tb_phone.Text);
            param.Add("ElementIds", this.tb_company.Text);

            String content = JsonConvert.SerializeObject(param);

            CookieContainer cc = new CookieContainer();
            Cookie session = new Cookie("ASP.NET_SessionId", this.cookies);
            session.Domain = "action.cifnews.com";
            cc.Add(session);

            WebHeaderCollection headers = new WebHeaderCollection();

            String result = Tools.PostRequest(url, param, cc);

            this.lbl_result.Text = result;

            getImage();
            setPhone();
            this.tb_code.Focus();
        }

    }
        
}
