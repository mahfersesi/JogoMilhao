namespace JogoMilhao;

public abstract class IAjuda
{
    protected Button BTNResposta01;
    protected Button BTNResposta02;
    protected Button BTNResposta03;
    protected Button BTNResposta04;
    protected Button BTNResposta05;
    protected Frame FrameAjuda;

 
 public void ConfiguraDesenho(Button BTNResposta01,Button BTNResposta02,Button BTNResposta03,Button BTNResposta04, Button BTNResposta05)
 {
    this.BTNResposta01 = BTNResposta01;
    this.BTNResposta02 = BTNResposta02;
    this.BTNResposta03 = BTNResposta03;
    this.BTNResposta04 = BTNResposta04;
    this.BTNResposta05 = BTNResposta05;
 }
 public void ConfiguraDesenho(Frame frameAjuda)
 {
    this.FrameAjuda = frameAjuda;
 }
 public abstract void RealizaAjuda(Questao questao);
}