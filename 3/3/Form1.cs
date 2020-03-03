using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        Queue<string> personer = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNykund_Click(object sender, EventArgs e)
        {
            string namn = tbxsist.Text;
            personer.Enqueue(namn);

        }

        private void BtnExpe_Click(object sender, EventArgs e)
        {
            tbxförst.Text = personer.Dequeue() + " har expedierats";

            if(personer.Count == 0)
            {
                tbxförst.Text = "Ingen här?!?";
            }
        }
    }
}
