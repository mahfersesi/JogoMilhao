namespace JogoMilhao;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;
    public Gerenciador(Label labelPergunta,Button BTNResposta01,Button BTNResposta02,Button BTNResposta03,Button BTNResposta04, Button BTNResposta05)
    {
        CriarQuestoes(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    }
    void CriarQuestoes(Label labelPergunta,Button BTNResposta01,Button BTNResposta02,Button BTNResposta03,Button BTNResposta04, Button BTNResposta05)
    {
        var Q1 = new Questao();
        Q1.Pergunta = "Quanto é 2+2??????????";
        Q1.Resposta1 = "1";
        Q1.Resposta2 = "13";
        Q1.Resposta3 = "21";
        Q1.Resposta4 = "11";
        Q1.Resposta5 = "4";
        Q1.Respostacorreta = 5;
        Q1.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
        ListaQuestoes.Add(Q1);
        var Q2 = new Questao();
    }
      public void ProximaQuestao()
      {
        var NumRandomico = Random.Shared.Next(0,ListaQuestoes.Count);
        while(ListaQuestoesRespondidas.Contains(NumRandomico))
         NumRandomico = Random.Shared.Next(0, ListaQuestoes.Count);
         ListaQuestoesRespondidas.Add(NumRandomico);
         QuestaoCorrente = ListaQuestoes[NumRandomico];
         QuestaoCorrente.Desenhar();
      }
      public async void VerificaResposta(int rr)
      {
        if(QuestaoCorrente.VerificaResposta(rr))
        {
         await Task.Delay(1000);
         ProximaQuestao();
        }
      }
}