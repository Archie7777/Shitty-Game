using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            System.IO.StreamReader file = new System.IO.StreamReader(@"./History.txt");
            int count = 0;
            while (!file.EndOfStream)
            {
                count++;
                historyText.Text += count + ":" + file.ReadLine() + "\r\n";
            }
        }
    }
}
