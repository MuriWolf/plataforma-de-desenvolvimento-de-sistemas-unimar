namespace InventoryApp
{
    partial class Form2
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
            textBoxQuantidade = new TextBox();
            label3 = new Label();
            textBoxPreco = new TextBox();
            label2 = new Label();
            textBoxNome = new TextBox();
            label1 = new Label();
            btnAdicionar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(99, 154);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(226, 23);
            textBoxQuantidade.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 157);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 13;
            label3.Text = "Quantidade";
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(99, 107);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(226, 23);
            textBoxPreco.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 110);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 11;
            label2.Text = "Preco";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(99, 62);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(226, 23);
            textBoxNome.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 65);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(250, 211);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 15;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 19);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 16;
            label4.Text = "Adicionar produto";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 257);
            Controls.Add(label4);
            Controls.Add(btnAdicionar);
            Controls.Add(textBoxQuantidade);
            Controls.Add(label3);
            Controls.Add(textBoxPreco);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxQuantidade;
        private Label label3;
        private TextBox textBoxPreco;
        private Label label2;
        private TextBox textBoxNome;
        private Label label1;
        private Button btnAdicionar;
        private Label label4;
    }
}