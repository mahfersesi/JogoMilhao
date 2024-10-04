namespace JogoMilhao;

public class Gerenciador
{
    
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
     public int Pontuacao{ get; private set; }
     int NivelResposta = 0;
    Label labelPontuacao;
    Label labelNivel;
    Questao QuestaoAtual;

    void Initialize()
    {
        Pontuacao = 0;
        NivelResposta = 0;
        ProximaQuestao();
    }
    public Gerenciador(Label labelPergunta,Button BTNResposta01,Button BTNResposta02,Button BTNResposta03,Button BTNResposta04, Button BTNResposta05,Label labelPontuacao,Label labelNivel)
    {
        CriarQuestoes(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
       this.labelNivel = labelNivel;
        this.labelPontuacao = labelPontuacao;
    }
    void CriarQuestoes(Label labelPergunta, Button BTNResposta01, Button BTNResposta02, Button BTNResposta03, Button BTNResposta04, Button BTNResposta05)
{

    var Q1 = new Questao();

     Q1.NivelResposta = 1;

    Q1.Pergunta = "Quanto é 2 + 2?";
    Q1.Resposta1 = "1";
    Q1.Resposta2 = "2";
    Q1.Resposta3 = "3";
    Q1.Resposta4 = "4";
    Q1.Resposta5 = "5";
    Q1.Respostacorreta = 4;
    Q1.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q1);
    
    // Pergunta 2
    var Q2 = new Questao();
    Q2.Pergunta = "Qual é a capital da França?";
    Q2.Resposta1 = "Berlim";
    Q2.Resposta2 = "Madri";
    Q2.Resposta3 = "Paris";
    Q2.Resposta4 = "Londres";
    Q2.Resposta5 = "Roma";
    Q2.Respostacorreta = 3;
    Q2.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q2);
    
