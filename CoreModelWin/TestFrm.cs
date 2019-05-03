using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreModelWin
{
    public partial class TestFrm : CoreLib.MyForm
    {
        public TestFrm()
        {
            InitializeComponent();
            simpleButton1.Click += (s, e) => 
            {
                string pwd = passwordTxt.Text;
                string outPwd = CoreLib.SecurityStore.Blend (pwd);
                dataTable1.Rows.Add(pwd, outPwd);
            };
            simpleButton2.Click += (s, e) => 
            {
                byte[] asciiBytes = Encoding.ASCII.GetBytes(passwordTxt.Text);

                string msg = "";
                foreach (var item in asciiBytes)
                {
                    msg += item;    
                }
                hashTxt.Text = msg;
            };
        }
    }
}
