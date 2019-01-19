namespace MathApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainText = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nextButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.dificultModePictureBox = new System.Windows.Forms.PictureBox();
            this.powerOpPictureBox = new System.Windows.Forms.PictureBox();
            this.printTypePictureBox = new System.Windows.Forms.PictureBox();
            this.startGamePictureBox = new System.Windows.Forms.PictureBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.uperTextLabel = new System.Windows.Forms.Label();
            this.lowerTextLabel = new System.Windows.Forms.Label();
            this.countDownLabel = new System.Windows.Forms.Label();
            this.historyButtonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nextButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dificultModePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerOpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printTypePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startGamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainText.Font = new System.Drawing.Font("幼圆", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainText.Location = new System.Drawing.Point(9, 42);
            this.mainText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.mainText.Multiline = true;
            this.mainText.Name = "mainText";
            this.mainText.ReadOnly = true;
            this.mainText.Size = new System.Drawing.Size(540, 100);
            this.mainText.TabIndex = 3;
            this.mainText.Text = "点击开始游戏";
            this.mainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nextButtonPictureBox
            // 
            this.nextButtonPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButtonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.nextButtonPictureBox.Location = new System.Drawing.Point(445, 310);
            this.nextButtonPictureBox.Name = "pictureBox1";
            this.nextButtonPictureBox.Size = new System.Drawing.Size(48, 48);
            this.nextButtonPictureBox.TabIndex = 4;
            this.nextButtonPictureBox.TabStop = false;
            this.nextButtonPictureBox.Click += new System.EventHandler(this.nextButtonPictureBox_Click);
            this.nextButtonPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nextButtonPictureBox_Click);
            this.nextButtonPictureBox.MouseEnter += new System.EventHandler(this.nextButtonPictureBox_MouseEnter);
            this.nextButtonPictureBox.MouseLeave += new System.EventHandler(this.nextButtonPictureBox_MouseLeave);
            // 
            // dificultModePictureBox
            // 
            this.dificultModePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dificultModePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.dificultModePictureBox.Location = new System.Drawing.Point(41, 158);
            this.dificultModePictureBox.Name = "pictureBox2";
            this.dificultModePictureBox.Size = new System.Drawing.Size(113, 32);
            this.dificultModePictureBox.TabIndex = 5;
            this.dificultModePictureBox.TabStop = false;
            this.dificultModePictureBox.Click += new System.EventHandler(this.dificultModePictureBox_Click);
            this.dificultModePictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dificultModePictureBox_Click);
            // 
            // powerOpPictureBox
            // 
            this.powerOpPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerOpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.powerOpPictureBox.Location = new System.Drawing.Point(219, 158);
            this.powerOpPictureBox.Name = "pictureBox3";
            this.powerOpPictureBox.Size = new System.Drawing.Size(115, 32);
            this.powerOpPictureBox.TabIndex = 6;
            this.powerOpPictureBox.TabStop = false;
            this.powerOpPictureBox.Click += new System.EventHandler(this.powerOpPictureBox_Click);
            this.powerOpPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.powerOpPictureBox_Click);
            // 
            // printTypePictureBox
            // 
            this.printTypePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printTypePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.printTypePictureBox.Location = new System.Drawing.Point(397, 161);
            this.printTypePictureBox.Name = "pictureBox4";
            this.printTypePictureBox.Size = new System.Drawing.Size(119, 32);
            this.printTypePictureBox.TabIndex = 7;
            this.printTypePictureBox.TabStop = false;
            this.printTypePictureBox.Click += new System.EventHandler(this.printTypePictureBox_Click);
            this.printTypePictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.printTypePictureBox_Click);
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("幼圆", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Input.Location = new System.Drawing.Point(7, 233);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(540, 41);
            this.Input.TabIndex = 8;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uperTextLabel
            // 
            this.uperTextLabel.AutoSize = true;
            this.uperTextLabel.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uperTextLabel.Location = new System.Drawing.Point(13, 9);
            this.uperTextLabel.Name = "label1";
            this.uperTextLabel.Size = new System.Drawing.Size(69, 20);
            this.uperTextLabel.TabIndex = 9;
            this.uperTextLabel.Text = "题目：";
            // 
            // lowerTextLabel
            // 
            this.lowerTextLabel.AutoSize = true;
            this.lowerTextLabel.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lowerTextLabel.Location = new System.Drawing.Point(13, 202);
            this.lowerTextLabel.Name = "label2";
            this.lowerTextLabel.Size = new System.Drawing.Size(109, 20);
            this.lowerTextLabel.TabIndex = 10;
            this.lowerTextLabel.Text = "填入答案：";
            // 
            // startGamePictureBox
            // 
            this.startGamePictureBox.BackColor = System.Drawing.Color.White;
            this.startGamePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGamePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.startGamePictureBox.Location = new System.Drawing.Point(198, 303);
            this.startGamePictureBox.Name = "pictureBox5";
            this.startGamePictureBox.Size = new System.Drawing.Size(171, 62);
            this.startGamePictureBox.TabIndex = 11;
            this.startGamePictureBox.TabStop = false;
            this.startGamePictureBox.Click += new System.EventHandler(this.startGamePictureBox_Click);
            // 
            // countDownLabel
            // 
            this.countDownLabel.AutoSize = true;
            this.countDownLabel.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.countDownLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.countDownLabel.Location = new System.Drawing.Point(442, 9);
            this.countDownLabel.Name = "label3";
            this.countDownLabel.Size = new System.Drawing.Size(0, 20);
            this.countDownLabel.TabIndex = 12;
            // 
            // historyButtonLabel
            // 
            this.historyButtonLabel.AutoSize = true;
            this.historyButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButtonLabel.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.historyButtonLabel.Location = new System.Drawing.Point(55, 325);
            this.historyButtonLabel.Name = "label4";
            this.historyButtonLabel.Size = new System.Drawing.Size(89, 19);
            this.historyButtonLabel.TabIndex = 14;
            this.historyButtonLabel.Text = "历史记录";
            this.historyButtonLabel.Click += new System.EventHandler(this.historyButtonLabel_Click);
            this.historyButtonLabel.MouseEnter += new System.EventHandler(this.historyButtonLabel_MouseEnter);
            this.historyButtonLabel.MouseLeave += new System.EventHandler(this.historyButtonLabel_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(559, 411);
            this.Controls.Add(this.historyButtonLabel);
            this.Controls.Add(this.countDownLabel);
            this.Controls.Add(this.startGamePictureBox);
            this.Controls.Add(this.lowerTextLabel);
            this.Controls.Add(this.uperTextLabel);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.printTypePictureBox);
            this.Controls.Add(this.powerOpPictureBox);
            this.Controls.Add(this.dificultModePictureBox);
            this.Controls.Add(this.nextButtonPictureBox);
            this.Controls.Add(this.mainText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Shitty Game";
            ((System.ComponentModel.ISupportInitialize)(this.nextButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dificultModePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerOpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printTypePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startGamePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mainText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox nextButtonPictureBox;
        private System.Windows.Forms.PictureBox dificultModePictureBox;
        private System.Windows.Forms.PictureBox powerOpPictureBox;
        private System.Windows.Forms.PictureBox printTypePictureBox;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label uperTextLabel;
        private System.Windows.Forms.Label lowerTextLabel;
        private System.Windows.Forms.PictureBox startGamePictureBox;
        private System.Windows.Forms.Label countDownLabel;
        private System.Windows.Forms.Label historyButtonLabel;
    }
}

