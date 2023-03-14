
Singleton.Jogo.Singleton jogador_1 = Singleton.Jogo.Singleton.GetInstancia;
jogador_1.Mensagem("Jogador 1: A bola está comigo no meio do campo.");

Singleton.Jogo.Singleton jogador_2 = Singleton.Jogo.Singleton.GetInstancia;
jogador_2.Mensagem("Jogador 2: recebeu a bola.");

Singleton.Jogo.Singleton jogador_3 = Singleton.Jogo.Singleton.GetInstancia;
jogador_3.Mensagem("Jogador 3: recebeu o lançamento na linha de fundo.");

Console.ReadKey();
