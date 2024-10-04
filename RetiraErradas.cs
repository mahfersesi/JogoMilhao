namespace JogoMilhao;
public class RetiraErradas : IAjuda 
{
    public void RealizaAjuda (Questao questao)
    {
        switch(questao RespostaCorreta)
        {
        case 1:
            BTNResposta02 = false;
            BTNResposta03 = false;
            BTNResposta05 = false;
            break;
            case 2:
            BTNResposta01 = false;
            BTNResposta03 = false;
            BTNResposta04 = false;
            break;
            case 3: 
            BTNResposta02 = false;
            BTNResposta04 = false;
            BTNResposta05 = false;
            break;
            case 4:
            BTNResposta02 = false;
            BTNResposta01 = false;
            BTNResposta04 = false;
            break;
            case 5:
            BTNResposta01 = false;
            BTNResposta03 = false;
            BTNResposta05 = false;
            break;
        }
    }
}