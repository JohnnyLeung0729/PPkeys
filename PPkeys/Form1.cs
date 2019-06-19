using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPkeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //RSACSPSample.RsaTest();

            SM4Utils sm4u = new SM4Utils();
            sm4u.secretKey = "JeF8U9wHFOMfs2Y8";

            string sm4str = sm4u.Encrypt_ECB("你好，我测试一下鸿蒙系统，这个厕所还是很好用的，马桶也不错 goodmorning sir hello world,is very gode coder 1234567890!@#$%^&*)");
            MessageBox.Show(sm4str);
            string strsm4 = sm4u.Decrypt_ECB(sm4str);
            MessageBox.Show(strsm4);

            //sm4u.iv = "UISwD9fW6cFh9SNS";
            //string sm4str1 = sm4u.Encrypt_CBC("你好，我测试一下鸿蒙系统，这个厕所还是很好用的，马桶也不错 goodmorning sir hello world,is very gode coder 1234567890!@#$%^&*)");
            //MessageBox.Show(sm4str1);
            //string strsm41 = sm4u.Decrypt_CBC(sm4str1);
            //MessageBox.Show(strsm41);
        }
    }
}
