namespace Udemy.GameActions;


public class SetField
{
    char[,] playField = new[,] {
            {'1', '2', '3'},
            {'4', '5', '6'}, 
            {'7', '8', '9'}
    };
    int _player = 2;
    int _input = 0;
    bool _inputCorrect = true;
    int numberOfTurns = 0;
    public void SetBoard()
    {
        Console.Clear();
        Console.WriteLine("      |      |      |");
        Console.WriteLine("   {0}  |   {1}  |   {2}  |", playField[0,0], playField[0,1],  playField[0,2]);
        Console.WriteLine("______|______|______|_____");
        Console.WriteLine("      |      |      |");
        Console.WriteLine("   {0}  |   {1}  |   {2}  |", playField[1,0], playField[1,1],  playField[1,2]);
        Console.WriteLine("______|______|______|_____");
        Console.WriteLine("      |      |      |");
        Console.WriteLine("   {0}  |   {1}  |   {2}  |",  playField[2,0], playField[2,1],  playField[2,2]);
        Console.WriteLine("      |      |      |");
    }

    public void RestartGame()
    {
        playField = new[,]
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };
        SetBoard();
        numberOfTurns = 0;
    }

    public void EnterXorO(int player, int input)
    {
        char playerSign = ' ';

        if (player == 1)
        {
            playerSign = 'X';
        } else if (player == 2)
        {
            playerSign = 'O';
        }

        switch (input)
        {
            case 1: playField[0, 0] = playerSign; break;
            case 2: playField[0, 1] = playerSign; break;
            case 3: playField[0, 2] = playerSign; break;
            case 4: playField[1, 0] = playerSign; break;
            case 5: playField[1, 1] = playerSign; break;
            case 6: playField[1, 2] = playerSign; break;
            case 7: playField[2, 0] = playerSign; break;
            case 8: playField[2, 1] = playerSign; break;
            case 9: playField[2, 2] = playerSign; break;
        }
    }

    public char CheckWinningCondition()
    {
        char[] playerChars = {'X', 'O'};
        char winningPlayer = ' ';
        foreach (var playerChar in playerChars)
        {
            if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) &&
                 (playField[0, 2] == playerChar)) ||
                ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) &&
                 (playField[1, 2] == playerChar)) || ((playField[2, 0] == playerChar) &&
                                                      (playField[2, 1] == playerChar) &&
                                                      (playField[2, 2] == playerChar)))
            {
                winningPlayer = playerChar;
            }
            else if (((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) &&
                      (playField[2, 2] == playerChar)) || ((playField[0, 2] == playerChar) &&
                                                           (playField[1, 1] == playerChar) &&
                                                           (playField[2, 0] == playerChar)))
            {
                winningPlayer = playerChar;
            }
            else if (((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) &&
                      (playField[2, 0] == playerChar)) ||
                     ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) &&
                      (playField[2, 1] == playerChar)) || ((playField[0, 2] == playerChar) &&
                                                           (playField[1, 2] == playerChar) &&
                                                           (playField[0, 2] == playerChar)))
            {
                winningPlayer = playerChar;
            }
            
            
        }

        return winningPlayer;
    }
    public void TakePlayerTurn()
    {
        do
        {
            if (_player == 2)
            {
                Console.WriteLine("Number of turns taken: " + numberOfTurns);
                _player = 1;
                EnterXorO(_player, _input);
                numberOfTurns += 1;
            }
            else if(_player == 1)
            {
                Console.WriteLine("Number of turns taken: " + numberOfTurns);
                _player = 2;
                EnterXorO(_player, _input);
                numberOfTurns += 1;
            }
            SetBoard();
            char winningPlayer = CheckWinningCondition();
            if (winningPlayer == 'X' || winningPlayer == 'O')
            {
                Console.WriteLine("Please press any key to restart the game!");
                Console.ReadKey();
                RestartGame();
            }

            if (numberOfTurns > 9)
            {
                Console.WriteLine("It's a draw!, Please press any key to restart the game!");
                Console.ReadKey();
                RestartGame();
            }
            
            do
            {
                Console.Write(("Player {0}: Choose your field! "), _player);
                try
                {
                    _input = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number!");
                }

                if (_input == 1 && (playField[0, 0] == '1'))
                {
                    _inputCorrect = true;
                } else if(_input == 2 && (playField[0, 1] == '2'))
                {
                    _inputCorrect = true;
                } else if(_input == 3 && (playField[0, 2] == '3'))
                {
                    _inputCorrect = true;
                } else if(_input == 4 && (playField[1, 0] == '4'))
                {
                    _inputCorrect = true;
                } else if(_input == 5 && (playField[1, 1] == '5'))
                {
                    _inputCorrect = true;
                } else if(_input == 6 && (playField[1, 2] == '6'))
                {
                    _inputCorrect = true;
                } else if(_input == 7 && (playField[2, 0] == '7'))
                {
                    _inputCorrect = true;
                } else if(_input == 8 && (playField[2, 1] == '8'))
                {
                    _inputCorrect = true;
                } else if(_input == 9 && (playField[2, 2] == '9'))
                {
                    _inputCorrect = true;
                }
                else
                {
                    Console.WriteLine("Please select a free spot!");
                    _inputCorrect = false;
                }
            } while (!_inputCorrect);
        } while (true);
    }
    
}