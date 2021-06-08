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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //항아리 인식범위(확대-비활성)
            gkddkfl.Enabled = false;
            gkddkfl.Visible = false;

            //방1-바로실행
            //액자
            dorwk.Enabled = false;
            dorwk.Visible = false;
            dorwk.BackColor = Color.Transparent;
            dorwk.Parent = pictureBox1;

            //방2
            //자물쇠 가리기
            wkanfthl.Enabled = false;
            wkanfthl.Visible = false;

            //퍼즐문
            vjwmf.Enabled = false;
            vjwmf.Visible = false;
            vjwmf.BackColor = Color.Transparent;
            vjwmf.Parent = pictureBox1;

            //포탈 
            vhxkf.Enabled = false;
            vhxkf.Visible = false;

            //문 가리기
            ans.Enabled = false;
            ans.Visible = false;

            //방3
            //열매
            dufao.Enabled = false;
            dufao.Visible = false;
            dufao.BackColor = Color.Transparent;
            dufao.Parent = pictureBox1;

            //초
            ch.Enabled = false;
            ch.Visible = false;
            ch.BackColor = Color.Transparent;
            ch.Parent = pictureBox1;

            //꽃
            Rhc.Enabled = false;
            Rhc.Visible = false;
            Rhc.BackColor = Color.Transparent;
            Rhc.Parent = pictureBox1;

            //금가루
            rmarkfn.Enabled = false;
            rmarkfn.Visible = false;
            rmarkfn.BackColor = Color.Transparent;
            rmarkfn.Parent = pictureBox1;

            //빈종이
            qlswhddl.Enabled = false;
            qlswhddl.Visible = false;
            qlswhddl.BackColor = Color.Transparent;
            qlswhddl.Parent = pictureBox1;

            //금고
            rmarh.Enabled = false;
            rmarh.Visible = false;
            rmarh.BackColor = Color.Transparent;
            rmarh.Parent = pictureBox1;
            rmarh.SizeMode = PictureBoxSizeMode.StretchImage;


            //방4
            //보물상자
            qhanftkdwk.Enabled = false;
            qhanftkdwk.Visible = false;
            qhanftkdwk.BackColor = Color.Transparent;
            qhanftkdwk.Parent = pictureBox1;

            //금화
            rmaghk.Enabled = false;
            rmaghk.Visible = false;
            rmaghk.BackColor = Color.Transparent;
            rmaghk.Parent = pictureBox1;

            //자물쇠 가림막
            rmaghk.Enabled = false;
            rmaghk.Visible = false;

           //방5
            //비밀방 액자 활성화
            dorwk_qlalf.Enabled = false;
            dorwk_qlalf.Visible = false;
            
            //

            //아래 버튼 투명화
            ch_button.BackColor = Color.Transparent;
            dufao_button.BackColor = Color.Transparent;
            Rhc_button.BackColor = Color.Transparent;
            rmarkfn_button.BackColor = Color.Transparent;
            dir_button.BackColor = Color.Transparent;
            dufthl_button.BackColor = Color.Transparent;
            rmaghk_button.BackColor = Color.Transparent;
            qursksfh_button.BackColor = Color.Transparent;


        }

        private void dorwk_Click(object sender, EventArgs e)
        {
            if (ch_button.BackColor == Color.Red
                && dufao_button.BackColor == Color.Transparent
                && Rhc_button.BackColor == Color.Transparent
                && rmarkfn_button.BackColor == Color.Transparent
                && dufthl_button.BackColor == Color.Transparent
                && dir_button.BackColor == Color.Transparent
                && rmaghk_button.BackColor == Color.Transparent
                && qursksfh_button.BackColor == Color.Transparent)
            {
                MessageBox.Show("안녕하신가. 나는 마법사라네.\n" +
                    "자네 아무리 사정이 급해도 말이야 악명높은 내 집을 도둑질하려고 들어오다니 간이 웬만큼 부은 놈이었그려?\n" +
                    "그래서 훔친 것들을 압수하고 벌로 마법 감옥에 갇혀있게나.\n" +
                    "뭐? 여기서 나가고 싶다고라? 그렇다면 마법 감옥에서 탈출해보게\n" +
                    "자네가 욕심만(금화를 벽난로에 넣고) 태운다면 금방 탈출할 수가 있네.\n\n" +
                    "특별히 내가 친히 힌트를 주네.\n" +
                    "책상 위에 있는 종이에 진실을 밝히는 불을 붙여보게.","<마법사의 진실된 편지>");
            }
            else
                MessageBox.Show("안녕하신가. 나는 마법사라네.\n" +
                    "자네 아무리 사정이 급해도 말이야 악명높은 내 집을 도둑질하려고 들어오다니 간이 웬만큼 부은 놈이었그려?\n" +
                    "그래서 훔친 것들을 압수하고 벌로 마법 감옥에 갇혀있게나.\n" +
                    "뭐? 여기서 나가고 싶다고라? 그렇다면 마법 감옥에서 탈출해보게\n" +
                    "자네가 욕심만 태운다면 금방 탈출할 수가 있네.\n\n" +
                    "특별히 내가 친히 힌트를 주네.\n" +
                    "책상 위에 있는 종이에 진실을 밝히는 불을 붙여보게.", "<마법사의 편지>");
        }

        private void dlehd1_Click(object sender, EventArgs e)
        {
            //방1 배경 이미지 불러오기
            pictureBox1.Image = Properties.Resources.방1;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //액자 활성화
            dorwk.Enabled = true;
            dorwk.Visible = true;

            //초 사라짐
            ch.Enabled = false;
            ch.Visible = false;

            //열매 사라짐
            dufao.Enabled = false;
            dufao.Visible = false;

            //꽃 사라짐
            Rhc.Enabled = false;
            Rhc.Visible = false;

            //금가루 사라짐
            rmarkfn.Enabled = false;
            rmarkfn.Visible = false;

            //보물상자 사라짐
            qhanftkdwk.Enabled = false;
            qhanftkdwk.Visible = false;

            //항아리 사라짐
            gkddkfl.Enabled = false;
            gkddkfl.Visible = false;

            //빈종이 사라짐
            qlswhddl.Enabled = false;
            qlswhddl.Visible = false;

            //종이 사라짐
            whddl.Enabled = false;
            whddl.Visible = false;

            //금고 사라짐
            rmarh.Enabled = false;
            rmarh.Visible = false;

            //자물쇠 가림막
            wkanfthl.Enabled = false;
            wkanfthl.Visible = false;

            //퍼즐문
            vjwmf.Enabled = false;
            vjwmf.Visible = false;

            //포탈 사라짐
            vhxkf.Enabled = false;
            vhxkf.Visible = false;

            //문 사라짐
            ans.Enabled = false;
            ans.Visible = false;

            //비밀방 액자 활성화
            dorwk_qlalf.Enabled = false;
            dorwk_qlalf.Visible = false;

            //이동 5 사라짐
            dlehd5.Enabled = false;
            dlehd5.Visible = false;

        }

        private void dlehd2_Click(object sender, EventArgs e)
        {
            //방2 배경 이미지 불러오기
            pictureBox1.Image = Properties.Resources.방2;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //액자 사라짐
            dorwk.Enabled = false;
            dorwk.Visible = false;

            //초 사라짐
            ch.Enabled = false;
            ch.Visible = false;

            //열매 사라짐
            dufao.Enabled = false;
            dufao.Visible = false;

            //꽃 사라짐
            Rhc.Enabled = false;
            Rhc.Visible = false;

            //금가루 사라짐
            rmarkfn.Enabled = false;
            rmarkfn.Visible = false;

            //보물상자 사라짐
            qhanftkdwk.Enabled = false;
            qhanftkdwk.Visible = false;

            //항아리 사라짐
            gkddkfl.Enabled = false;
            gkddkfl.Visible = false;

            //빈종이 사라짐
            qlswhddl.Enabled = false;
            qlswhddl.Visible = false;

            //종이 사라짐
            whddl.Enabled = false;
            whddl.Visible = false;

            //금고 사라짐
            rmarh.Enabled = false;
            rmarh.Visible = false;

            //비밀방 액자 비활성화
            dorwk_qlalf.Enabled = false;
            dorwk_qlalf.Visible = false;

            //이동 5 사라짐
            dlehd5.Enabled = false;
            dlehd5.Visible = false;

            //포탈 나타나기, 없애기
            if (vjwmf.BackColor == Color.White)
            {
                vhxkf.Enabled = true;
                vhxkf.Visible = true;
            }    
            else
            {
                vhxkf.Enabled = false;
                vhxkf.Visible = false;
            }

            //방5로 가는 문 보이기, 가리기
            if (dlehd5.BackColor == Color.Black)
            {
                //퍼즐 가리기
                vjwmf.Enabled = false;
                vjwmf.Visible = false;

                //자물쇠 가리기
                wkanfthl.Enabled = false;
                wkanfthl.Visible = false;

                //문 가리기
                ans.Enabled = false;
                ans.Visible = false;

                //방5 문 보이기
                dlehd5.Enabled = true;
                dlehd5.Visible = true;

            }
            else
            {
                //퍼즐 보이기
                vjwmf.Enabled = true;
                vjwmf.Visible = true;

                //문 보이기
                ans.Enabled = true;
                ans.Visible = true;

                //방5 문 가리기
                dlehd5.Enabled = false;
                dlehd5.Visible = false;
            }


        }

        private void dlehd3_Click(object sender, EventArgs e)
        {
            //방3 배경 이미지 불러오기
            pictureBox1.Image = Properties.Resources.qkd3;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //액자 사라짐
            dorwk.Enabled = false;
            dorwk.Visible = false;

            //보물상자 사라짐
            qhanftkdwk.Enabled = false;
            qhanftkdwk.Visible = false;

            //자물쇠 가림막
            wkanfthl.Enabled = false;
            wkanfthl.Visible = false;

            //퍼즐문
            vjwmf.Enabled = false;
            vjwmf.Visible = false;

            //포탈 사라짐
            vhxkf.Enabled = false;
            vhxkf.Visible = false;

            //문 사라짐
            ans.Enabled = false;
            ans.Visible= false;

            //비밀방 액자 활성화
            dorwk_qlalf.Enabled = false;
            dorwk_qlalf.Visible = false;

            //이동 5 사라짐
            dlehd5.Enabled = false;
            dlehd5.Visible = false;

            //금고 활성화, 경로 삭제
            if (qursksfh_button.Enabled == true)
            {
                rmarh.Enabled = false;
                rmarh.Visible = false;
            }
            else
            {
                rmarh.Enabled = true;
                rmarh.Visible = true;
            }


            //빈종이 활성화
            if (qlswhddl.BackColor != Color.Red)
            {
                qlswhddl.Enabled = true;
                qlswhddl.Visible = true;

                //종이 비활성화
                whddl.Enabled = false;
                whddl.Visible = false;
            }
            else
            {
                qlswhddl.Enabled = false;
                qlswhddl.Visible = false;

                //종이 활성화
                whddl.Enabled = true;
                whddl.Visible = true;
            }


            //항아리 새로운 폼 활성화, 경로 삭제
            if (dufthl_button.Enabled == true && dir_button.Enabled == true)
            {
                gkddkfl.Enabled = false;
                gkddkfl.Visible = false;
            }
            else
            {
                gkddkfl.Enabled = true;
                gkddkfl.Visible = true;
            }

            //초 버튼 활성화, 초 사라짐
            if (ch_button.Enabled == true)
            {
                ch.Enabled = false;
                ch.Visible = false;
            }
            else
            {
                ch.Enabled = true;
                ch.Visible = true;
            }

            //열매 버튼 활성화, 열매 사라짐
            if (dufao_button.Enabled == true)
            {
                dufao.Enabled = false;
                dufao.Visible = false;
            }
            else
            {
                dufao.Enabled = true;
                dufao.Visible = true;
            }

            //꽃 버튼 활성화, 꽃 사라짐
            if (Rhc_button.Enabled == true)
            {
                Rhc.Enabled = false;
                Rhc.Visible = false;
            }
            else
            {
                Rhc.Enabled = true;
                Rhc.Visible = true;
            }

            //금가루 버튼 활성화, 금가루 사라짐
            if (rmarkfn_button.Enabled == true)
            {
                rmarkfn.Enabled = false;
                rmarkfn.Visible = false;
            }
            else
            {
                rmarkfn.Enabled = true;
                rmarkfn.Visible = true;
            }
        }

        private void dlehd4_Click(object sender, EventArgs e)
        {
            //방4 배경 이미지 불러오기
            pictureBox1.Image = Properties.Resources.qkd4;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //액자 사라짐
            dorwk.Enabled = false;
            dorwk.Visible = false;

            //초 사라짐
            ch.Enabled = false;
            ch.Visible = false;

            //열매 사라짐
            dufao.Enabled = false;
            dufao.Visible = false;

            //꽃 사라짐
            Rhc.Enabled = false;
            Rhc.Visible = false;

            //금가루 사라짐
            rmarkfn.Enabled = false;
            rmarkfn.Visible = false;

            //항아리 사라짐
            gkddkfl.Enabled = false;
            gkddkfl.Visible = false;

            //빈종이 사라짐
            qlswhddl.Enabled = false;
            qlswhddl.Visible = false;

            //종이 사라짐
            whddl.Enabled = false;
            whddl.Visible = false;

            //금고 사라짐
            rmarh.Enabled = false;
            rmarh.Visible = false;

            //자물쇠 가림막
            rmaghk.Enabled = false;
            rmaghk.Visible = false;

            ////퍼즐문
            vjwmf.Enabled = false;
            vjwmf.Visible = false;

            //포탈 사라짐
            vhxkf.Enabled = false;
            vhxkf.Visible = false;
            
            //문 사라짐
            ans.Enabled = false;
            ans.Visible = false;

            //비밀방 액자 활성화
            dorwk_qlalf.Enabled = false;
            dorwk_qlalf.Visible = false;

            //이동 5 사라짐
            dlehd5.Enabled = false;
            dlehd5.Visible = false;

            //보물상자 활성화, 보물상자 사라짐
            if (qhanftkdwk.BackColor == Color.Red)
            {
                qhanftkdwk.Enabled = false;
                qhanftkdwk.Visible = false;

            }
            else
            {
                qhanftkdwk.Enabled = true;
                qhanftkdwk.Visible = true;

            }

            //금화 활성화, 금화 사라짐
            if (rmaghk_button.Enabled == false && qhanftkdwk.BackColor == Color.Red)
            {
                rmaghk.Enabled = true;
                rmaghk.Visible = true;

            }
            else
            {
                rmaghk.Enabled = false;
                rmaghk.Visible = false;
            }
        }

        private void dufao_Click(object sender, EventArgs e)
        {
            //열매 사라짐
            dufao.Enabled = false;
            dufao.Visible = false;

            //열매 버튼 활성화
            dufao_button.Enabled = true;
            dufao_button.Visible = true;
            dufao_button.Image = Properties.Resources.dufao;
            dufao_button.BackColor = Color.Transparent;
        }

        private void ch_Click(object sender, EventArgs e)
        {
            //초 사라짐
            ch.Enabled = false;
            ch.Visible = false;

            //초 버튼 활성화
            ch_button.Enabled = true;
            ch_button.Visible = true;
            ch_button.Image = Properties.Resources.ch;
            ch_button.BackColor = Color.Transparent;
        }

        private void Rhc_Click(object sender, EventArgs e)
        {
            //꽃 사라짐
            Rhc.Enabled = false;
            Rhc.Visible = false;

            //꽃 버튼 활성화
            Rhc_button.Enabled = true;
            Rhc_button.Visible = true;
            Rhc_button.Image = Properties.Resources.Rhc;
            Rhc_button.BackColor = Color.Transparent;
        }

        private void rmarkfn_Click(object sender, EventArgs e)
        {
            //금가루 사라짐
            rmarkfn.Enabled = false;
            rmarkfn.Visible = false;

            //금가루 버튼 활성화
            rmarkfn_button.Enabled = true;
            rmarkfn_button.Visible = true;
            rmarkfn_button.Image = Properties.Resources.rmarkfn;
            rmarkfn_button.BackColor = Color.Transparent;
        }

        private void qhanftkdwk_Click(object sender, EventArgs e)
        {
            //열쇠로 보물상자 클릭
            if (ch_button.BackColor == Color.Transparent
               && dufao_button.BackColor == Color.Transparent
               && Rhc_button.BackColor == Color.Transparent
               && rmarkfn_button.BackColor == Color.Transparent
               && dufthl_button.BackColor == Color.Red
               && dir_button.BackColor == Color.Transparent
               && rmaghk_button.BackColor == Color.Transparent
               && qursksfh_button.BackColor == Color.Transparent)
            {
                //보물상자 사라짐
                qhanftkdwk.Enabled = false;
                qhanftkdwk.Visible = false;
                qhanftkdwk.BackColor = Color.Red;

                //금화 나타남
                rmaghk.Enabled = true;
                rmaghk.Visible = true;
            }
        }

        private void ch_button_Click(object sender, EventArgs e)
        {

            //초 버튼 빨간색으로 활성화
            if (ch_button.BackColor == Color.Transparent)
            {
                ch_button.BackColor = Color.Red;
            }
            else
            {
                ch_button.BackColor = Color.Transparent;
            }

        }

        private void dufao_button_Click(object sender, EventArgs e)
        {
            //열매 버튼 빨간색으로 활성화
            if (dufao_button.BackColor == Color.Transparent)
            {
                dufao_button.BackColor = Color.Red;
            }
            else
            {
                dufao_button.BackColor = Color.Transparent;
            }
        }

        private void Rhc_button_Click(object sender, EventArgs e)
        {
            //꽃 버튼 빨간색으로 활성화
            if (Rhc_button.BackColor == Color.Transparent)
            {
                Rhc_button.BackColor = Color.Red;
            }
            else
            {
                Rhc_button.BackColor = Color.Transparent;
            }
        }

        private void rmarkfn_button_Click(object sender, EventArgs e)
        {
            //금가루 버튼 빨간색으로 활성화
            if (rmarkfn_button.BackColor == Color.Transparent)
            {
                rmarkfn_button.BackColor = Color.Red;
            }
            else
            {
                rmarkfn_button.BackColor = Color.Transparent;
            }
        }

        private void gkddkfl_Click(object sender, EventArgs e)
        {

            //열매, 꽃, 금가루 활성화 후 클릭하면 화면 확대
            if (ch_button.BackColor == Color.Transparent
                && dufao_button.BackColor == Color.Red
                && Rhc_button.BackColor == Color.Red
                && rmarkfn_button.BackColor == Color.Red
                && dufthl_button.BackColor == Color.Transparent
                && dir_button.BackColor == Color.Transparent
                && rmaghk_button.BackColor == Color.Transparent
                && qursksfh_button.BackColor == Color.Transparent)
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                frm2.dufthl_dir.Click += new EventHandler(dufthl_dir);
            }
        }

        void dufthl_dir(object sender, EventArgs e)
        {
            //열쇠 버튼 활성화
            dufthl_button.Enabled = true;
            dufthl_button.Visible = true;
            dufthl_button.Image = Properties.Resources.dufthl;

            //약 버튼 활성화
            dir_button.Enabled = true;
            dir_button.Visible = true;
            dir_button.Image = Properties.Resources.dir;

            //항아리 비활성화
            gkddkfl.Enabled = false;
            gkddkfl.Visible = false;
        }

        private void dufthl_button_Click(object sender, EventArgs e)
        {
            //열쇠 버튼 빨간색으로 활성화
            if (dufthl_button.BackColor == Color.Transparent)
            {
                dufthl_button.BackColor = Color.Red;
            }
            else
            {
                dufthl_button.BackColor = Color.Transparent;
            }
        }

        private void dir_button_Click(object sender, EventArgs e)
        {
            //약 버튼 빨간색으로 활성화
            if (dir_button.BackColor == Color.Transparent)
            {
                dir_button.BackColor = Color.Red;
            }
            else
            {
                dir_button.BackColor = Color.Transparent;
            }
        }

        private void qlswhddl_Click(object sender, EventArgs e)
        {
            //초만 빨간색일때 클릭
            if (ch_button.BackColor == Color.Red
                && dufao_button.BackColor == Color.Transparent
                && Rhc_button.BackColor == Color.Transparent
                && rmarkfn_button.BackColor == Color.Transparent
                && dufthl_button.BackColor == Color.Transparent
                && dir_button.BackColor == Color.Transparent
                && rmaghk_button.BackColor == Color.Transparent
                && qursksfh_button.BackColor == Color.Transparent)
            {
                //빈종이 비활성화, 배경색 빨강으로 바꾸기
                qlswhddl.Enabled = false;
                qlswhddl.Visible = false;
                qlswhddl.BackColor = Color.Red;

                //종이 활성화
                whddl.Enabled = true;
                whddl.Visible = true;
            }

        }
        private void whddl_Click(object sender, EventArgs e)
        {
            //레시피 새로운 폼으로 나옴
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void rmaghk_Click(object sender, EventArgs e)
        {
            //금화 비활성
            rmaghk.Enabled = false;
            rmaghk.Visible = false;

            //금화 버튼 활성화
            rmaghk_button.Enabled = true;
            rmaghk_button.Visible = true;
            rmaghk_button.Image = Properties.Resources.rmaghkwnajsl;
        }

        private void rmaghk_button_Click(object sender, EventArgs e)
        {
            //금화 버튼 빨간색으로 활성화
            if (rmaghk_button.BackColor == Color.Transparent)
            {
                rmaghk_button.BackColor = Color.Red;
            }
            else
            {
                rmaghk_button.BackColor = Color.Transparent;
            }
        }

        private void rmarh_Click(object sender, EventArgs e)
        {
            //금고 새로운 폼으로 나옴
            Form4 frm4 = new Form4();
            frm4.Show();
            frm4.qursksfh_whrkr.Click += new EventHandler(qursksfh_whrkr_1);
        }
        void qursksfh_whrkr_1(object sender, EventArgs e)
        {
            //벽난로 버튼 활성화
            qursksfh_button.Enabled = true;
            qursksfh_button.Visible = true;
            qursksfh_button.Image = Properties.Resources.qursksfh_whrkr_button;

            //금고 비활성화
            rmarh.Enabled = false;
            rmarh.Visible = false;
        }
        private void vjwmf_Click(object sender, EventArgs e)
        {
            //벽난로 조각만 빨간색일때 클릭
            if (ch_button.BackColor == Color.Transparent
                && dufao_button.BackColor == Color.Transparent
                && Rhc_button.BackColor == Color.Transparent
                && rmarkfn_button.BackColor == Color.Transparent
                && dufthl_button.BackColor == Color.Transparent
                && dir_button.BackColor == Color.Transparent
                && rmaghk_button.BackColor == Color.Transparent
                && qursksfh_button.BackColor == Color.Red
)
            {
                vjwmf.Image = Properties.Resources.qursksfh_whrkr;
                vjwmf.BackColor = Color.Black;
            }
            //초만 빨간색일때 클릭
            if (ch_button.BackColor == Color.Red
                && dufao_button.BackColor == Color.Transparent
                && Rhc_button.BackColor == Color.Transparent
                && rmarkfn_button.BackColor == Color.Transparent
                && dufthl_button.BackColor == Color.Transparent
                && dir_button.BackColor == Color.Transparent
                && rmaghk_button.BackColor == Color.Transparent
                && qursksfh_button.BackColor == Color.Transparent
                && vjwmf.BackColor == Color.Black)
            {
                vjwmf.Image = Properties.Resources.Inkedwhrkr_2;
                vjwmf.BackColor = Color.Yellow;

            }
            //금화만 빨간색일때 클릭
            if (ch_button.BackColor == Color.Transparent
                && dufao_button.BackColor == Color.Transparent
                && Rhc_button.BackColor == Color.Transparent
                && rmarkfn_button.BackColor == Color.Transparent
                && dufthl_button.BackColor == Color.Transparent
                && dir_button.BackColor == Color.Transparent
                && rmaghk_button.BackColor == Color.Red
                && qursksfh_button.BackColor == Color.Transparent
                && vjwmf.BackColor == Color.Yellow)
            {
                vjwmf.Image = Properties.Resources.vjwmf_3;
                vjwmf.BackColor = Color.White;

                //자물쇠 가리기 온
                wkanfthl.Enabled = true;
                wkanfthl.Visible = true;
            }


        }

        private void ans_Click(object sender, EventArgs e)
        {
            //열쇠만 빨간색일때 실행
            if (ch_button.BackColor == Color.Transparent
                && dufao_button.BackColor == Color.Transparent
                && Rhc_button.BackColor == Color.Transparent
                && rmarkfn_button.BackColor == Color.Transparent
                && dufthl_button.BackColor == Color.Red
                && dir_button.BackColor == Color.Transparent
                && rmaghk_button.BackColor == Color.Transparent
                && qursksfh_button.BackColor == Color.Transparent
                && vjwmf.BackColor == Color.White)
            {
                //문 없애기
                ans.Enabled = false;
                ans.Visible = false;

                //자물쇠 가림막 없애기
                wkanfthl.Enabled = false;
                wkanfthl.Visible = false;

                //포탈 활성화
                vhxkf.Enabled = true;
                vhxkf.Visible = true;
                vhxkf.BackColor = Color.Black;

                //이동 5 활성화
                dlehd5.Enabled = true;
                dlehd5.Visible = true;
                dlehd5.BackColor = Color.Black;
            }


        }

        private void dlehd5_Click(object sender, EventArgs e)
        {
            //방5 배경 이미지 불러오기
            pictureBox1.Image = Properties.Resources.비밀방;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //비밀방 액자 활성화
            dorwk_qlalf.Enabled = true;
            dorwk_qlalf.Visible = true;

            //자물쇠 가리기 사라짐
            wkanfthl.Enabled = false;
            wkanfthl.Visible = false;

            //이동문 사라짐
            dlehd5.Enabled = false;
            dlehd5.Visible = false;

            //퍼즐 사라짐
            vjwmf.Enabled = false;
            vjwmf.Visible = false;

            //문 손잡이 사라짐
            ans.Enabled = false;
            ans.Visible = false;

            //이동 5 문 사라짐
            dlehd5.Enabled = false;
            dlehd5.Visible = false;

            //포탈 사라짐
            vhxkf.Enabled = false;
            vhxkf.Visible = false;

        }

        private void dorwk_qlalf_Click(object sender, EventArgs e)
        {
            if (ch_button.BackColor == Color.Red
               && dufao_button.BackColor == Color.Transparent
               && Rhc_button.BackColor == Color.Transparent
               && rmarkfn_button.BackColor == Color.Transparent
               && dufthl_button.BackColor == Color.Transparent
               && dir_button.BackColor == Color.Transparent
               && rmaghk_button.BackColor == Color.Transparent
               && qursksfh_button.BackColor == Color.Transparent)
            {
                MessageBox.Show("아니 자네 아직도 탈출하지 못했느냐!\n" +
                    "내가 진작에 탈출 방법을 알려줬거들. 쯧쯧 자네가 여기를 탈출할 마음이 있는 건가 싶네.\n" +
                    "탈출 방법은 처음 편지에 이미 적어두었다네.", "<마법사의 진실의 편지2>");
            }
            else
                MessageBox.Show("아니 자네 아직도 탈출하지 못하었느냐!\n" +
                    "내가 진작에 탈출 방법을 알려줬거들. 쯧쯧 자네가 여기를 탈출할 마음이 있는 건가 싶네.\n" +
                    "탈출 방법은 .. ... .. ......(글씨가 흐려서 보이지 않는다.)", "<마법사의 편지2>");
        }

        private void qursksfh_button_Click(object sender, EventArgs e)
        {
            //벽난로 버튼 빨간색으로 활성화
            if (qursksfh_button.BackColor == Color.Transparent)
            {
                qursksfh_button.BackColor = Color.Red;
            }
            else
            {
                qursksfh_button.BackColor = Color.Transparent;
            }
        }

        private void vhxkf_Click(object sender, EventArgs e)
        {

            //엔딩
            if (vhxkf.BackColor == Color.White)
            {
                //표지 활성화
                vywl.Enabled = true;
                vywl.Visible = true;
                vywl.Image = Properties.Resources.dpseld;

            }

            //금화만 빨간색일때 실행
            if (ch_button.BackColor == Color.Transparent
               && dufao_button.BackColor == Color.Transparent
               && Rhc_button.BackColor == Color.Transparent
               && rmarkfn_button.BackColor == Color.Transparent
               && dufthl_button.BackColor == Color.Transparent
               && dir_button.BackColor == Color.Transparent
               && rmaghk_button.BackColor == Color.Red
               && qursksfh_button.BackColor == Color.Transparent)
            {
                vhxkf.Image = Properties.Resources.rmaghk_qursksfh;
                vhxkf.BackColor = Color.Red;
            }

            //초만 빨간색일때 실행
            if (ch_button.BackColor == Color.Red
               && dufao_button.BackColor == Color.Transparent
               && Rhc_button.BackColor == Color.Transparent
               && rmarkfn_button.BackColor == Color.Transparent
               && dufthl_button.BackColor == Color.Transparent
               && dir_button.BackColor == Color.Transparent
               && rmaghk_button.BackColor == Color.Transparent
               && qursksfh_button.BackColor == Color.Transparent
               && vhxkf.BackColor == Color.Red)
            {
                vhxkf.Image = Properties.Resources.vhxkf;
                vhxkf.BackColor = Color.White;
            }

        }

        private void tlwkr_Click(object sender, EventArgs e)
        {
            //방1 배경 이미지 불러오기
            pictureBox1.Image = Properties.Resources.방1;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //액자 활성화
            dorwk.Enabled = true;
            dorwk.Visible = true;

            //표지 비활성화
            vywl.Enabled = false;
            vywl.Visible = false;

            //시작하기 버튼 비활성화
            tlwkr.Enabled = false;
            tlwkr.Visible = false;
        }
    }

}
