namespace JogoMilhao
{
    public class Questao
    {
        public string Pergunta;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int Respostacorreta;
        public int Nivelresposta;
        private Label Labelpergunta;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;


        public void ConfiguraEstruturaDesenho(Label labelpergunta, Button buttonresposta1, Button buttonresposta2, Button buttonresposta3, Button buttonresposta4, Button buttonresposta5)
        {
            Labelpergunta = labelpergunta;
            Button1 = buttonresposta1;
            Button2 = buttonresposta2;
            Button3 = buttonresposta3;
            Button4 = buttonresposta4;
            Button5 = buttonresposta5;
        }
        public void Desenhar(Label labelpergunta, Button buttonresposta1, Button buttonresposta2, Button buttonresposta3, Button buttonresposta4, Button buttonresposta5)
        {
            Labelpergunta = labelpergunta;
            Button1 = buttonresposta1;
            Button2 = buttonresposta2;
            Button3 = buttonresposta3;
            Button4 = buttonresposta4;
            Button5 = buttonresposta5;
        }
        private Button QualBTN(int RR)
        {
            if (RR==1)
            return Button1;
            else if (RR==2)
            return Button2;
            else if (RR==3)
            return Button3;
            else if (RR==4)
            return Button4;
            else if (RR==5)
            return Button5;
            else 
            return null;
        }
        public bool VerificaResposta(int RR)
        {
            if (RespostaCerta==RR)
            {
                var BTN= QualBTN(RR);
                BTN BackgrounColor=Colors.Green;
                return true;

            }
            else
            {
                var BTNCorreto=QualBTN(RespostaCerta);
                var BTNIncorreto=QualBTN(RR);
                BTNCorreto.BackgrounColor=Colors.Yellow;
                BTNIncorreto.BackgrounColor=Colors.Red;
                return false;
            }
        }

        public Questao()
        {

        }
        public Questao(Label labelpergunta, Button buttonresposta1, Button buttonresposta2, Button buttonresposta3, Button buttonresposta4, Button buttonresposta5)
        {
            Labelpergunta = labelpergunta;
            Button1 = buttonresposta1;
            Button2 = buttonresposta2;
            Button3 = buttonresposta3;
            Button4 = buttonresposta4;
            Button5 = buttonresposta5;
        }




    }
}