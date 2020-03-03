﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning132
{
    public partial class Form1 : Form
    {
        Stack<string> bokstäver = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btnkontroll_Click(object sender, EventArgs e)
        {
            //string[] ord = new string[tbxord.Text.Length];
            string ord = tbxord.Text;
            string omväntord = "";

            for(int i = 0; i < tbxord.Text.Length; i++)
            {
                bokstäver.Push(ord[i].ToString());
                omväntord += bokstäver.Pop();
            }

            //for(int i = 0; i < tbxord.Text.Length; i++)
            //{
                
            //}

            if(omväntord == ord)
            {
                tbxres.Text = ord + " är en palindrom";
            }
            else
            {
                 tbxres.Text = ord + " är inte en palindrom";

            }
        }
    }
}
