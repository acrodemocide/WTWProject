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

        private bool DoesPlayerHaveCompleteRow(int player)
        {
            int piecesInARowCount = 0;
            for (int i = 0; i < _gameBoardSize; i++)
            {
                for (int j = 0; j < _gameBoardSize; j++)
                {
                    if (_gameBoard[i, j] == player)
                    {
                        piecesInARowCount++;
                    }
                    else
                    {
                        piecesInARowCount = 0;
                        break;
                    }
                }
                if (piecesInARowCount == _gameBoardSize)
                    return true;
            }
            return false;
        }

        private bool DoesPlayerHaveCompleteCol(int player)
        {
            int piecesInAColCount = 0;
            for (int i = 0; i < _gameBoardSize; i++)
            {
                for (int j = 0; j < _gameBoardSize; j++)
                {
                    if (_gameBoard[j, i] == player)
                    {
                        piecesInAColCount++;
                    }
                    else
                    {
                        piecesInAColCount = 0;
                        break;
                    }
                }
                if (piecesInAColCount == _gameBoardSize)
                    return true;
            }
            return false;
        }

        private bool DoesPlayerHaveCompleteDiagonal(int player)
        {
            int piecesInForwardDiagonalCount = 0;
            for (int i = 0; i < _gameBoardSize; i++)
            {
                if (_gameBoard[i, i] == player)
                {
                    piecesInForwardDiagonalCount++;
                }
                if (piecesInForwardDiagonalCount == _gameBoardSize)
                    return true;
            }

            int piecesInBackwardDiagonalCount = 0;
            int colIndex = _gameBoardSize - 1;
            for (int i = 0; i < _gameBoardSize; i++)
            {
                if (_gameBoard[i, colIndex - i] == player)
                {
                    piecesInBackwardDiagonalCount++;
                }
                if (piecesInBackwardDiagonalCount == _gameBoardSize)
                    return true;
            }

            return false;
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
            //bool didPlayerWin = DoesPlayerHaveCompleteRow(player) || DoesPlayerHaveCompleteCol(player) || DoesPlayerHaveCompleteDiagonal(player);
            if (_winner == 0)
            {
                _gameBoard[row, col] = player;
            }
            if (DoesPlayerHaveCompleteRow(player) || DoesPlayerHaveCompleteCol(player) || DoesPlayerHaveCompleteDiagonal(player))
            {
                _winner = player;
            }
            // return didPlayerWin ? player == 2 ? 2 : 1 : 0;
            return _winner;
        }
    }
}
