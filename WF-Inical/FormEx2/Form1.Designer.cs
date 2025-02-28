namespace FormEx2
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
            labelNumero = new Label();
            textBoxNumero = new TextBox();
            labelIndicador = new Label();
            labelResposta = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI", 12F);
            labelNumero.Location = new Point(92, 162);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(140, 21);
            labelNumero.TabIndex = 0;
            labelNumero.Text = "Digite um número:";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(328, 164);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(114, 23);
            textBoxNumero.TabIndex = 1;
            // 
            // labelIndicador
            // 
            labelIndicador.AutoSize = true;
            labelIndicador.Font = new Font("Segoe UI", 12F);
            labelIndicador.Location = new Point(92, 240);
            labelIndicador.Name = "labelIndicador";
            labelIndicador.Size = new Size(210, 21);
            labelIndicador.TabIndex = 2;
            labelIndicador.Text = "Esse número é equivalente a:";
            // 
            // labelResposta
            // 
            labelResposta.AutoSize = true;
            labelResposta.Font = new Font("Segoe UI", 12F);
            labelResposta.Location = new Point(328, 240);
            labelResposta.Name = "labelResposta";
            labelResposta.Size = new Size(0, 21);
            labelResposta.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(92, 311);
            button1.Name = "button1";
            button1.Size = new Size(121, 33);
            button1.TabIndex = 4;
            button1.Text = "Processar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelResposta);
            Controls.Add(labelIndicador);
            Controls.Add(textBoxNumero);
            Controls.Add(labelNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumero;
        private TextBox textBoxNumero;
        private Label labelIndicador;
        private Label labelResposta;
        private Button button1;
    }
}