    // Pergunta 3
    var Q3 = new Questao();
    Q3.Pergunta = "Quantos planetas existem no sistema solar?";
    Q3.Resposta1 = "7";
    Q3.Resposta2 = "8";
    Q3.Resposta3 = "9";
    Q3.Resposta4 = "10";
    Q3.Resposta5 = "11";
    Q3.Respostacorreta = 2;
    Q3.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q3);
    
    // Pergunta 4
    var Q4 = new Questao();
    Q4.Pergunta = "Qual é o maior mamífero do mundo?";
    Q4.Resposta1 = "Elefante";
    Q4.Resposta2 = "Baleia Azul";
    Q4.Resposta3 = "Girafa";
    Q4.Resposta4 = "Orca";
    Q4.Resposta5 = "Urso Polar";
    Q4.Respostacorreta = 2;
    Q4.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q4);
    
    // Pergunta 5
    var Q5 = new Questao();
    Q5.Pergunta = "Qual é a fórmula da água?";

     Q5.NivelResposta = 1;

    Q5.Resposta1 = "CO2";
    Q5.Resposta2 = "H2O";
    Q5.Resposta3 = "O2";
    Q5.Resposta4 = "H2O2";
    Q5.Resposta5 = "HO2";
    Q5.Respostacorreta = 2;
    Q5.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q5);
    
    // Pergunta 6
    var Q6 = new Questao();
    Q6.Pergunta = "Quem escreveu 'Dom Casmurro'?";
    Q6.Resposta1 = "Machado de Assis";
    Q6.Resposta2 = "José de Alencar";
    Q6.Resposta3 = "Clarice Lispector";
    Q6.Resposta4 = "Jorge Amado";
    Q6.Resposta5 = "Guimarães Rosa";
    Q6.Respostacorreta = 1;
    Q6.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q6);
    
    // Pergunta 7
    var Q7 = new Questao();
    Q7.Pergunta = "Qual é a montanha mais alta do mundo?";
    Q7.Resposta1 = "K2";
    Q7.Resposta2 = "Monte Everest";
    Q7.Resposta3 = "Kangchenjunga";
    Q7.Resposta4 = "Lhotse";
    Q7.Resposta5 = "Makalu";
    Q7.Respostacorreta = 2;
    Q7.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q7);
    
    // Pergunta 8
    var Q8 = new Questao();
    Q8.Pergunta = "Qual é o símbolo químico do ouro?";
    Q8.Resposta1 = "Ag";
    Q8.Resposta2 = "Au";
    Q8.Resposta3 = "Fe";
    Q8.Resposta4 = "Hg";
    Q8.Resposta5 = "Pb";
    Q8.Respostacorreta = 2;
    Q8.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q8);
    
    // Pergunta 9
    var Q9 = new Questao();
    Q9.Pergunta = "Qual é o menor país do mundo?";
    Q9.Resposta1 = "Mônaco";
    Q9.Resposta2 = "Vaticano";
    Q9.Resposta3 = "Nauru";
    Q9.Resposta4 = "Maldivas";
    Q9.Resposta5 = "San Marino";
    Q9.Respostacorreta = 2;
    Q9.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q9);
    
    // Pergunta 10
    var Q10 = new Questao();
    Q10.Pergunta = "Quem pintou a Mona Lisa?";
    Q10.Resposta1 = "Vincent van Gogh";
    Q10.Resposta2 = "Pablo Picasso";
    Q10.Resposta3 = "Leonardo da Vinci";
    Q10.Resposta4 = "Claude Monet";
    Q10.Resposta5 = "Rembrandt";
    Q10.Respostacorreta = 3;
    Q10.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q10);

    // Continue with the remaining questions
    // ...

    // Pergunta 11
    var Q11 = new Questao();
    Q11.Pergunta = "Qual é o continente mais populoso?";
    Q11.Resposta1 = "África";
    Q11.Resposta2 = "América do Norte";
    Q11.Resposta3 = "Ásia";
    Q11.Resposta4 = "Europa";
    Q11.Resposta5 = "Oceania";
    Q11.Respostacorreta = 3;
    Q11.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q11);

    // Pergunta 12
    var Q12 = new Questao();
    Q12.Pergunta = "Quantos estados tem os EUA?";
    Q12.Resposta1 = "48";
    Q12.Resposta2 = "50";
    Q12.Resposta3 = "52";
    Q12.Resposta4 = "51";
    Q12.Resposta5 = "49";
    Q12.Respostacorreta = 2;
    Q12.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q12);

    // Pergunta 13
    var Q13 = new Questao();
    Q13.Pergunta = "Qual é o maior oceano do mundo?";
    Q13.Resposta1 = "Oceano Atlântico";
    Q13.Resposta2 = "Oceano Índico";
    Q13.Resposta3 = "Oceano Pacífico";
    Q13.Resposta4 = "Oceano Ártico";
    Q13.Resposta5 = "Oceano Antártico";
    Q13.Respostacorreta = 3;
    Q13.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q13);

    // Pergunta 14
    var Q14 = new Questao();
    Q14.Pergunta = "Qual é a língua mais falada do mundo?";
    Q14.Resposta1 = "Inglês";
    Q14.Resposta2 = "Mandarim";
    Q14.Resposta3 = "Espanhol";
    Q14.Resposta4 = "Árabe";
    Q14.Resposta5 = "Hindi";
    Q14.Respostacorreta = 2;
    Q14.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q14);

    // Pergunta 15
    var Q15 = new Questao();
    Q15.Pergunta = "Qual é o símbolo do hidrogênio?";
    Q15.Resposta1 = "H2";
    Q15.Resposta2 = "He";
    Q15.Resposta3 = "O2";
    Q15.Resposta4 = "H";
    Q15.Resposta5 = "N";
    Q15.Respostacorreta = 4;
    Q15.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q15);

    // Pergunta 16
    var Q16 = new Questao();
    Q16.Pergunta = "Qual é a maior espécie de peixe do mundo?";
    Q16.Resposta1 = "Tubarão-baleia";
    Q16.Resposta2 = "Tubarão-branco";
    Q16.Resposta3 = "Salmão";
    Q16.Resposta4 = "Baleia";
    Q16.Resposta5 = "Peixe-palhaço";
    Q16.Respostacorreta = 1;
    Q16.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q16);

    // Pergunta 17
    var Q17 = new Questao();
    Q17.Pergunta = "Qual é a capital do Brasil?";
    Q17.Resposta1 = "Rio de Janeiro";
    Q17.Resposta2 = "Brasília";
    Q17.Resposta3 = "São Paulo";
    Q17.Resposta4 = "Salvador";
    Q17.Resposta5 = "Fortaleza";
    Q17.Respostacorreta = 2;
    Q17.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q17);

    // Pergunta 18
    var Q18 = new Questao();
    Q18.Pergunta = "Qual é a moeda do Japão?";
    Q18.Resposta1 = "Yuan";
    Q18.Resposta2 = "Dólar";
    Q18.Resposta3 = "Iene";
    Q18.Resposta4 = "Won";
    Q18.Resposta5 = "Rúpia";
    Q18.Respostacorreta = 3;
    Q18.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q18);

    // Pergunta 19
    var Q19 = new Questao();
    Q19.Pergunta = "Qual é o animal mais rápido do mundo?";
    Q19.Resposta1 = "Guepardo";
    Q19.Resposta2 = "Leão";
    Q19.Resposta3 = "Falcão-peregrino";
    Q19.Resposta4 = "Cavalo";
    Q19.Resposta5 = "Antílope";
    Q19.Respostacorreta = 3;
    Q19.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q19);

    // Pergunta 20
    var Q20 = new Questao();
    Q20.Pergunta = "Qual é a camada mais externa da Terra?";
    Q20.Resposta1 = "Manto";
    Q20.Resposta2 = "Crosta";
    Q20.Resposta3 = "Núcleo";
    Q20.Resposta4 = "Atmosfera";
    Q20.Resposta5 = "Hidrosfera";
    Q20.Respostacorreta = 2;
    Q20.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q20);

    // Continue com as perguntas restantes até Q99...
    // Pergunta 21
    var Q21 = new Questao();
    Q21.Pergunta = "Qual é o animal símbolo do Brasil?";
    Q21.Resposta1 = "Onça-pintada";
    Q21.Resposta2 = "Águia";
    Q21.Resposta3 = "Tatu";
    Q21.Resposta4 = "Cavalo";
    Q21.Resposta5 = "Jacaré";
    Q21.Respostacorreta = 1;
    Q21.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q21);

    // Pergunta 22
    var Q22 = new Questao();
    Q22.Pergunta = "Qual é o maior deserto do mundo?";
    Q22.Resposta1 = "Deserto do Saara";
    Q22.Resposta2 = "Deserto da Antártica";
    Q22.Resposta3 = "Deserto de Gobi";
    Q22.Resposta4 = "Deserto do Atacama";
    Q22.Resposta5 = "Deserto de Kalahari";
    Q22.Respostacorreta = 2;
    Q22.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q22);

    // Pergunta 23
    var Q23 = new Questao();
    Q23.Pergunta = "Qual é a língua oficial da China?";
    Q23.Resposta1 = "Inglês";
    Q23.Resposta2 = "Mandarim";
    Q23.Resposta3 = "Espanhol";
    Q23.Resposta4 = "Francês";
    Q23.Resposta5 = "Alemão";
    Q23.Respostacorreta = 2;
    Q23.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q23);

    // Pergunta 24
    var Q24 = new Questao();
    Q24.Pergunta = "Qual é o principal gás do efeito estufa?";
    Q24.Resposta1 = "Oxigênio";
    Q24.Resposta2 = "Nitrogênio";
    Q24.Resposta3 = "Dióxido de carbono";
    Q24.Resposta4 = "Hélio";
    Q24.Resposta5 = "Metano";
    Q24.Respostacorreta = 3;
    Q24.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q24);

    // Pergunta 25
    var Q25 = new Questao();
    Q25.Pergunta = "Qual é a capital da Austrália?";
    Q25.Resposta1 = "Sydney";
    Q25.Resposta2 = "Canberra";
    Q25.Resposta3 = "Melbourne";
    Q25.Resposta4 = "Brisbane";
    Q25.Resposta5 = "Perth";
    Q25.Respostacorreta = 2;
    Q25.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q25);

    // Pergunta 26
    var Q26 = new Questao();
    Q26.Pergunta = "Qual é o planeta mais próximo do sol?";
    Q26.Resposta1 = "Terra";
    Q26.Resposta2 = "Marte";
    Q26.Resposta3 = "Mercúrio";
    Q26.Resposta4 = "Vênus";
    Q26.Resposta5 = "Júpiter";
    Q26.Respostacorreta = 3;
    Q26.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q26);

    // Pergunta 27
    var Q27 = new Questao();
    Q27.Pergunta = "Qual é a maior floresta tropical do mundo?";
    Q27.Resposta1 = "Floresta Amazônica";
    Q27.Resposta2 = "Floresta do Congo";
    Q27.Resposta3 = "Floresta de Borneo";
    Q27.Resposta4 = "Floresta de Taiga";
    Q27.Resposta5 = "Floresta do Atlântico";
    Q27.Respostacorreta = 1;
    Q27.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q27);

    // Pergunta 28
    var Q28 = new Questao();
    Q28.Pergunta = "Qual é o elemento mais abundante no universo?";
    Q28.Resposta1 = "Hélio";
    Q28.Resposta2 = "Hidrogênio";
    Q28.Resposta3 = "Oxigênio";
    Q28.Resposta4 = "Carbono";
    Q28.Resposta5 = "Nitrogênio";
    Q28.Respostacorreta = 2;
    Q28.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q28);

    // Pergunta 29
    var Q29 = new Questao();
    Q29.Pergunta = "Quem foi o primeiro homem a pisar na lua?";
    Q29.Resposta1 = "Buzz Aldrin";
    Q29.Resposta2 = "Neil Armstrong";
    Q29.Resposta3 = "Yuri Gagarin";
    Q29.Resposta4 = "John Glenn";
    Q29.Resposta5 = "Alan Shepard";
    Q29.Respostacorreta = 2;
    Q29.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q29);

    // Pergunta 30
    var Q30 = new Questao();
    Q30.Pergunta = "Qual é o maior continente do mundo?";
    Q30.Resposta1 = "África";
    Q30.Resposta2 = "Ásia";
    Q30.Resposta3 = "América do Sul";
    Q30.Resposta4 = "Antártida";
    Q30.Resposta5 = "Europa";
    Q30.Respostacorreta = 2;
    Q30.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q30);

        // Pergunta 31
    var Q31 = new Questao();
    Q31.Pergunta = "Qual é a capital da Argentina?";
    Q31.Resposta1 = "Buenos Aires";
    Q31.Resposta2 = "Santiago";
    Q31.Resposta3 = "Montevidéu";
    Q31.Resposta4 = "Lima";
    Q31.Resposta5 = "Bogotá";
    Q31.Respostacorreta = 1;
    Q31.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q31);

    // Pergunta 32
    var Q32 = new Questao();
    Q32.Pergunta = "Qual é o maior órgão do corpo humano?";
    Q32.Resposta1 = "Coração";
    Q32.Resposta2 = "Fígado";
    Q32.Resposta3 = "Pele";
    Q32.Resposta4 = "Pulmão";
    Q32.Resposta5 = "Rim";
    Q32.Respostacorreta = 3;
    Q32.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q32);

    // Pergunta 33
    var Q33 = new Questao();
    Q33.Pergunta = "Qual é a fórmula química do sal de cozinha?";
    Q33.Resposta1 = "NaCl";
    Q33.Resposta2 = "KCl";
    Q33.Resposta3 = "NaHCO3";
    Q33.Resposta4 = "CaCO3";
    Q33.Resposta5 = "H2SO4";
    Q33.Respostacorreta = 1;
    Q33.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q33);

    // Pergunta 34
    var Q34 = new Questao();
    Q34.Pergunta = "Quem descobriu a América?";
    Q34.Resposta1 = "Cristóvão Colombo";
    Q34.Resposta2 = "Vasco da Gama";
    Q34.Resposta3 = "Ferdinand Magellan";
    Q34.Resposta4 = "Pedro Álvares Cabral";
    Q34.Resposta5 = "Leif Erikson";
    Q34.Respostacorreta = 1;
    Q34.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q34);

    // Pergunta 35
    var Q35 = new Questao();
    Q35.Pergunta = "Qual é o elemento químico com símbolo Fe?";
    Q35.Resposta1 = "Ferro";
    Q35.Resposta2 = "Flúor";
    Q35.Resposta3 = "Fósforo";
    Q35.Resposta4 = "Fermio";
    Q35.Resposta5 = "Francio";
    Q35.Respostacorreta = 1;
    Q35.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q35);

    // Pergunta 36
    var Q36 = new Questao();
    Q36.Pergunta = "Qual é o planeta conhecido como o 'planeta vermelho'?";
    Q36.Resposta1 = "Terra";
    Q36.Resposta2 = "Vênus";
    Q36.Resposta3 = "Marte";
    Q36.Resposta4 = "Mercúrio";
    Q36.Resposta5 = "Júpiter";
    Q36.Respostacorreta = 3;
    Q36.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q36);

    // Pergunta 37
    var Q37 = new Questao();
    Q37.Pergunta = "Qual é a maior ilha do mundo?";
    Q37.Resposta1 = "Groenlândia";
    Q37.Resposta2 = "Nova Guiné";
    Q37.Resposta3 = "Borneo";
    Q37.Resposta4 = "Madagascar";
    Q37.Resposta5 = "Sumatra";
    Q37.Respostacorreta = 1;
    Q37.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q37);

    // Pergunta 38
    var Q38 = new Questao();
    Q38.Pergunta = "Qual é a capital do Egito?";
    Q38.Resposta1 = "Cairo";
    Q38.Resposta2 = "Túnis";
    Q38.Resposta3 = "Riad";
    Q38.Resposta4 = "Nairóbi";
    Q38.Resposta5 = "Cartum";
    Q38.Respostacorreta = 1;
    Q38.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q38);

    // Pergunta 39
    var Q39 = new Questao();
    Q39.Pergunta = "Qual é a moeda da União Europeia?";
    Q39.Resposta1 = "Dólar";
    Q39.Resposta2 = "Libra";
    Q39.Resposta3 = "Euro";
    Q39.Resposta4 = "Franco";
    Q39.Resposta5 = "Yen";
    Q39.Respostacorreta = 3;
    Q39.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q39);

    // Pergunta 40
    var Q40 = new Questao();
    Q40.Pergunta = "Qual é a capital da Itália?";
    Q40.Resposta1 = "Milão";
    Q40.Resposta2 = "Roma";
    Q40.Resposta3 = "Veneza";
    Q40.Resposta4 = "Florença";
    Q40.Resposta5 = "Nápoles";
    Q40.Respostacorreta = 2;
    Q40.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q40);

    // Pergunta 41
    var Q41 = new Questao();
    Q41.Pergunta = "Qual é o sistema de escrita utilizado no Japão?";
    Q41.Resposta1 = "Kanji";
    Q41.Resposta2 = "Hiragana";
    Q41.Resposta3 = "Katakana";
    Q41.Resposta4 = "Romaji";
    Q41.Resposta5 = "Todos os anteriores";
    Q41.Respostacorreta = 5;
    Q41.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q41);

    // Pergunta 42
    var Q42 = new Questao();
    Q42.Pergunta = "Qual é o maior estado do Brasil?";
    Q42.Resposta1 = "São Paulo";
    Q42.Resposta2 = "Minas Gerais";
    Q42.Resposta3 = "Amazonas";
    Q42.Resposta4 = "Bahia";
    Q42.Resposta5 = "Paraná";
    Q42.Respostacorreta = 3;
    Q42.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q42);

    // Pergunta 43
    var Q43 = new Questao();
    Q43.Pergunta = "Qual é a primeira letra do alfabeto grego?";
    Q43.Resposta1 = "Alpha";
    Q43.Resposta2 = "Beta";
    Q43.Resposta3 = "Gamma";
    Q43.Resposta4 = "Delta";
    Q43.Resposta5 = "Epsilon";
    Q43.Respostacorreta = 1;
    Q43.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q43);

    // Pergunta 44
    var Q44 = new Questao();
    Q44.Pergunta = "Qual é o animal símbolo da Austrália?";
    Q44.Resposta1 = "Canguru";
    Q44.Resposta2 = "Coala";
    Q44.Resposta3 = "Emu";
    Q44.Resposta4 = "Crocodilo";
    Q44.Resposta5 = "Tubarão";
    Q44.Respostacorreta = 1;
    Q44.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q44);

    // Pergunta 45
    var Q45 = new Questao();
    Q45.Pergunta = "Qual é a principal língua falada no Brasil?";
    Q45.Resposta1 = "Espanhol";
    Q45.Resposta2 = "Francês";
    Q45.Resposta3 = "Português";
    Q45.Resposta4 = "Inglês";
    Q45.Resposta5 = "Italiano";
    Q45.Respostacorreta = 3;
    Q45.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q45);

    // Pergunta 46
    var Q46 = new Questao();
    Q46.Pergunta = "Qual é a capital da França?";
    Q46.Resposta1 = "Londres";
    Q46.Resposta2 = "Madri";
    Q46.Resposta3 = "Paris";
    Q46.Resposta4 = "Berlim";
    Q46.Resposta5 = "Lisboa";
    Q46.Respostacorreta = 3;
    Q46.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q46);

    // Pergunta 47
    var Q47 = new Questao();
    Q47.Pergunta = "Qual é a capital da Rússia?";
    Q47.Resposta1 = "Moscou";
    Q47.Resposta2 = "São Petersburgo";
    Q47.Resposta3 = "Cazã";
    Q47.Resposta4 = "Novosibirsk";
    Q47.Resposta5 = "Ecaterimburgo";
    Q47.Respostacorreta = 1;
    Q47.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q47);

    // Pergunta 48
    var Q48 = new Questao();
    Q48.Pergunta = "Qual é o principal ingrediente do guacamole?";
    Q48.Resposta1 = "Tomate";
    Q48.Resposta2 = "Cebola";
    Q48.Resposta3 = "Abacate";
    Q48.Resposta4 = "Pimenta";
    Q48.Resposta5 = "Limão";
    Q48.Respostacorreta = 3;
    Q48.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q48);

    // Pergunta 49
    var Q49 = new Questao();
    Q49.Pergunta = "Qual é o nome do famoso relógio em Londres?";
    Q49.Resposta1 = "Big Ben";
    Q49.Resposta2 = "Torre Eiffel";
    Q49.Resposta3 = "Torre de Londres";
    Q49.Resposta4 = "Clock Tower";
    Q49.Resposta5 = "London Eye";
    Q49.Respostacorreta = 1;
    Q49.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q49);

    // Pergunta 50
    var Q50 = new Questao();
    Q50.Pergunta = "Qual é o país conhecido como a terra do sol nascente?";
    Q50.Resposta1 = "China";
    Q50.Resposta2 = "Coreia do Sul";
    Q50.Resposta3 = "Japão";
    Q50.Resposta4 = "Tailândia";
    Q50.Resposta5 = "Filipinas";
    Q50.Respostacorreta = 3;
    Q50.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q50);

    // Pergunta 51
    var Q51 = new Questao();
    Q51.Pergunta = "Qual é a montanha mais alta do mundo?";
    Q51.Resposta1 = "K2";
    Q51.Resposta2 = "Kangchenjunga";
    Q51.Resposta3 = "Monte Everest";
    Q51.Resposta4 = "Makalu";
    Q51.Resposta5 = "Lhotse";
    Q51.Respostacorreta = 3;
    Q51.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q51);

    // Pergunta 52
    var Q52 = new Questao();
    Q52.Pergunta = "Quem escreveu 'Dom Quixote'?";
    Q52.Resposta1 = "Gabriel García Márquez";
    Q52.Resposta2 = "Miguel de Cervantes";
    Q52.Resposta3 = "Jorge Luis Borges";
    Q52.Resposta4 = "Pablo Neruda";
    Q52.Resposta5 = "Julio Cortázar";
    Q52.Respostacorreta = 2;
    Q52.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q52);

    // Pergunta 53
    var Q53 = new Questao();
    Q53.Pergunta = "Qual é a primeira mulher a ganhar um Prêmio Nobel?";
    Q53.Resposta1 = "Marie Curie";
    Q53.Resposta2 = "Rosalind Franklin";
    Q53.Resposta3 = "Malala Yousafzai";
    Q53.Resposta4 = "Ada Lovelace";
    Q53.Resposta5 = "Hedy Lamarr";
    Q53.Respostacorreta = 1;
    Q53.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q53);

    // Pergunta 54
    var Q54 = new Questao();
    Q54.Pergunta = "Qual é o oceano mais profundo do mundo?";
    Q54.Resposta1 = "Oceano Pacífico";
    Q54.Resposta2 = "Oceano Atlântico";
    Q54.Resposta3 = "Oceano Índico";
    Q54.Resposta4 = "Oceano Ártico";
    Q54.Resposta5 = "Oceano Antártico";
    Q54.Respostacorreta = 1;
    Q54.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q54);

    // Pergunta 55
    var Q55 = new Questao();
    Q55.Pergunta = "Qual é a língua mais falada do mundo?";
    Q55.Resposta1 = "Inglês";
    Q55.Resposta2 = "Mandarim";
    Q55.Resposta3 = "Espanhol";
    Q55.Resposta4 = "Hindi";
    Q55.Resposta5 = "Árabe";
    Q55.Respostacorreta = 2;
    Q55.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q55);

    // Pergunta 56
    var Q56 = new Questao();
    Q56.Pergunta = "Qual é o continente mais povoado do mundo?";
    Q56.Resposta1 = "África";
    Q56.Resposta2 = "Ásia";
    Q56.Resposta3 = "Europa";
    Q56.Resposta4 = "América do Sul";
    Q56.Resposta5 = "Oceânia";
    Q56.Respostacorreta = 2;
    Q56.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q56);

    // Pergunta 57
    var Q57 = new Questao();
    Q57.Pergunta = "Qual é o país mais extenso do mundo?";
    Q57.Resposta1 = "Canadá";
    Q57.Resposta2 = "Rússia";
    Q57.Resposta3 = "China";
    Q57.Resposta4 = "Estados Unidos";
    Q57.Resposta5 = "Brasil";
    Q57.Respostacorreta = 2;
    Q57.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q57);

    // Pergunta 58
    var Q58 = new Questao();
    Q58.Pergunta = "Qual é o tipo de energia gerada pelo movimento da água?";
    Q58.Resposta1 = "Eólica";
    Q58.Resposta2 = "Hidrelétrica";
    Q58.Resposta3 = "Solar";
    Q58.Resposta4 = "Geotérmica";
    Q58.Resposta5 = "Nuclear";
    Q58.Respostacorreta = 2;
    Q58.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q58);

    // Pergunta 59
    var Q59 = new Questao();
    Q59.Pergunta = "Qual é o gás responsável pelo efeito estufa?";
    Q59.Resposta1 = "Oxigênio";
    Q59.Resposta2 = "Nitrogênio";
    Q59.Resposta3 = "Dióxido de carbono";
    Q59.Resposta4 = "Hélio";
    Q59.Resposta5 = "Argônio";
    Q59.Respostacorreta = 3;
    Q59.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q59);

    // Pergunta 60
    var Q60 = new Questao();
    Q60.Pergunta = "Qual é a capital do Canadá?";
    Q60.Resposta1 = "Toronto";
    Q60.Resposta2 = "Vancouver";
    Q60.Resposta3 = "Ottawa";
    Q60.Resposta4 = "Montreal";
    Q60.Resposta5 = "Calgary";
    Q60.Respostacorreta = 3;
    Q60.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q60);

    // Pergunta 61
    var Q61 = new Questao();
    Q61.Pergunta = "Qual é a capital da Austrália?";
    Q61.Resposta1 = "Sydney";
    Q61.Resposta2 = "Canberra";
    Q61.Resposta3 = "Melbourne";
    Q61.Resposta4 = "Brisbane";
    Q61.Resposta5 = "Perth";
    Q61.Respostacorreta = 2;
    Q61.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q61);

    // Pergunta 62
    var Q62 = new Questao();
    Q62.Pergunta = "Qual é a primeira letra do alfabeto latino?";
    Q62.Resposta1 = "A";
    Q62.Resposta2 = "B";
    Q62.Resposta3 = "C";
    Q62.Resposta4 = "D";
    Q62.Resposta5 = "E";
    Q62.Respostacorreta = 1;
    Q62.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q62);

    // Pergunta 63
    var Q63 = new Questao();
    Q63.Pergunta = "Qual é a capital do Japão?";
    Q63.Resposta1 = "Seul";
    Q63.Resposta2 = "Tóquio";
    Q63.Resposta3 = "Pequim";
    Q63.Resposta4 = "Banguecoque";
    Q63.Resposta5 = "Hanoi";
    Q63.Respostacorreta = 2;
    Q63.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q63);

    // Pergunta 64
    var Q64 = new Questao();
    Q64.Pergunta = "Qual é o símbolo químico do ouro?";
    Q64.Resposta1 = "Ag";
    Q64.Resposta2 = "Au";
    Q64.Resposta3 = "Fe";
    Q64.Resposta4 = "Pb";
    Q64.Resposta5 = "Hg";
    Q64.Respostacorreta = 2;
    Q64.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q64);

    // Pergunta 65
    var Q65 = new Questao();
    Q65.Pergunta = "Qual é o principal recurso natural do Brasil?";
    Q65.Resposta1 = "Petróleo";
    Q65.Resposta2 = "Carvão";
    Q65.Resposta3 = "Água";
    Q65.Resposta4 = "Minérios";
    Q65.Resposta5 = "Madeira";
    Q65.Respostacorreta = 3;
    Q65.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q65);

    // Pergunta 66
    var Q66 = new Questao();
    Q66.Pergunta = "Qual é a capital da Suíça?";
    Q66.Resposta1 = "Genebra";
    Q66.Resposta2 = "Zurique";
    Q66.Resposta3 = "Berna";
    Q66.Resposta4 = "Lucerna";
    Q66.Resposta5 = "Basileia";
    Q66.Respostacorreta = 3;
    Q66.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q66);

    // Pergunta 67
    var Q67 = new Questao();
    Q67.Pergunta = "Qual é a cidade mais populosa do mundo?";
    Q67.Resposta1 = "Tóquio";
    Q67.Resposta2 = "Xangai";
    Q67.Resposta3 = "Nova York";
    Q67.Resposta4 = "Mumbai";
    Q67.Resposta5 = "São Paulo";
    Q67.Respostacorreta = 1;
    Q67.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q67);

    // Pergunta 68
    var Q68 = new Questao();
    Q68.Pergunta = "Qual é a fórmula química da água?";
    Q68.Resposta1 = "H2O";
    Q68.Resposta2 = "O2";
    Q68.Resposta3 = "CO2";
    Q68.Resposta4 = "NaCl";
    Q68.Resposta5 = "H2SO4";
    Q68.Respostacorreta = 1;
    Q68.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q68);

    // Pergunta 69
    var Q69 = new Questao();
    Q69.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
    Q69.Resposta1 = "Abraham Lincoln";
    Q69.Resposta2 = "George Washington";
    Q69.Resposta3 = "Thomas Jefferson";
    Q69.Resposta4 = "John Adams";
    Q69.Resposta5 = "Franklin D. Roosevelt";
    Q69.Respostacorreta = 2;
    Q69.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q69);

    // Pergunta 70
    var Q70 = new Questao();
    Q70.Pergunta = "Qual é o continente mais frio do mundo?";
    Q70.Resposta1 = "Antártida";
    Q70.Resposta2 = "África";
    Q70.Resposta3 = "Ásia";
    Q70.Resposta4 = "América do Sul";
    Q70.Resposta5 = "Oceânia";
    Q70.Respostacorreta = 1;
    Q70.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q70);

    // Pergunta 71
    var Q71 = new Questao();
    Q71.Pergunta = "Qual é a montanha mais alta da América do Sul?";
    Q71.Resposta1 = "Aconcágua";
    Q71.Resposta2 = "Orelhudo";
    Q71.Resposta3 = "Fitz Roy";
    Q71.Resposta4 = "Pico da Neblina";
    Q71.Resposta5 = "Cerro Torre";
    Q71.Respostacorreta = 1;
    Q71.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q71);

    // Pergunta 72
    var Q72 = new Questao();
    Q72.Pergunta = "Qual é o nome do famoso cientista que desenvolveu a teoria da relatividade?";
    Q72.Resposta1 = "Isaac Newton";
    Q72.Resposta2 = "Albert Einstein";
    Q72.Resposta3 = "Galileu Galilei";
    Q72.Resposta4 = "Nikola Tesla";
    Q72.Resposta5 = "Stephen Hawking";
    Q72.Respostacorreta = 2;
    Q72.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q72);

    // Pergunta 73
    var Q73 = new Questao();
    Q73.Pergunta = "Qual é o planeta mais próximo do sol?";
    Q73.Resposta1 = "Vênus";
    Q73.Resposta2 = "Marte";
    Q73.Resposta3 = "Mercúrio";
    Q73.Resposta4 = "Júpiter";
    Q73.Resposta5 = "Saturno";
    Q73.Respostacorreta = 3;
    Q73.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q73);

    // Pergunta 74
    var Q74 = new Questao();
    Q74.Pergunta = "Qual é a capital da Itália?";
    Q74.Resposta1 = "Florença";
    Q74.Resposta2 = "Milão";
    Q74.Resposta3 = "Roma";
    Q74.Resposta4 = "Veneza";
    Q74.Resposta5 = "Nápoles";
    Q74.Respostacorreta = 3;
    Q74.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q74);

    // Pergunta 75
    var Q75 = new Questao();
    Q75.Pergunta = "Qual é o menor país do mundo?";
    Q75.Resposta1 = "Mônaco";
    Q75.Resposta2 = "San Marino";
    Q75.Resposta3 = "Vaticano";
    Q75.Resposta4 = "Nauru";
    Q75.Resposta5 = "Malta";
    Q75.Respostacorreta = 3;
    Q75.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q75);

    // Pergunta 76
    var Q76 = new Questao();
    Q76.Pergunta = "Qual é o maior deserto do mundo?";
    Q76.Resposta1 = "Sahara";
    Q76.Resposta2 = "Gobi";
    Q76.Resposta3 = "Atacama";
    Q76.Resposta4 = "Antártico";
    Q76.Resposta5 = "Kalahari";
    Q76.Respostacorreta = 4;
    Q76.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q76);

    // Pergunta 77
    var Q77 = new Questao();
    Q77.Pergunta = "Qual é a capital da Alemanha?";
    Q77.Resposta1 = "Berlim";
    Q77.Resposta2 = "Munique";
    Q77.Resposta3 = "Frankfurt";
    Q77.Resposta4 = "Hamburgo";
    Q77.Resposta5 = "Colônia";
    Q77.Respostacorreta = 1;
    Q77.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q77);

    // Pergunta 78
    var Q78 = new Questao();
    Q78.Pergunta = "Qual é o país com mais falantes nativos de espanhol?";
    Q78.Resposta1 = "Espanha";
    Q78.Resposta2 = "México";
    Q78.Resposta3 = "Colômbia";
    Q78.Resposta4 = "Argentina";
    Q78.Resposta5 = "Venezuela";
    Q78.Respostacorreta = 2;
    Q78.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q78);

    // Pergunta 79
    var Q79 = new Questao();
    Q79.Pergunta = "Qual é a moeda oficial do Japão?";
    Q79.Resposta1 = "Yuan";
    Q79.Resposta2 = "Dólar";
    Q79.Resposta3 = "Iene";
    Q79.Resposta4 = "Won";
    Q79.Resposta5 = "Peso";
    Q79.Respostacorreta = 3;
    Q79.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q79);

    // Pergunta 80
    var Q80 = new Questao();
    Q80.Pergunta = "Qual é o maior continente do mundo?";
    Q80.Resposta1 = "África";
    Q80.Resposta2 = "Ásia";
    Q80.Resposta3 = "América do Norte";
    Q80.Resposta4 = "América do Sul";
    Q80.Resposta5 = "Oceânia";
    Q80.Respostacorreta = 2;
    Q80.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q80);

    // Pergunta 81
    var Q81 = new Questao();
    Q81.Pergunta = "Qual é o nome do processo pelo qual as plantas produzem alimento?";
    Q81.Resposta1 = "Respiração";
    Q81.Resposta2 = "Fotossíntese";
    Q81.Resposta3 = "Evaporação";
    Q81.Resposta4 = "Transpiração";
    Q81.Resposta5 = "Condensação";
    Q81.Respostacorreta = 2;
    Q81.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q81);

    // Pergunta 82
    var Q82 = new Questao();
    Q82.Pergunta = "Qual é a capital da Argentina?";
    Q82.Resposta1 = "Buenos Aires";
    Q82.Resposta2 = "Córdoba";
    Q82.Resposta3 = "Rosário";
    Q82.Resposta4 = "Mendoza";
    Q82.Resposta5 = "La Plata";
    Q82.Respostacorreta = 1;
    Q82.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q82);

    // Pergunta 83
    var Q83 = new Questao();
    Q83.Pergunta = "Qual é a capital da Colômbia?";
    Q83.Resposta1 = "Medellín";
    Q83.Resposta2 = "Cali";
    Q83.Resposta3 = "Cartagena";
    Q83.Resposta4 = "Bogotá";
    Q83.Resposta5 = "Barranquilla";
    Q83.Respostacorreta = 4;
    Q83.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q83);

    // Pergunta 84
    var Q84 = new Questao();
    Q84.Pergunta = "Qual é a capital de Portugal?";
    Q84.Resposta1 = "Lisboa";
    Q84.Resposta2 = "Porto";
    Q84.Resposta3 = "Coimbra";
    Q84.Resposta4 = "Braga";
    Q84.Resposta5 = "Aveiro";
    Q84.Respostacorreta = 1;
    Q84.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q84);

    // Pergunta 85
    var Q85 = new Questao();
    Q85.Pergunta = "Qual é a capital da Venezuela?";
    Q85.Resposta1 = "Caracas";
    Q85.Resposta2 = "Maracaibo";
    Q85.Resposta3 = "Valência";
    Q85.Resposta4 = "Barquisimeto";
    Q85.Resposta5 = "Mérida";
    Q85.Respostacorreta = 1;
    Q85.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q85);

    // Pergunta 86
    var Q86 = new Questao();
    Q86.Pergunta = "Qual é a moeda oficial da União Europeia?";
    Q86.Resposta1 = "Dólar";
    Q86.Resposta2 = "Euro";
    Q86.Resposta3 = "Libra";
    Q86.Resposta4 = "Franco";
    Q86.Resposta5 = "Yen";
    Q86.Respostacorreta = 2;
    Q86.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q86);

    // Pergunta 87
    var Q87 = new Questao();
    Q87.Pergunta = "Qual é o oceano mais profundo do mundo?";
    Q87.Resposta1 = "Atlântico";
    Q87.Resposta2 = "Índico";
    Q87.Resposta3 = "Pacífico";
    Q87.Resposta4 = "Ártico";
    Q87.Resposta5 = "Antártico";
    Q87.Respostacorreta = 3;
    Q87.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q87);

    // Pergunta 88
    var Q88 = new Questao();
    Q88.Pergunta = "Qual é a língua oficial do Brasil?";
    Q88.Resposta1 = "Espanhol";
    Q88.Resposta2 = "Francês";
    Q88.Resposta3 = "Inglês";
    Q88.Resposta4 = "Português";
    Q88.Resposta5 = "Italiano";
    Q88.Respostacorreta = 4;
    Q88.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q88);

    // Pergunta 89
    var Q89 = new Questao();
    Q89.Pergunta = "Qual é a capital da Dinamarca?";
    Q89.Resposta1 = "Copenhague";
    Q89.Resposta2 = "Aarhus";
    Q89.Resposta3 = "Odense";
    Q89.Resposta4 = "Aalborg";
    Q89.Resposta5 = "Esbjerg";
    Q89.Respostacorreta = 1;
    Q89.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q89);

    // Pergunta 90
    var Q90 = new Questao();
    Q90.Pergunta = "Qual é a capital da Islândia?";
    Q90.Resposta1 = "Reiquiavique";
    Q90.Resposta2 = "Akureyri";
    Q90.Resposta3 = "Selfoss";
    Q90.Resposta4 = "Kopavogur";
    Q90.Resposta5 = "Vestmannaeyjar";
    Q90.Respostacorreta = 1;
    Q90.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q90);

    // Pergunta 91
    var Q91 = new Questao();
    Q91.Pergunta = "Qual é a capital da Finlândia?";
    Q91.Resposta1 = "Helsinque";
    Q91.Resposta2 = "Helsinki";
    Q91.Resposta3 = "Tampere";
    Q91.Resposta4 = "Oulu";
    Q91.Resposta5 = "Espoo";
    Q91.Respostacorreta = 2;
    Q91.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q91);

    // Pergunta 92
    var Q92 = new Questao();
    Q92.Pergunta = "Qual é a capital da Noruega?";
    Q92.Resposta1 = "Oslo";
    Q92.Resposta2 = "Bergen";
    Q92.Resposta3 = "Stavanger";
    Q92.Resposta4 = "Drammen";
    Q92.Resposta5 = "Kristiansand";
    Q92.Respostacorreta = 1;
    Q92.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q92);

    // Pergunta 93
    var Q93 = new Questao();
    Q93.Pergunta = "Qual é a capital da Suécia?";
    Q93.Resposta1 = "Estocolmo";
    Q93.Resposta2 = "Gotemburgo";
    Q93.Resposta3 = "Malmö";
    Q93.Resposta4 = "Uppsala";
    Q93.Resposta5 = "Linköping";
    Q93.Respostacorreta = 1;
    Q93.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q93);

    // Pergunta 94
    var Q94 = new Questao();
    Q94.Pergunta = "Qual é a capital da Áustria?";
    Q94.Resposta1 = "Viena";
    Q94.Resposta2 = "Salzburgo";
    Q94.Resposta3 = "Graz";
    Q94.Resposta4 = "Innsbruck";
    Q94.Resposta5 = "Linz";
    Q94.Respostacorreta = 1;
    Q94.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q94);

    // Pergunta 95
    var Q95 = new Questao();
    Q95.Pergunta = "Qual é a capital da Hungria?";
    Q95.Resposta1 = "Budapeste";
    Q95.Resposta2 = "Debrecen";
    Q95.Resposta3 = "Szeged";
    Q95.Resposta4 = "Miskolc";
    Q95.Resposta5 = "Pécs";
    Q95.Respostacorreta = 1;
    Q95.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q95);

    // Pergunta 96
    var Q96 = new Questao();
    Q96.Pergunta = "Qual é a capital da Grécia?";
    Q96.Resposta1 = "Atenas";
    Q96.Resposta2 = "Salónica";
    Q96.Resposta3 = "Creta";
    Q96.Resposta4 = "Patras";
    Q96.Resposta5 = "Corfu";
    Q96.Respostacorreta = 1;
    Q96.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q96);

    // Pergunta 97
    var Q97 = new Questao();
    Q97.Pergunta = "Qual é a capital da Bulgária?";
    Q97.Resposta1 = "Sófia";
    Q97.Resposta2 = "Plovdiv";
    Q97.Resposta3 = "Varna";
    Q97.Resposta4 = "Burgas";
    Q97.Resposta5 = "Ruse";
    Q97.Respostacorreta = 1;
    Q97.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q97);

    // Pergunta 98
    var Q98 = new Questao();
    Q98.Pergunta = "Qual é a capital da Croácia?";
    Q98.Resposta1 = "Zagreb";
    Q98.Resposta2 = "Split";
    Q98.Resposta3 = "Dubrovnik";
    Q98.Resposta4 = "Osijek";
    Q98.Resposta5 = "Rijeka";
    Q98.Respostacorreta = 1;
    Q98.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q98);

    // Pergunta 99
    var Q99 = new Questao();
    Q99.Pergunta = "Qual é a capital da Eslovênia?";
    Q99.Resposta1 = "Ljubljana";
    Q99.Resposta2 = "Maribor";
    Q99.Resposta3 = "Celje";
    Q99.Resposta4 = "Koper";
    Q99.Resposta5 = "Novo Mesto";
    Q99.Respostacorreta = 1;
    Q99.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q99);

    // Pergunta 100
    var Q100 = new Questao();
    Q100.Pergunta = "Qual é a capital da Estônia?";
    Q100.Resposta1 = "Tallinn";
    Q100.Resposta2 = "Tartu";
    Q100.Resposta3 = "Narva";
    Q100.Resposta4 = "Kohtla-Järve";
    Q100.Resposta5 = "Pärnu";
    Q100.Respostacorreta = 1;
    Q100.ConfiguraEstruturaDesenho(labelPergunta, BTNResposta01, BTNResposta02, BTNResposta03, BTNResposta04, BTNResposta05);
    ListaQuestoes.Add(Q100);

   
}




      public void ProximaQuestao()
      {
          var numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        while(ListaQuestoesRespondidas.Contains(numRandomico))
        {
         numRandomico = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        }
        ListaQuestoesRespondidas.Add(numRandomico);
        QuestaoAtual = ListaQuestoes[numRandomico];
         QuestaoAtual.Desenhar();
      }
      public async void VerificaResposta(int rr)
      {
        if(QuestaoAtual.VerificaResposta(rr))
        {
         await Task.Delay(1000);
         ProximaQuestao();
        }

      }
       void AdicionaPontuacao(int n){
        if(n == 1)
        {
            Pontuacao = 1000;
        }
        if(n == 2)
        {
            Pontuacao = 2000;
        }
        if(n == 3){
            Pontuacao = 5000;
        }
        if(n == 4)
        {
            Pontuacao = 10000;
        }
        if(n == 5)
        {
            Pontuacao = 20000;
        }
        if(n == 6)
        {
            Pontuacao = 50000;
        }
        if(n == 7)
        {
            Pontuacao = 100000;
        }
        if(n == 8)
        {
            Pontuacao = 200000;
        }
        if(n == 9)
        {
            Pontuacao = 500000;
        }
        if(n == 10)
        {
            Pontuacao = 1000000;
        }
       }
}
