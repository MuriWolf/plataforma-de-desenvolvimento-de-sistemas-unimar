namespace DadosAleatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBoxDado = new PictureBox();
            textBoxPlayer1 = new TextBox();
            textBoxPlayer2 = new TextBox();
            buttonGirarDado = new Button();
            labelResultadoDado = new Label();
            label4 = new Label();
            label5 = new Label();
            labelPontosPlayer2 = new Label();
            labelPontosPlayer1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 240);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Jogador 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 240);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Jogador 2";
            // 
            // pictureBoxDado
            // 
            pictureBoxDado.Enabled = false;
            pictureBoxDado.Image = (Image)resources.GetObject("pictureBoxDado.Image");
            pictureBoxDado.Location = new Point(279, 21);
            pictureBoxDado.Name = "pictureBoxDado";
            pictureBoxDado.Size = new Size(147, 136);
            pictureBoxDado.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDado.TabIndex = 2;
            pictureBoxDado.TabStop = false;
            // 
            // textBoxPlayer1
            // 
            textBoxPlayer1.Location = new Point(204, 258);
            textBoxPlayer1.Name = "textBoxPlayer1";
            textBoxPlayer1.Size = new Size(100, 23);
            textBoxPlayer1.TabIndex = 3;
            // 
            // textBoxPlayer2
            // 
            textBoxPlayer2.Location = new Point(391, 258);
            textBoxPlayer2.Name = "textBoxPlayer2";
            textBoxPlayer2.Size = new Size(100, 23);
            textBoxPlayer2.TabIndex = 4;
            // 
            // buttonGirarDado
            // 
            buttonGirarDado.Location = new Point(204, 333);
            buttonGirarDado.Name = "buttonGirarDado";
            buttonGirarDado.Size = new Size(287, 23);
            buttonGirarDado.TabIndex = 5;
            buttonGirarDado.Text = "Girar dado";
            buttonGirarDado.UseVisualStyleBackColor = true;
            buttonGirarDado.Click += buttonGirarDado_Click;
            // 
            // labelResultadoDado
            // 
            labelResultadoDado.AutoSize = true;
            labelResultadoDado.Font = new Font("Segoe UI", 24F);
            labelResultadoDado.Location = new Point(326, 396);
            labelResultadoDado.Name = "labelResultadoDado";
            labelResultadoDado.Size = new Size(0, 45);
            labelResultadoDado.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(253, 172);
            label4.Name = "label4";
            label4.Size = new Size(200, 20);
            label4.TabIndex = 8;
            label4.Text = "Pontuação";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(341, 205);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 9;
            label5.Text = "X";
            // 
            // labelPontosPlayer2
            // 
            labelPontosPlayer2.AutoSize = true;
            labelPontosPlayer2.Font = new Font("Segoe UI", 11F);
            labelPontosPlayer2.Location = new Point(391, 205);
            labelPontosPlayer2.Name = "labelPontosPlayer2";
            labelPontosPlayer2.Size = new Size(17, 20);
            labelPontosPlayer2.TabIndex = 10;
            labelPontosPlayer2.Text = "0";
            // 
            // labelPontosPlayer1
            // 
            labelPontosPlayer1.AutoSize = true;
            labelPontosPlayer1.Font = new Font("Segoe UI", 11F);
            labelPontosPlayer1.Location = new Point(296, 205);
            labelPontosPlayer1.Name = "labelPontosPlayer1";
            labelPontosPlayer1.Size = new Size(17, 20);
            labelPontosPlayer1.TabIndex = 11;
            labelPontosPlayer1.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(305, 368);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 6;
            label3.Text = "Resultado: ";
            label3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 484);
            Controls.Add(labelPontosPlayer1);
            Controls.Add(labelPontosPlayer2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelResultadoDado);
            Controls.Add(label3);
            Controls.Add(buttonGirarDado);
            Controls.Add(textBoxPlayer2);
            Controls.Add(textBoxPlayer1);
            Controls.Add(pictureBoxDado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBoxDado;
        private TextBox textBoxPlayer1;
        private TextBox textBoxPlayer2;
        private Button buttonGirarDado;
        private Label labelResultadoDado;
        private Label label4;
        private Label label5;
        private Label labelPontosPlayer2;
        private Label labelPontosPlayer1;
        private Label label3;
    }
}
