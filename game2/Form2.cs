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
    public partial class Form2 : Form
    {
        Form1 m_Form1;
        public Form2()
        {
            InitializeComponent();

            //텍스트 상자에 쓸 글씨
            wnans.Text = "주문을 외치자!";

            //열쇠_약 숨기기
            dufthl_dir.Enabled = false;
            dufthl_dir.Visible = false;
 
        }
        public Form2(Form1 form)
        {
            InitializeComponent();
            m_Form1 = form;
        }
        private void open_Click(object sender, EventArgs e)
        {
            //주문 입력
            if (wnans.Text == "아브라카타브라")
            {
                dufthl_dir.Enabled = true;
                dufthl_dir.Visible = true;

                //주문 외치기 버튼 비활성화
                open.Enabled = false;
                open.Visible = false;

                //텍스트 박스 비활성화
                wnans.Enabled = false;
                wnans.Visible = false;
            }
            else
                MessageBox.Show("주문이 틀린 거 같다. 다시 해보자.");
        }
 
        private void dufthl_dir_Click(object sender, EventArgs e)
        {
            //열쇠, 약 비활성화
            dufthl_dir.Enabled = false;
            dufthl_dir.Visible = false;

            //친절한 설명 뜨기
            tjfaud.Visible = true;
        }
    }
}
