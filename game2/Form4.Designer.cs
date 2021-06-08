
namespace game2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dkssoans = new System.Windows.Forms.Button();
            this.qlalfqjsgh = new System.Windows.Forms.TextBox();
            this.ans_open = new System.Windows.Forms.Button();
            this.qursksfh_whrkr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qursksfh_whrkr)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game2.Properties.Resources.rmarh;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dkssoans
            // 
            this.dkssoans.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dkssoans.Enabled = false;
            this.dkssoans.FlatAppearance.BorderSize = 0;
            this.dkssoans.Location = new System.Drawing.Point(203, 12);
            this.dkssoans.Name = "dkssoans";
            this.dkssoans.Size = new System.Drawing.Size(167, 41);
            this.dkssoans.TabIndex = 1;
            this.dkssoans.Text = "비밀번호를 입력해주세요.";
            this.dkssoans.UseVisualStyleBackColor = false;
            // 
            // qlalfqjsgh
            // 
            this.qlalfqjsgh.Location = new System.Drawing.Point(203, 103);
            this.qlalfqjsgh.Name = "qlalfqjsgh";
            this.qlalfqjsgh.Size = new System.Drawing.Size(153, 23);
            this.qlalfqjsgh.TabIndex = 2;
            this.qlalfqjsgh.TextChanged += new System.EventHandler(this.qlalfqjsgh_TextChanged);
            // 
            // ans_open
            // 
            this.ans_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.ans_open.FlatAppearance.BorderSize = 0;
            this.ans_open.Location = new System.Drawing.Point(45, 132);
            this.ans_open.Name = "ans_open";
            this.ans_open.Size = new System.Drawing.Size(33, 155);
            this.ans_open.TabIndex = 3;
            this.ans_open.Text = "문을 열어본다.";
            this.ans_open.UseVisualStyleBackColor = false;
            this.ans_open.Click += new System.EventHandler(this.ans_open_Click);
            // 
            // qursksfh_whrkr
            // 
            this.qursksfh_whrkr.BackColor = System.Drawing.Color.Black;
            this.qursksfh_whrkr.Enabled = false;
            this.qursksfh_whrkr.Image = global::game2.Properties.Resources.qursksfh_whrkr;
            this.qursksfh_whrkr.Location = new System.Drawing.Point(174, 153);
            this.qursksfh_whrkr.Name = "qursksfh_whrkr";
            this.qursksfh_whrkr.Size = new System.Drawing.Size(215, 134);
            this.qursksfh_whrkr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qursksfh_whrkr.TabIndex = 4;
            this.qursksfh_whrkr.TabStop = false;
            this.qursksfh_whrkr.Visible = false;
            this.qursksfh_whrkr.Click += new System.EventHandler(this.qursksfh_whrkr_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 344);
            this.Controls.Add(this.qursksfh_whrkr);
            this.Controls.Add(this.ans_open);
            this.Controls.Add(this.qlalfqjsgh);
            this.Controls.Add(this.dkssoans);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qursksfh_whrkr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dkssoans;
        private System.Windows.Forms.TextBox qlalfqjsgh;
        private System.Windows.Forms.Button ans_open;
        public System.Windows.Forms.PictureBox qursksfh_whrkr;
    }
}