using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_2
{
    public partial class Form1 : Form

        
    {   Stack<string> städer = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPush_Click(object sender, EventArgs e)
        {
            string stad = tbxStad.Text;
            städer.Push(stad);
            tbxin.AppendText(stad + "\r\n");
            tbxStad.Text = "";

        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            while(städer.Count != 0)
            {
                string stad = städer.Pop();
                tbxut.AppendText (stad + "\r\n");
            }
        }
    }
}
