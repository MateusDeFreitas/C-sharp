namespace FormsEx06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            labelStatus = new Label();
            panel3 = new Panel();
            labelConta = new Label();
            label5 = new Label();
            label4 = new Label();
            labelOperador = new Label();
            textBoxOperador = new TextBox();
            textBoxL1 = new TextBox();
            labelL1 = new Label();
            labelL2 = new Label();
            panel2 = new Panel();
            textBoxL2 = new TextBox();
            buttonCalcular = new Button();
            buttonLimpar = new Button();
            buttonFechar = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(441, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 426);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(labelStatus);
            panel4.Location = new Point(26, 198);
            panel4.Name = "panel4";
            panel4.Size = new Size(296, 210);
            panel4.TabIndex = 2;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F);
            labelStatus.Location = new Point(10, 8);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(18, 21);
            labelStatus.TabIndex = 13;
            labelStatus.Text = "  ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(labelConta);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(26, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 103);
            panel3.TabIndex = 1;
            // 
            // labelConta
            // 
            labelConta.AutoSize = true;
            labelConta.Font = new Font("Segoe UI", 20F);
            labelConta.Location = new Point(10, 10);
            labelConta.Name = "labelConta";
            labelConta.Size = new Size(24, 37);
            labelConta.TabIndex = 12;
            labelConta.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 10);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(4, 4);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 10;
            // 
            // labelOperador
            // 
            labelOperador.AutoSize = true;
            labelOperador.Font = new Font("Segoe UI", 12F);
            labelOperador.Location = new Point(89, 56);
            labelOperador.Name = "labelOperador";
            labelOperador.Size = new Size(132, 21);
            labelOperador.TabIndex = 1;
            labelOperador.Text = "Tipo de operação:";
            // 
            // textBoxOperador
            // 
            textBoxOperador.Location = new Point(227, 54);
            textBoxOperador.Name = "textBoxOperador";
            textBoxOperador.Size = new Size(171, 23);
            textBoxOperador.TabIndex = 2;
            // 
            // textBoxL1
            // 
            textBoxL1.Location = new Point(227, 157);
            textBoxL1.Name = "textBoxL1";
            textBoxL1.Size = new Size(171, 23);
            textBoxL1.TabIndex = 4;
            // 
            // labelL1
            // 
            labelL1.AutoSize = true;
            labelL1.Font = new Font("Segoe UI", 12F);
            labelL1.Location = new Point(21, 159);
            labelL1.Name = "labelL1";
            labelL1.Size = new Size(200, 21);
            labelL1.TabIndex = 3;
            labelL1.Text = "Digite o primeiro elemento:";
            // 
            // labelL2
            // 
            labelL2.AutoSize = true;
            labelL2.Font = new Font("Segoe UI", 12F);
            labelL2.Location = new Point(21, 210);
            labelL2.Name = "labelL2";
            labelL2.Size = new Size(200, 21);
            labelL2.TabIndex = 5;
            labelL2.Text = "Digite o segundo elemento:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(20, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 2);
            panel2.TabIndex = 1;
            // 
            // textBoxL2
            // 
            textBoxL2.Location = new Point(227, 210);
            textBoxL2.Name = "textBoxL2";
            textBoxL2.Size = new Size(171, 23);
            textBoxL2.TabIndex = 6;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(279, 325);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(127, 32);
            buttonCalcular.TabIndex = 7;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(146, 325);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(127, 32);
            buttonLimpar.TabIndex = 8;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonFechar
            // 
            buttonFechar.BackColor = Color.Firebrick;
            buttonFechar.ForeColor = Color.White;
            buttonFechar.Location = new Point(12, 325);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(127, 32);
            buttonFechar.TabIndex = 9;
            buttonFechar.Text = "Fechar";
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFechar);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxL2);
            Controls.Add(panel2);
            Controls.Add(labelL2);
            Controls.Add(textBoxL1);
            Controls.Add(labelL1);
            Controls.Add(textBoxOperador);
            Controls.Add(labelOperador);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelOperador;
        private TextBox textBoxOperador;
        private TextBox textBoxL1;
        private Label labelL1;
        private Label labelL2;
        private Panel panel2;
        private TextBox textBoxL2;
        private Panel panel4;
        private Panel panel3;
        private Label label4;
        private Button buttonCalcular;
        private Button buttonLimpar;
        private Button buttonFechar;
        private Label label5;
        private Label labelStatus;
        private Label labelConta;
    }
}
