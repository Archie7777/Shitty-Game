using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mathproblem;

namespace MathApp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        int scss = 20;
        private void timer1_Tick(object sender, EventArgs e)//倒计时
        {
            this.countDownLabel.Text = "倒计时:" + this.scss + "秒";
            scss--;
            if (scss == 0)
            {
                scss = 20;
                this.countDownLabel.Text = "倒计时：" + this.scss + "秒";
                if (Input.Text == expreesion.GetAnswerString() || Input.Text == "whosyourdaddy")
                {
                    correctNum++;
                }
                else wrongNum++;
                problemNum++;
                if (problemNum == 11)
                {
                    Number num = new Number(correctNum);
                    Number num2 = new Number(wrongNum);
                    mainText.Text = "游戏结束" + "," + "正确个数：" + num.GetString() + " 错误个数：" + num2.GetString();
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./History.txt", true))
                    {
                        file.WriteLine("正确个数：{0} 错误个数：{1}", correctNum, wrongNum);
                    }
                    startGamePictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "startGame.png");
                    correctNum = 0;
                    wrongNum = 0;
                    problemNum = 0;
                }
                else
                {
                    expreesion = new Expression();
                    while (expreesion.IsInvalid())
                    {
                        expreesion = new Expression();
                    }
                    mainText.Text = expreesion.GetExpressionString();
                }
            }
        }
        private void nextButtonPictureBox_MouseEnter(object sender, EventArgs e)//鼠标进入下一道题按钮
        {
            nextButtonPictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "next.png");
        }
        private void nextButtonPictureBox_MouseLeave(object sender, EventArgs e)//鼠标离开下一道题按钮
        {
            nextButtonPictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "next (2).png");
        }
        private void nextButtonPictureBox_Click(object sender, EventArgs e)//点击下一道题按钮
        {
            if (historyForm != null && !historyForm.IsDisposed)
                return;
            scss = 20;
            this.timer.Start();
            if (problemNum == 0) return;
            if (Input.Text == expreesion.GetAnswerString() || Input.Text == "whosyourdaddy")
            {
                correctNum++;
            }
            else wrongNum++;
            problemNum++;
            if (problemNum == 11)
            {
                Number num = new Number(correctNum);
                Number num2 = new Number(wrongNum);
                mainText.Text = "游戏结束" + "\r\n" + "正确个数：" + num.GetString() + " 错误个数：" + num2.GetString();
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"./History.txt", true))
                {
                    file.WriteLine("正确个数：{0} 错误个数：{1}", correctNum, wrongNum);
                }
                startGamePictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "startGame.png");
                correctNum = 0;
                wrongNum = 0;
                problemNum = 0;
            }
            else
            {
                expreesion = new Expression();
                while (expreesion.IsInvalid())
                {
                    expreesion = new Expression();
                }
                mainText.Text = expreesion.GetExpressionString();
            }
        }
        private void dificultModePictureBox_Click(object sender, EventArgs e)//点击困难模式按钮
        {
            if (Expression.GetDifficulty() == Expression.Difficulty.easy)
            {
                Expression.SetDifficulty(Expression.Difficulty.hard);
                dificultModePictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "small_hard.png");
            }
            else
            {
                Expression.SetDifficulty(Expression.Difficulty.easy);
                dificultModePictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "small_easy.png");
            }
        }
        private void powerOpPictureBox_Click(object sender, EventArgs e)//点击乘方运算按钮
        {
            if (Expression.GetIsPowerOp() == Expression.IsPowerOp.no)
            {
                Expression.SetPowerOp(Expression.IsPowerOp.yes);
                powerOpPictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "power_yes.png");
            }
            else
            {
                Expression.SetPowerOp(Expression.IsPowerOp.no);
                powerOpPictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "power_no.png");
            }
        }
        private void printTypePictureBox_Click(object sender, EventArgs e)//点击输出格式按钮
        {
            if (Expression.GetPrintType() == Expression.PowerOpPrintType.caret)
            {
                Expression.SetPrintType(Expression.PowerOpPrintType.doubleStar);
                printTypePictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "doubleStar.png");
            }
            else
            {
                Expression.SetPrintType(Expression.PowerOpPrintType.caret);
                printTypePictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "caret.png");
            }
        }
        private void startGamePictureBox_Click(object sender, EventArgs e)//点击开始游戏按钮
        {
            if (historyForm != null && !historyForm.IsDisposed)
                return;
            scss = 20;
            this.timer.Start();
            startGamePictureBox.Image = Image.FromFile(Application.StartupPath + "\\image\\" + "reStart.png");
            problemNum = 0;
            correctNum = 0;
            wrongNum = 0;
            problemNum++;
            expreesion = new Expression();
            while (expreesion.IsInvalid())
            {
                expreesion = new Expression();
            }
            mainText.Text = expreesion.GetExpressionString();
        }
        private void historyButtonLabel_Click(object sender, EventArgs e)//点击历史纪录按钮
        {
            if (historyForm != null)
            {
                if (historyForm.IsDisposed)
                    historyForm = new HistoryForm();
                historyForm.Show();
                historyForm.Focus();
            }
            else
            {
                historyForm = new HistoryForm();
                historyForm.Show();
                historyForm.Focus();
            }
        }
        private void historyButtonLabel_MouseEnter(object sender, EventArgs e)//鼠标进入历史纪录按钮
        {
            historyButtonLabel.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }
        private void historyButtonLabel_MouseLeave(object sender, EventArgs e)//鼠标离开历史记录按钮
        {
            historyButtonLabel.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }

        static private int problemNum = 0;
        static Expression expreesion;
        static private int correctNum = 0;
        static private int wrongNum = 0;
        private HistoryForm historyForm;
    }
}
