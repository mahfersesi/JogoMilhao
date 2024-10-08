namespace JogoMilhao;

public partial class MainPage : ContentPage
{
	int count = 0;
  int Pula=0;
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
  private void AjudaTirarBTN(object sender, EventArgs e)
	{
     
      var ajuda = new RetiraErrada();
      ajuda.ConfiguraEstruturaDesenho(btnResposta01,btnResposta02,btnResposta03,btnResposta04,btnResposta05);
      ajuda.RealizaAjuda(gerenciador.GetAtualQuestao());
      (sender as Button).IsVisible = false;
    

	}

	private async void Pulabutton(object sender, EventArgs e)
	{
    if (Pula==2)
    (sender as Button).IsVisible = false;
    else
    {
		gerenciador.ProximaQuestao();
		Pula++;
    }
    BTNPular.text="Pula"+(3-Pula)+"*";
	}

	private void genios(object sender, EventArgs e)
	{
    
		var ajuda = new Universitarios();
		ajuda.ConfiguraEstruturaDesenho(btnResposta01,btnResposta02,btnResposta03,btnResposta04,btnResposta05);
    ajuda.RealizaAjuda(gerenciador.GetAtualQuestao());
    (sender as Button).IsVisible = false;
    
	}
}

	


