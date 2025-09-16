namespace InventoryApp
{
    partial class Form4
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
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            labelTotalProdutosEstoque = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 150);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(19, 20);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 27;
            label4.Text = "Listagem de produtos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 67);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 29;
            label1.Text = "Total produtos em estoque: ";
            label1.Click += label1_Click;
            // 
            // labelTotalProdutosEstoque
            // 
            labelTotalProdutosEstoque.AutoSize = true;
            labelTotalProdutosEstoque.Location = new Point(184, 67);
            labelTotalProdutosEstoque.Name = "labelTotalProdutosEstoque";
            labelTotalProdutosEstoque.Size = new Size(0, 15);
            labelTotalProdutosEstoque.TabIndex = 30;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 272);
            Controls.Add(labelTotalProdutosEstoque);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Label label1;
        private Label labelTotalProdutosEstoque;

    }
}