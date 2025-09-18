namespace DadosAleatorio
{
    public enum GameMode
    {
        DadoNormal,
        DadoViciado
    }

    public partial class Form1 : Form
    {
        private readonly int[] VALORES_DADO_VICIADO = [1, 2, 3, 4, 5, 6, 6, 6];
        private int pontuacaoPlayer1 = 0;
        private int pontuacaoPlayer2 = 0;
        private GameMode modoJogo;
        
        public Form1(GameMode modoJogo)
        {
            this.modoJogo = modoJogo;
            InitializeComponent();
        }

        private async void buttonGirarDado_Click(object sender, EventArgs e)
        {
            try
            {
                this.pictureBoxDado.Enabled = true;
                int tentativaPlayer1 = Int32.Parse(this.textBoxPlayer1.Text);
                int tentativaPlayer2 = Int32.Parse(this.textBoxPlayer2.Text);

                int resultadoDado = 0;

                if (modoJogo == GameMode.DadoNormal)
                {
                    resultadoDado = new Random().Next(1, 6);
                } else if (modoJogo == GameMode.DadoViciado)
                {
                    int indexViciados = new Random().Next(0, VALORES_DADO_VICIADO.Length - 1);
                    resultadoDado = VALORES_DADO_VICIADO[indexViciados];
                } else
                {
                    throw new Exception("Modo de jogo existente não definido");
                }

                this.buttonGirarDado.Enabled = false;

                // delay para o gif funcionar
                await Task.Delay(1800);
                this.buttonGirarDado.Enabled = true;

                if (resultadoDado == tentativaPlayer1) this.pontuacaoPlayer1++;
                if (resultadoDado == tentativaPlayer2) this.pontuacaoPlayer2++;

                if (this.pontuacaoPlayer1 == 2 || this.pontuacaoPlayer2 == 2) this.buttonGirarDado.Enabled = false;

                if (this.pontuacaoPlayer1 == 2 && this.pontuacaoPlayer2 == 2) this.label4.Text = "Empate";
             
                else if (this.pontuacaoPlayer1 == 2) this.label4.Text = "Vitória do jogador 1";
                
                else if (this.pontuacaoPlayer2 == 2) this.label4.Text = "Vitória do jogador 2";
                
                this.labelPontosPlayer1.Text = this.pontuacaoPlayer1.ToString();
                this.labelPontosPlayer2.Text = this.pontuacaoPlayer2.ToString();

                this.label3.Visible = true;
                this.labelResultadoDado.Text = resultadoDado.ToString();

                this.pictureBoxDado.Enabled = false;
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
