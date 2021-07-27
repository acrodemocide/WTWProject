namespace WTWProject
{
    public class NDimensionalTicTacToe : ITicTacToe
    {
        private const int MinimumSize = 3;
        private int[,] _gameBoard;
        private int _gameBoardSize;
        private int _winner = 0;

        public NDimensionalTicTacToe(int gameBoardSize)
        {
            _gameBoardSize = gameBoardSize < MinimumSize ? MinimumSize : gameBoardSize;
            _gameBoard = new int[_gameBoardSize, _gameBoardSize];
        }

        private bool DidPlayerWin(int player)
        {
            int rowCount = 0;
            int colCount = 0;
            int forwardDiagonalCount = 0;
            int backwardDiagonalCount = 0;
            bool didPlayerWin = false;
            for (int i = 0; i < _gameBoardSize; i++)
            {
                for (int j = 0; j < _gameBoardSize; j++)
                {
                    if (_gameBoard[i, j] == player)
                    {
                        rowCount++;
                    }
                    if (_gameBoard[j, i] == player)
                    {
                        colCount++;
                    }
                    if (i == j && _gameBoard[i, j] == player)
                    {
                        forwardDiagonalCount++;
                    }
                    if (i + j == _gameBoardSize - 1 && _gameBoard[i,j] == player)
                    {
                        backwardDiagonalCount++;
                    }
                }
                if (rowCount == _gameBoardSize || colCount == _gameBoardSize)
                {
                    didPlayerWin = true;
                    break;
                }
                else
                {
                    rowCount = 0;
                    colCount = 0;
                }
            }

            if (forwardDiagonalCount == _gameBoardSize || backwardDiagonalCount == _gameBoardSize)
            {
                didPlayerWin = true;
            }

            return didPlayerWin;
        }


        // This assumes the space is unoccupied
        // This assumes row and col are always within an acceptable range
        // This assumes that the only input ever provided for player is 1 or 2
        // This assumes that each player poperly alternates before calling this method -- this does not force alternation
        // If the winning condition is met, no more moves are recorded (effectively preventing more moves from
        //      happening) and the winner is returned (and will be returned each time this method is called).
        // To reset the game, another method will need to be created to restore the gameboard to a starting state.
        public int PlacePiece(int row, int col, int player)
        {
            if (_winner == 0)
            {
                _gameBoard[row, col] = player;
            }
            if (DidPlayerWin(player))
            {
                _winner = player;
            }
            return _winner;
        }
    }
}
