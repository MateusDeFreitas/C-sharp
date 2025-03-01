namespace FormsEx05
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
            labelNP = new Label();
            labelPP = new Label();
            textBoxNome = new TextBox();
            textBoxPreco = new TextBox();
            button1 = new Button();
            buttonExibir = new Button();
            labelPPC = new Label();
            labelNPC = new Label();
            labelPrecoResultado = new Label();
            labelNomeResultado = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // labelNP
            // 
            labelNP.AutoSize = true;
            labelNP.Font = new Font("Segoe UI", 12F);
            labelNP.Location = new Point(72, 78);
            labelNP.Name = "labelNP";
            labelNP.Size = new Size(138, 21);
            labelNP.TabIndex = 0;
            labelNP.Text = "Nome do produto:";
            // 
            // labelPP
            // 
            labelPP.AutoSize = true;
            labelPP.Font = new Font("Segoe UI", 12F);
            labelPP.Location = new Point(76, 147);
            labelPP.Name = "labelPP";
            labelPP.Size = new Size(134, 21);
            labelPP.TabIndex = 1;
            labelPP.Text = "Preço do produto:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(246, 80);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(163, 23);
            textBoxNome.TabIndex = 2;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(246, 149);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(163, 23);
            textBoxPreco.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(76, 209);
            button1.Name = "button1";
            button1.Size = new Size(121, 38);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonExibir
            // 
            buttonExibir.Font = new Font("Segoe UI", 12F);
            buttonExibir.Location = new Point(288, 209);
            buttonExibir.Name = "buttonExibir";
            buttonExibir.Size = new Size(121, 38);
            buttonExibir.TabIndex = 5;
            buttonExibir.Text = "Exibir";
            buttonExibir.UseVisualStyleBackColor = true;
            buttonExibir.Click += buttonExibir_Click;
            // 
            // labelPPC
            // 
            labelPPC.AutoSize = true;
            labelPPC.Font = new Font("Segoe UI", 12F);
            labelPPC.Location = new Point(72, 361);
            labelPPC.Name = "labelPPC";
            labelPPC.Size = new Size(205, 21);
            labelPPC.TabIndex = 7;
            labelPPC.Text = "Preço do produto mais caro:";
            // 
            // labelNPC
            // 
            labelNPC.AutoSize = true;
            labelNPC.Font = new Font("Segoe UI", 12F);
            labelNPC.Location = new Point(72, 293);
            labelNPC.Name = "labelNPC";
            labelNPC.Size = new Size(209, 21);
            labelNPC.TabIndex = 6;
            labelNPC.Text = "Nome do produto mais caro:";
            // 
            // labelPrecoResultado
            // 
            labelPrecoResultado.AutoSize = true;
            labelPrecoResultado.Font = new Font("Segoe UI", 12F);
            labelPrecoResultado.Location = new Point(315, 361);
            labelPrecoResultado.Name = "labelPrecoResultado";
            labelPrecoResultado.Size = new Size(0, 21);
            labelPrecoResultado.TabIndex = 9;
            // 
            // labelNomeResultado
            // 
            labelNomeResultado.AutoSize = true;
            labelNomeResultado.Font = new Font("Segoe UI", 12F);
            labelNomeResultado.Location = new Point(315, 293);
            labelNomeResultado.Name = "labelNomeResultado";
            labelNomeResultado.Size = new Size(0, 21);
            labelNomeResultado.TabIndex = 8;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F);
            labelStatus.Location = new Point(497, 82);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 21);
            labelStatus.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelStatus);
            Controls.Add(labelPrecoResultado);
            Controls.Add(labelNomeResultado);
            Controls.Add(labelPPC);
            Controls.Add(labelNPC);
            Controls.Add(buttonExibir);
            Controls.Add(button1);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxNome);
            Controls.Add(labelPP);
            Controls.Add(labelNP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNP;
        private Label labelPP;
        private TextBox textBoxNome;
        private TextBox textBoxPreco;
        private Button button1;
        private Button buttonExibir;
        private Label labelPPC;
        private Label labelNPC;
        private Label labelPrecoResultado;
        private Label labelNomeResultado;
        private Label labelStatus;
    }
}
