using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_Prot_tela1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        double x;
        double y;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0) 
            {
                gbxCapDisp.Visible = false;
                gbxGrau.Visible = false;
                gbxCapInst.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                gbxCapInst.Visible = false;
                gbxGrau.Visible = false;
                gbxCapDisp.Visible = true;
            }
            if(comboBox1.SelectedIndex == 2)
            {
                gbxGrau.Visible = true;
                gbxCapDisp.Visible = false;
                gbxCapInst.Visible = false;

                lblCapInst.Text = Convert.ToString(x);
                lblCapDisp.Text = Convert.ToString(y);

                double grau = (y / x) * 100;
                grau = (double)System.Math.Round(grau, 1);
                lblGrau.Text = Convert.ToString(grau) + "%";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nudDias.Text == "" || nudHoras.Text == "" || nudProd.Text == "")
            {
                Erro();
            }
            else
            {
                double dias = Convert.ToDouble(nudDias.Text);
                double horas = Convert.ToDouble(nudHoras.Text);
                double prod = Convert.ToDouble(nudProd.Text);
                double res = dias * horas * prod;
                lblRes.Text = Convert.ToString(res);
                x = res;

                nudDias.Text = "0";
                nudHoras.Text = "0";
                nudProd.Text = "0";
            }
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            if (nudDias2.Text == "" || nudHoras2.Text == "" || nudTurnos.Text == "")
            {
                Erro();
            }
            else
            {
                double dias2 = Convert.ToDouble(nudDias2.Text);
                double horas2 = Convert.ToDouble(nudHoras2.Text);
                double turno = Convert.ToDouble(nudTurnos.Text);
                double res2 = (dias2 * horas2 * 4) * turno;
                lblRes2.Text = Convert.ToString(res2);
                y = res2;

                nudDias2.Text = "0";
                nudHoras2.Text = "0";
                nudTurnos.Text = "0";
            }
        }

        public void Erro()
        {
            MessageBox.Show("Selecione um valor válido!");
        }
    }
}
