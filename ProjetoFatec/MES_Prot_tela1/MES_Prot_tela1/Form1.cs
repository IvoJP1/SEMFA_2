﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MES_Prot_tela1
{
    public partial class Form1 : Form
    {
        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Morenor" && textBox2.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else if (textBox1.Text == "adm" && textBox2.Text == "adm")
            {
                this.Close();
                nt = new Thread(novoForm2);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

        private void novoForm2()
        {
            Application.Run(new Form3());
        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }
    }
}
