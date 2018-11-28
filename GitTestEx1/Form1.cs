using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTestEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //teststsetetest
        }
        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {   // 텍스트 박스의 엔터처리
                MessageBox.Show("ㅅㄷㄴㅅ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            // HEAD
            //
            //     // 아아아아아앙ㅁ덞러덜
            // parent of e2f9f78... 버튼 mbox 기능 추가
            // }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.label2.Text = "TEXT3";
        }
    }
}