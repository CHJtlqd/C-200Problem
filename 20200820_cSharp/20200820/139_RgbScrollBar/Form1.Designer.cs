namespace _139_RgbScrollBar
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scRed = new System.Windows.Forms.HScrollBar();
            this.scGreen = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.scBlue = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 197);
            this.panel1.TabIndex = 1;
            // 
            // scRed
            // 
            this.scRed.Location = new System.Drawing.Point(122, 248);
            this.scRed.Name = "scRed";
            this.scRed.Size = new System.Drawing.Size(360, 21);
            this.scRed.TabIndex = 2;
            this.scRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // scGreen
            // 
            this.scGreen.Location = new System.Drawing.Point(122, 323);
            this.scGreen.Name = "scGreen";
            this.scGreen.Size = new System.Drawing.Size(360, 21);
            this.scGreen.TabIndex = 4;
            this.scGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // scBlue
            // 
            this.scBlue.Location = new System.Drawing.Point(122, 390);
            this.scBlue.Name = "scBlue";
            this.scBlue.Size = new System.Drawing.Size(360, 21);
            this.scBlue.TabIndex = 6;
            this.scBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scr_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(506, 248);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(144, 25);
            this.txtRed.TabIndex = 7;
            this.txtRed.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(506, 323);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(144, 25);
            this.txtGreen.TabIndex = 8;
            this.txtGreen.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(506, 390);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(144, 25);
            this.txtBlue.TabIndex = 9;
            this.txtBlue.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.scBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scRed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar scRed;
        private System.Windows.Forms.HScrollBar scGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar scBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlue;
    }
}

