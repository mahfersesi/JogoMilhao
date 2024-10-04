using JogoMilhao;

public class Universitarios : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem=100;
        for (int i=0; i<5;i++)
        {
            int numRand=0;
            if( porcentagem>0)
        {
        switch(i)
        {
            case 0:
            BTNResposta01.Text+="-"+numRand.ToString() + "%";
            break;
            case 1:
            BTNResposta02.Text+="-"+numRand.ToString() + "%";
            break;
             case 2:
            BTNResposta03.Text+="-"+numRand.ToString() + "%";
            break;
             case 3:
            BTNResposta04.Text+="-"+numRand.ToString() + "%";
            break;
             case 4:
            BTNResposta05.Text+="-"+numRand.ToString() + "%";
            break;
        }
        }
        }
    }
}