namespace JogoMilhao;

public partial class MainPage : ContentPage
{
	int count = 0;
	Gerenciador gerenciador;
	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelpergunta, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05,labelNivel,labelPontuacao);
    gerenciador.ProximaQuestao();
	}

	 private void OnBtnResposta01Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(1);
  }

  private void OnBtnResposta02Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(2);
  }

  private void OnBtnResposta03Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(3);
  }

  private void OnBtnResposta04Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(4);
  }

  private void OnBtnResposta05Clicked(object sender, EventArgs e)
  {
    gerenciador!.VerificaResposta(5);
  }
  void AjudaTirarBTN(object sender, EventArgs e)
	{
		
	}

	void Pulabutton(object sender, EventArgs e)
	{
		gerenciador.ProximaQuestao();
		(sender as Button).IsVisible = false;

	}

	void genios(object sender, EventArgs e)
	{
		var inteligentes = new Universitarios();
		inteligentes.ConfiguraEstruturaDesenho;
	}
}

	


