namespace JogoMilhao;
public class RetiraErrada : IAjuda 
{
    public override void RealizaAjuda (Questao questao)
    {
        switch (questao.Respostacorreta)
        {
        
        case 1:
            BTNResposta02.IsVisible = false;
            BTNResposta03.IsVisible = false;
            BTNResposta05.IsVisible = false;
            break;
            case 2:
            BTNResposta01.IsVisible = false;
            BTNResposta03.IsVisible = false;
            BTNResposta04.IsVisible = false;
            break;
            case 3: 
            BTNResposta02.IsVisible = false;
            BTNResposta04.IsVisible = false;
            BTNResposta05.IsVisible = false;
            break;
            case 4:
            BTNResposta02.IsVisible = false;
            BTNResposta01.IsVisible = false;
            BTNResposta04.IsVisible = false;
            break;
            case 5:
            BTNResposta01.IsVisible = false;
            BTNResposta03.IsVisible = false;
            BTNResposta05.IsVisible = false;
            break;
        }
    }
}