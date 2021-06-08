using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game2
{
    public partial class Form4 : Form
    {
        Form1 m_Form1;
        public Form4()
        {
            InitializeComponent();
            qlalfqjsgh.Text = "숫자 3개를 입력하세요";
        }

        private void qlalfqjsgh_TextChanged(object sender, EventArgs e)
        {
            
        }

        public Form4(Form1 form)
        {
            InitializeComponent();
            m_Form1 = form;
        }

        private void ans_open_Click(object sender, EventArgs e)
        {
            if (qlalfqjsgh.Text == "611")
            {
                //금고 그림 바꾸기
                pictureBox1.Image = Properties.Resources.rmarh_qls;

                //벽난로 조각 나오기
                qursksfh_whrkr.Enabled = true;
                qursksfh_whrkr.Visible = true;

                //주문 외치기 버튼 비활성화
                ans_open.Enabled = false;
                ans_open.Visible = false;

                //텍스트 박스 비활성화
                qlalfqjsgh.Enabled = false;
                qlalfqjsgh.Visible = false;

                //안내문 바꾸기
                dkssoans.Text = "금고가 열렸다.";
            }
            else
                MessageBox.Show("비밀번호가 틀린 거 같다. 다시 해보자.");
        }

        private void qursksfh_whrkr_Click(object sender, EventArgs e)
        {
            //벽난로 조각 사라짐
            qursksfh_whrkr.Enabled = false;
            qursksfh_whrkr.Visible = false;

            //안내문 바꾸기
            dkssoans.Text = "더 이상 할 수 있는 게 없을 거 같다.";
        }
    }
}
