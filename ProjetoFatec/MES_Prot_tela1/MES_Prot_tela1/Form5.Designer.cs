﻿namespace MES_Prot_tela1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbxCapInst = new System.Windows.Forms.GroupBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.nudProd = new System.Windows.Forms.NumericUpDown();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCapDisp = new System.Windows.Forms.GroupBox();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.nudDias2 = new System.Windows.Forms.NumericUpDown();
            this.nudHoras2 = new System.Windows.Forms.NumericUpDown();
            this.nudTurnos = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxGrau = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCapInst = new System.Windows.Forms.Label();
            this.lblCapDisp = new System.Windows.Forms.Label();
            this.lblGrau = new System.Windows.Forms.Label();
            this.gbxCapInst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.gbxCapDisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnos)).BeginInit();
            this.gbxGrau.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADICIONAR";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Capacidade Instalada",
            "Capacidade Disponível",
            "Grau de Disponibilidade"});
            this.comboBox1.Location = new System.Drawing.Point(84, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbxCapInst
            // 
            this.gbxCapInst.Controls.Add(this.lblRes);
            this.gbxCapInst.Controls.Add(this.nudProd);
            this.gbxCapInst.Controls.Add(this.nudHoras);
            this.gbxCapInst.Controls.Add(this.nudDias);
            this.gbxCapInst.Controls.Add(this.btnCalcular1);
            this.gbxCapInst.Controls.Add(this.lblResultado);
            this.gbxCapInst.Controls.Add(this.label5);
            this.gbxCapInst.Controls.Add(this.label4);
            this.gbxCapInst.Controls.Add(this.label2);
            this.gbxCapInst.Location = new System.Drawing.Point(13, 33);
            this.gbxCapInst.Name = "gbxCapInst";
            this.gbxCapInst.Size = new System.Drawing.Size(362, 189);
            this.gbxCapInst.TabIndex = 2;
            this.gbxCapInst.TabStop = false;
            this.gbxCapInst.Visible = false;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(84, 140);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(14, 16);
            this.lblRes.TabIndex = 11;
            this.lblRes.Text = "0";
            // 
            // nudProd
            // 
            this.nudProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudProd.Location = new System.Drawing.Point(159, 89);
            this.nudProd.Name = "nudProd";
            this.nudProd.Size = new System.Drawing.Size(178, 20);
            this.nudProd.TabIndex = 10;
            // 
            // nudHoras
            // 
            this.nudHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHoras.Location = new System.Drawing.Point(101, 53);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(236, 20);
            this.nudHoras.TabIndex = 9;
            // 
            // nudDias
            // 
            this.nudDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDias.Location = new System.Drawing.Point(217, 16);
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(120, 20);
            this.nudDias.TabIndex = 8;
            // 
            // btnCalcular1
            // 
            this.btnCalcular1.Location = new System.Drawing.Point(262, 127);
            this.btnCalcular1.Name = "btnCalcular1";
            this.btnCalcular1.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular1.TabIndex = 7;
            this.btnCalcular1.Text = "Calcular";
            this.btnCalcular1.UseVisualStyleBackColor = true;
            this.btnCalcular1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(9, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 16);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Produtividade por hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Horas por dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dias Trabalhados (mensalmente):";
            // 
            // gbxCapDisp
            // 
            this.gbxCapDisp.Controls.Add(this.lblRes2);
            this.gbxCapDisp.Controls.Add(this.nudDias2);
            this.gbxCapDisp.Controls.Add(this.nudHoras2);
            this.gbxCapDisp.Controls.Add(this.nudTurnos);
            this.gbxCapDisp.Controls.Add(this.btnCalcular2);
            this.gbxCapDisp.Controls.Add(this.label6);
            this.gbxCapDisp.Controls.Add(this.label7);
            this.gbxCapDisp.Controls.Add(this.label8);
            this.gbxCapDisp.Controls.Add(this.label9);
            this.gbxCapDisp.Location = new System.Drawing.Point(12, 33);
            this.gbxCapDisp.Name = "gbxCapDisp";
            this.gbxCapDisp.Size = new System.Drawing.Size(363, 189);
            this.gbxCapDisp.TabIndex = 12;
            this.gbxCapDisp.TabStop = false;
            this.gbxCapDisp.Visible = false;
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes2.Location = new System.Drawing.Point(84, 140);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(14, 16);
            this.lblRes2.TabIndex = 11;
            this.lblRes2.Text = "0";
            // 
            // nudDias2
            // 
            this.nudDias2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDias2.Location = new System.Drawing.Point(125, 89);
            this.nudDias2.Name = "nudDias2";
            this.nudDias2.Size = new System.Drawing.Size(212, 20);
            this.nudDias2.TabIndex = 10;
            // 
            // nudHoras2
            // 
            this.nudHoras2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHoras2.Location = new System.Drawing.Point(114, 53);
            this.nudHoras2.Name = "nudHoras2";
            this.nudHoras2.Size = new System.Drawing.Size(223, 20);
            this.nudHoras2.TabIndex = 9;
            // 
            // nudTurnos
            // 
            this.nudTurnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTurnos.Location = new System.Drawing.Point(114, 16);
            this.nudTurnos.Name = "nudTurnos";
            this.nudTurnos.Size = new System.Drawing.Size(223, 20);
            this.nudTurnos.TabIndex = 8;
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(263, 127);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular2.TabIndex = 7;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Resultado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dias por semana:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Horas por turno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Turnos Diários:";
            // 
            // gbxGrau
            // 
            this.gbxGrau.Controls.Add(this.lblGrau);
            this.gbxGrau.Controls.Add(this.lblCapDisp);
            this.gbxGrau.Controls.Add(this.lblCapInst);
            this.gbxGrau.Controls.Add(this.label11);
            this.gbxGrau.Controls.Add(this.label12);
            this.gbxGrau.Controls.Add(this.label13);
            this.gbxGrau.Location = new System.Drawing.Point(12, 33);
            this.gbxGrau.Name = "gbxGrau";
            this.gbxGrau.Size = new System.Drawing.Size(363, 189);
            this.gbxGrau.TabIndex = 13;
            this.gbxGrau.TabStop = false;
            this.gbxGrau.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Grau de Disponibilidade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Capacidade Disponível:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Capacidade Instalada:";
            // 
            // lblCapInst
            // 
            this.lblCapInst.AutoSize = true;
            this.lblCapInst.Location = new System.Drawing.Point(177, 16);
            this.lblCapInst.Name = "lblCapInst";
            this.lblCapInst.Size = new System.Drawing.Size(20, 13);
            this.lblCapInst.TabIndex = 5;
            this.lblCapInst.Text = "sla";
            // 
            // lblCapDisp
            // 
            this.lblCapDisp.AutoSize = true;
            this.lblCapDisp.Location = new System.Drawing.Point(177, 55);
            this.lblCapDisp.Name = "lblCapDisp";
            this.lblCapDisp.Size = new System.Drawing.Size(20, 13);
            this.lblCapDisp.TabIndex = 6;
            this.lblCapDisp.Text = "sla";
            // 
            // lblGrau
            // 
            this.lblGrau.AutoSize = true;
            this.lblGrau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrau.Location = new System.Drawing.Point(177, 105);
            this.lblGrau.Name = "lblGrau";
            this.lblGrau.Size = new System.Drawing.Size(27, 18);
            this.lblGrau.TabIndex = 7;
            this.lblGrau.Text = "sla";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 244);
            this.Controls.Add(this.gbxGrau);
            this.Controls.Add(this.gbxCapDisp);
            this.Controls.Add(this.gbxCapInst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.gbxCapInst.ResumeLayout(false);
            this.gbxCapInst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.gbxCapDisp.ResumeLayout(false);
            this.gbxCapDisp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTurnos)).EndInit();
            this.gbxGrau.ResumeLayout(false);
            this.gbxGrau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbxCapInst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudProd;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.GroupBox gbxCapDisp;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.NumericUpDown nudDias2;
        private System.Windows.Forms.NumericUpDown nudHoras2;
        private System.Windows.Forms.NumericUpDown nudTurnos;
        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxGrau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGrau;
        private System.Windows.Forms.Label lblCapDisp;
        private System.Windows.Forms.Label lblCapInst;
    }
}