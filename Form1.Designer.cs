namespace DreamTeller3112
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내역불러오ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDream = new System.Windows.Forms.TextBox();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowResult);
            this.groupBox1.Controls.Add(this.tbDream);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 입력";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Location = new System.Drawing.Point(419, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "해몽 결과";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.내역불러오ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 도움ToolStripMenuItem
            // 
            this.도움ToolStripMenuItem.Name = "도움ToolStripMenuItem";
            this.도움ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도움ToolStripMenuItem.Text = "도움";
            // 
            // 내역불러오ToolStripMenuItem
            // 
            this.내역불러오ToolStripMenuItem.Name = "내역불러오ToolStripMenuItem";
            this.내역불러오ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.내역불러오ToolStripMenuItem.Text = "내역 불러오";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "꿈 내용";
            // 
            // tbDream
            // 
            this.tbDream.Location = new System.Drawing.Point(35, 84);
            this.tbDream.Multiline = true;
            this.tbDream.Name = "tbDream";
            this.tbDream.Size = new System.Drawing.Size(302, 179);
            this.tbDream.TabIndex = 1;
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(35, 301);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(302, 44);
            this.btnShowResult.TabIndex = 2;
            this.btnShowResult.Text = "해몽 보기";
            this.btnShowResult.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.ForeColor = System.Drawing.SystemColors.Control;
            this.tbResult.Location = new System.Drawing.Point(3, 30);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(367, 365);
            this.tbResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "3112 정민경";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내역불러오ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움ToolStripMenuItem;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.TextBox tbDream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult;
    }
}

