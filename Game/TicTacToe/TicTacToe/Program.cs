
using TicTacToe;

Player player1 = new Player(101, "PLayer 1");
player1.Sign = Sign.X;
Player player2 = new Player(102, "PLayer 2");
player2.Sign = Sign.O;
GameApp game = new GameApp(player1, player2);
game.Start();
