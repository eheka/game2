
namespace game2
{
    partial class Form2
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
            this.gkddkfl_on = new System.Windows.Forms.PictureBox();
            this.wnans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.dufthl_dir = new System.Windows.Forms.Button();
            this.tjfaud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gkddkfl_on)).BeginInit();
            this.SuspendLayout();
            // 
            // gkddkfl_on
            // 
            this.gkddkfl_on.BackColor = System.Drawing.Color.Transparent;
            this.gkddkfl_on.Image = global::game2.Properties.Resources.gkddkfl_on;
            this.gkddkfl_on.Location = new System.Drawing.Point(-2, 0);
            this.gkddkfl_on.Name = "gkddkfl_on";
            this.gkddkfl_on.Size = new System.Drawing.Size(860, 625);
            this.gkddkfl_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gkddkfl_on.TabIndex = 0;
            this.gkddkfl_on.TabStop = false;
            // 
            // wnans
            // 
            this.wnans.Location = new System.Drawing.Point(271, 229);
            this.wnans.Name = "wnans";
            this.wnans.Size = new System.Drawing.Size(202, 23);
            this.wnans.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.WhiteSmoke;
            this.open.Location = new System.Drawing.Point(271, 272);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(202, 62);
            this.open.TabIndex = 4;
            this.open.Text = "라고 주문을 외친다.";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // dufthl_dir
            // 
            this.dufthl_dir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.dufthl_dir.FlatAppearance.BorderSize = 0;
            this.dufthl_dir.Image = global::game2.Properties.Resources.dufthl_dir_12;
            this.dufthl_dir.Location = new System.Drawing.Point(241, 199);
            this.dufthl_dir.Name = "dufthl_dir";
            this.dufthl_dir.Size = new System.Drawing.Size(284, 123);
            this.dufthl_dir.TabIndex = 6;
            this.dufthl_dir.UseVisualStyleBackColor = false;
            this.dufthl_dir.Visible = false;
            this.dufthl_dir.Click += new System.EventHandler(this.dufthl_dir_Click);
            // 
            // tjfaud
            // 
            this.tjfaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.tjfaud.Enabled = false;
            this.tjfaud.FlatAppearance.BorderSize = 0;
            this.tjfaud.Location = new System.Drawing.Point(252, 34);
            this.tjfaud.Name = "tjfaud";
            this.tjfaud.Size = new System.Drawing.Size(293, 66);
            this.tjfaud.TabIndex = 7;
            this.tjfaud.Text = "제조가 끝났다. 더 이상 할 수 있는 게 없을 거 같다.";
            this.tjfaud.UseVisualStyleBackColor = false;
            this.tjfaud.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 625);
            this.Controls.Add(this.tjfaud);
            this.Controls.Add(this.dufthl_dir);
            this.Controls.Add(this.open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wnans);
            this.Controls.Add(this.gkddkfl_on);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gkddkfl_on)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gkddkfl_on;
        private System.Windows.Forms.TextBox wnans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wnans_button;
        private System.Windows.Forms.Button open;
        public System.Windows.Forms.Button dufthl_dir;
        private System.Windows.Forms.Button tjfaud;
    }
}