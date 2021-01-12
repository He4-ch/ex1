
namespace ex1
{
    partial class Form1
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
            this.pos1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.時間ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TS2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LTS1 = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LTS2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TS3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pos2 = new System.Windows.Forms.Label();
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
            // pos1
            // 
            this.pos1.AutoSize = true;
            this.pos1.Location = new System.Drawing.Point(350, 70);
            this.pos1.Name = "pos1";
            this.pos1.Size = new System.Drawing.Size(32, 12);
            this.pos1.TabIndex = 3;
            this.pos1.Text = "時間:";
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
            this.LTS1});
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
            this.開新ToolStripMenuItem.Click += new System.EventHandler(this.開新ToolStripMenuItem_Click);
            // 
            // 時間ToolStripMenuItem
            // 
            this.時間ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.TS1,
            this.TS2,
            this.TS3});
            this.時間ToolStripMenuItem.Name = "時間ToolStripMenuItem";
            this.時間ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.時間ToolStripMenuItem.Text = "時間";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem.Text = "1分";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.分ToolStripMenuItem_Click);
            // 
            // TS1
            // 
            this.TS1.Name = "TS1";
            this.TS1.Size = new System.Drawing.Size(180, 22);
            this.TS1.Text = "2分";
            this.TS1.Click += new System.EventHandler(this.TS1_Click);
            // 
            // TS2
            // 
            this.TS2.Name = "TS2";
            this.TS2.Size = new System.Drawing.Size(180, 22);
            this.TS2.Text = "5分";
            this.TS2.Click += new System.EventHandler(this.TS2_Click);
            // 
            // LTS1
            // 
            this.LTS1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.LTS2});
            this.LTS1.Name = "LTS1";
            this.LTS1.Size = new System.Drawing.Size(43, 20);
            this.LTS1.Text = "語言";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // LTS2
            // 
            this.LTS2.Name = "LTS2";
            this.LTS2.Size = new System.Drawing.Size(180, 22);
            this.LTS2.Text = "英文";
            // 
            // TS3
            // 
            this.TS3.Name = "TS3";
            this.TS3.Size = new System.Drawing.Size(180, 22);
            this.TS3.Text = "10分";
            this.TS3.Click += new System.EventHandler(this.TS3_Click);
            // 
            // pos2
            // 
            this.pos2.AutoSize = true;
            this.pos2.Location = new System.Drawing.Point(400, 70);
            this.pos2.Name = "pos2";
            this.pos2.Size = new System.Drawing.Size(11, 12);
            this.pos2.TabIndex = 7;
            this.pos2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.pos2);
            this.Controls.Add(this.end);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pos1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label pos1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 時間ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS1;
        private System.Windows.Forms.ToolStripMenuItem TS2;
        private System.Windows.Forms.ToolStripMenuItem LTS1;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LTS2;
        private System.Windows.Forms.ToolStripMenuItem TS3;
        private System.Windows.Forms.Label pos2;
    }
}

