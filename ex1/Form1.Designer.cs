
namespace ex1
{
    partial class form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.input = new System.Windows.Forms.RichTextBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pos = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.時間ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.分ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.語言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(30, 30);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(300, 300);
            this.input.TabIndex = 0;
            this.input.Text = "";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(500, 30);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(300, 300);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(350, 100);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 30);
            this.start.TabIndex = 2;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            // 
            // pos
            // 
            this.pos.AutoSize = true;
            this.pos.Location = new System.Drawing.Point(350, 70);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(32, 12);
            this.pos.TabIndex = 3;
            this.pos.Text = "時間:";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(350, 150);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(100, 30);
            this.stop.TabIndex = 4;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(350, 200);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(100, 30);
            this.end.TabIndex = 5;
            this.end.Text = "end";
            this.end.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.時間ToolStripMenuItem,
            this.語言ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開新ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            this.檔案ToolStripMenuItem.Click += new System.EventHandler(this.檔案ToolStripMenuItem_Click);
            // 
            // 開新ToolStripMenuItem
            // 
            this.開新ToolStripMenuItem.Name = "開新ToolStripMenuItem";
            this.開新ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開新ToolStripMenuItem.Text = "開新";
            // 
            // 時間ToolStripMenuItem
            // 
            this.時間ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.分ToolStripMenuItem,
            this.分ToolStripMenuItem1,
            this.分ToolStripMenuItem2});
            this.時間ToolStripMenuItem.Name = "時間ToolStripMenuItem";
            this.時間ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.時間ToolStripMenuItem.Text = "時間";
            // 
            // 分ToolStripMenuItem
            // 
            this.分ToolStripMenuItem.Name = "分ToolStripMenuItem";
            this.分ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.分ToolStripMenuItem.Text = "1分";
            // 
            // 分ToolStripMenuItem1
            // 
            this.分ToolStripMenuItem1.Name = "分ToolStripMenuItem1";
            this.分ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.分ToolStripMenuItem1.Text = "5分";
            // 
            // 分ToolStripMenuItem2
            // 
            this.分ToolStripMenuItem2.Name = "分ToolStripMenuItem2";
            this.分ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.分ToolStripMenuItem2.Text = "10分";
            // 
            // 語言ToolStripMenuItem
            // 
            this.語言ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.英文ToolStripMenuItem});
            this.語言ToolStripMenuItem.Name = "語言ToolStripMenuItem";
            this.語言ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.語言ToolStripMenuItem.Text = "語言";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.中文ToolStripMenuItem.Text = "中文";
            // 
            // 英文ToolStripMenuItem
            // 
            this.英文ToolStripMenuItem.Name = "英文ToolStripMenuItem";
            this.英文ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.英文ToolStripMenuItem.Text = "英文";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.end);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.start);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.menuStrip1);
            this.Name = "form1";
            this.Text = "打字測試";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pos;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 時間ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 分ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 語言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英文ToolStripMenuItem;
    }
}

