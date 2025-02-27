namespace WF_Inical
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
            textBoxN1 = new TextBox();
            buttonCalcular = new Button();
            label2 = new Label();
            textBoxN2 = new TextBox();
            labelN2 = new Label();
            labelMedia = new Label();
            labelSituacao = new Label();
            labelMediaResultado = new Label();
            labelSituacaoResultado = new Label();
            SuspendLayout();
            // 
            // labelN1
            // 
            labelN1.AutoSize = true;
            labelN1.Font = new Font("Segoe UI", 12F);
            labelN1.Location = new Point(132, 182);
            labelN1.Name = "labelN1";
            labelN1.Size = new Size(99, 21);
            labelN1.TabIndex = 0;
            labelN1.Text = "Primeir nota:";
            // 
            // textBoxN1
            // 
            textBoxN1.Location = new Point(237, 182);
            textBoxN1.Name = "textBoxN1";
            textBoxN1.Size = new Size(130, 23);
            textBoxN1.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(357, 338);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(114, 31);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(285, 56);
            label2.Name = "label2";
            label2.Size = new Size(223, 37);
            label2.TabIndex = 3;
            label2.Text = "Calculo de média";
            // 
            // textBoxN2
            // 
            textBoxN2.Location = new Point(237, 238);
            textBoxN2.Name = "textBoxN2";
            textBoxN2.Size = new Size(130, 23);
            textBoxN2.TabIndex = 5;
            // 
            // labelN2
            // 
            labelN2.AutoSize = true;
            labelN2.Font = new Font("Segoe UI", 12F);
            labelN2.Location = new Point(124, 236);
            labelN2.Name = "labelN2";
            labelN2.Size = new Size(109, 21);
            labelN2.TabIndex = 4;
            labelN2.Text = "Segunda nota:";
            // 
            // labelMedia
            // 
            labelMedia.AutoSize = true;
            labelMedia.Font = new Font("Segoe UI", 12F);
            labelMedia.Location = new Point(465, 179);
            labelMedia.Name = "labelMedia";
            labelMedia.Size = new Size(56, 21);
            labelMedia.TabIndex = 6;
            labelMedia.Text = "Média:";
            // 
            // labelSituacao
            // 
            labelSituacao.AutoSize = true;
            labelSituacao.Font = new Font("Segoe UI", 12F);
            labelSituacao.Location = new Point(465, 236);
            labelSituacao.Name = "labelSituacao";
            labelSituacao.Size = new Size(76, 21);
            labelSituacao.TabIndex = 7;
            labelSituacao.Text = "Situação: ";
            // 
            // labelMediaResultado
            // 
            labelMediaResultado.AutoSize = true;
            labelMediaResultado.Font = new Font("Segoe UI", 12F);
            labelMediaResultado.Location = new Point(523, 179);
            labelMediaResultado.Name = "labelMediaResultado";
            labelMediaResultado.Size = new Size(31, 21);
            labelMediaResultado.TabIndex = 8;
            labelMediaResultado.Text = "0.0";
            // 
            // labelSituacaoResultado
            // 
            labelSituacaoResultado.AutoSize = true;
            labelSituacaoResultado.Font = new Font("Segoe UI", 12F);
            labelSituacaoResultado.Location = new Point(538, 236);
            labelSituacaoResultado.Name = "labelSituacaoResultado";
            labelSituacaoResultado.Size = new Size(74, 21);
            labelSituacaoResultado.TabIndex = 9;
            labelSituacaoResultado.Text = "Em curso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSituacaoResultado);
            Controls.Add(labelMediaResultado);
            Controls.Add(labelSituacao);
            Controls.Add(labelMedia);
            Controls.Add(textBoxN2);
            Controls.Add(labelN2);
            Controls.Add(label2);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxN1);
            Controls.Add(labelN1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelN1;
        private TextBox textBoxN1;
        private Button buttonCalcular;
        private Label label2;
        private TextBox textBoxN2;
        private Label labelN2;
        private Label labelMedia;
        private Label labelSituacao;
        private Label labelMediaResultado;
        private Label labelSituacaoResultado;
    }
}
