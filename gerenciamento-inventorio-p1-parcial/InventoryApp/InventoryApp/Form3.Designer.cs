namespace InventoryApp
{
    partial class Form3
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
            label4 = new Label();
            btnRemover = new Button();
            dataGridView1 = new DataGridView();
            nome = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 24;
            label4.Text = "Remover produto";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(218, 223);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(145, 23);
            btnRemover.TabIndex = 23;
            btnRemover.Text = "Remover selecionado";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nome, preco, quantidade });
            dataGridView1.Location = new Point(20, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 150);
            dataGridView1.TabIndex = 25;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            // 
            // preco
            // 
            preco.HeaderText = "Preco";
            preco.Name = "preco";
            // 
            // quantidade
            // 
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 264);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(btnRemover);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnRemover;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn quantidade;
    }
}