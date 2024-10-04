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
  void AjudaTirarBTN(object creu, EventArgs e)
	{
		var ajuda = new RetiradaErradas();
		ajuda.ConfiguraDesenho(Resposta1, Resposta2, Resposta3, Resposta4, Resposta5);
		ajuda.RealizarAjuda(gerenciador.GetQuestaoAtual());
		(creu as Button).IsVisible = false;
	}

	void Pulabutton(object creu, EventArgs e)
	{
		gerenciador.ProximaQuestao();
		(creu as Button).IsVisible = false;
	}

	void universitarios(object creu, EventArgs e)
	{
		var burros = new Universitarios();
		burros.ConfiguraDesenho;
	}
}

	


