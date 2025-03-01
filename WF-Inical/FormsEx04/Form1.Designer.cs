namespace FormsEx04
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
            labelNome = new Label();
            textBoxNome = new TextBox();
            textBoxHS = new TextBox();
            labelSalarioHora = new Label();
            textBoxHM = new TextBox();
            labelHorasMes = new Label();
            labelSM = new Label();
            labelResultado = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F);
            labelNome.Location = new Point(102, 108);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(60, 21);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome: ";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(223, 108);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(126, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxHS
            // 
            textBoxHS.Location = new Point(223, 160);
            textBoxHS.Name = "textBoxHS";
            textBoxHS.Size = new Size(126, 23);
            textBoxHS.TabIndex = 3;
            // 
            // labelSalarioHora
            // 
            labelSalarioHora.AutoSize = true;
            labelSalarioHora.Font = new Font("Segoe UI", 12F);
            labelSalarioHora.Location = new Point(102, 160);
            labelSalarioHora.Name = "labelSalarioHora";
            labelSalarioHora.Size = new Size(101, 21);
            labelSalarioHora.TabIndex = 2;
            labelSalarioHora.Text = "Hora salário: ";
            // 
            // textBoxHM
            // 
            textBoxHM.Location = new Point(223, 218);
            textBoxHM.Name = "textBoxHM";
            textBoxHM.Size = new Size(126, 23);
            textBoxHM.TabIndex = 5;
            // 
            // labelHorasMes
            // 
            labelHorasMes.AutoSize = true;
            labelHorasMes.Font = new Font("Segoe UI", 12F);
            labelHorasMes.Location = new Point(102, 218);
            labelHorasMes.Name = "labelHorasMes";
            labelHorasMes.Size = new Size(115, 21);
            labelHorasMes.TabIndex = 4;
            labelHorasMes.Text = "Horas por mes:";
            // 
            // labelSM
            // 
            labelSM.AutoSize = true;
            labelSM.Font = new Font("Segoe UI", 12F);
            labelSM.Location = new Point(454, 106);
            labelSM.Name = "labelSM";
            labelSM.Size = new Size(115, 21);
            labelSM.TabIndex = 6;
            labelSM.Text = "Salário mensal:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 12F);
            labelResultado.Location = new Point(454, 158);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 21);
            labelResultado.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Font = new Font("Segoe UI", 12F);
            buttonCalcular.Location = new Point(102, 315);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(115, 41);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalcular);
            Controls.Add(labelResultado);
            Controls.Add(labelSM);
            Controls.Add(textBoxHM);
            Controls.Add(labelHorasMes);
            Controls.Add(textBoxHS);
            Controls.Add(labelSalarioHora);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private TextBox textBoxHS;
        private Label labelSalarioHora;
        private TextBox textBoxHM;
        private Label labelHorasMes;
        private Label labelSM;
        private Label labelResultado;
        private Button buttonCalcular;
    }
}
