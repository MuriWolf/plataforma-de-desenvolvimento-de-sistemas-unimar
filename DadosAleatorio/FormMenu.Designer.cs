namespace DadosAleatorio
{
    partial class FormMenu
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
            label1 = new Label();
            label2 = new Label();
            buttonModeDadoViciado = new Button();
            buttonModeDadoNormal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(119, 104);
            label1.Name = "label1";
            label1.Size = new Size(158, 19);
            label1.TabIndex = 0;
            label1.Text = "Escolha a forma de jogo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(98, 50);
            label2.Name = "label2";
            label2.Size = new Size(211, 37);
            label2.TabIndex = 1;
            label2.Text = "Ultra Dice Game";
            // 
            // buttonModeDadoViciado
            // 
            buttonModeDadoViciado.Location = new Point(207, 150);
            buttonModeDadoViciado.Name = "buttonModeDadoViciado";
            buttonModeDadoViciado.Size = new Size(91, 23);
            buttonModeDadoViciado.TabIndex = 2;
            buttonModeDadoViciado.Text = "Dado viciado";
            buttonModeDadoViciado.UseVisualStyleBackColor = true;
            buttonModeDadoViciado.Click += buttonModeDadoViciado_Click;
            // 
            // buttonModeDadoNormal
            // 
            buttonModeDadoNormal.Location = new Point(98, 150);
            buttonModeDadoNormal.Name = "buttonModeDadoNormal";
            buttonModeDadoNormal.Size = new Size(98, 23);
            buttonModeDadoNormal.TabIndex = 3;
            buttonModeDadoNormal.Text = "Dado normal";
            buttonModeDadoNormal.UseVisualStyleBackColor = true;
            buttonModeDadoNormal.Click += buttonModeDadoNormal_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 221);
            Controls.Add(buttonModeDadoNormal);
            Controls.Add(buttonModeDadoViciado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMenu";
            Text = "t";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonModeDadoViciado;
        private Button buttonModeDadoNormal;
    }
}