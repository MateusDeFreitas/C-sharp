namespace FormsEx03
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
            labelN1 = new Label();
            labelN2 = new Label();
            textBoxN1 = new TextBox();
            textBoxN2 = new TextBox();
            buttonCalcular = new Button();
            textBoxN3 = new TextBox();
            labelN3 = new Label();
            labelResultado = new Label();
            labelApresentar = new Label();
            SuspendLayout();
            // 
            // labelN1
            // 
            labelN1.AutoSize = true;
            labelN1.Font = new Font("Segoe UI", 12F);
            labelN1.Location = new Point(80, 104);
            labelN1.Name = "labelN1";
            labelN1.Size = new Size(140, 21);
            labelN1.TabIndex = 0;
            labelN1.Text = "Digite um número:";
            // 
            // labelN2
            // 
            labelN2.AutoSize = true;
            labelN2.Font = new Font("Segoe UI", 12F);
            labelN2.Location = new Point(80, 162);
            labelN2.Name = "labelN2";
            labelN2.Size = new Size(155, 21);
            labelN2.TabIndex = 1;
            labelN2.Text = "Digite outro número:";
            // 
            // textBoxN1
            // 
            textBoxN1.Location = new Point(263, 106);
            textBoxN1.Name = "textBoxN1";
            textBoxN1.Size = new Size(127, 23);
            textBoxN1.TabIndex = 2;
            // 
            // textBoxN2
            // 
            textBoxN2.Location = new Point(263, 160);
            textBoxN2.Name = "textBoxN2";
            textBoxN2.Size = new Size(127, 23);
            textBoxN2.TabIndex = 3;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Font = new Font("Segoe UI", 12F);
            buttonCalcular.Location = new Point(80, 322);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(82, 36);
            buttonCalcular.TabIndex = 4;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // textBoxN3
            // 
            textBoxN3.Location = new Point(263, 215);
            textBoxN3.Name = "textBoxN3";
            textBoxN3.Size = new Size(127, 23);
            textBoxN3.TabIndex = 6;
            // 
            // labelN3
            // 
            labelN3.AutoSize = true;
            labelN3.Font = new Font("Segoe UI", 12F);
            labelN3.Location = new Point(80, 215);
            labelN3.Name = "labelN3";
            labelN3.Size = new Size(177, 21);
            labelN3.TabIndex = 5;
            labelN3.Text = "Digite mais um número:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 12F);
            labelResultado.Location = new Point(458, 104);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(82, 21);
            labelResultado.TabIndex = 7;
            labelResultado.Text = "Resultado:";
            // 
            // labelApresentar
            // 
            labelApresentar.AutoSize = true;
            labelApresentar.Font = new Font("Segoe UI", 12F);
            labelApresentar.Location = new Point(458, 158);
            labelApresentar.Name = "labelApresentar";
            labelApresentar.Size = new Size(0, 21);
            labelApresentar.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelApresentar);
            Controls.Add(labelResultado);
            Controls.Add(textBoxN3);
            Controls.Add(labelN3);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxN2);
            Controls.Add(textBoxN1);
            Controls.Add(labelN2);
            Controls.Add(labelN1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelN1;
        private Label labelN2;
        private TextBox textBoxN1;
        private TextBox textBoxN2;
        private Button buttonCalcular;
        private TextBox textBoxN3;
        private Label labelN3;
        private Label labelResultado;
        private Label labelApresentar;
    }
}
