using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Board
    {
        private char _player1Token;
        private char _player2Token;
        private char _currentToken;
        private bool _gameOver;
        private char[,] _board;

        /// <summary>
        /// Initializes player tokens and the game board
        /// </summary>
        public void Start()
        {
            _player1Token = 'x';
            _player2Token = 'o';
            _currentToken = _player1Token;
            _board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        }

        /// <summary>
        /// Gets the input from the player.
        /// Sets the player token at the desired spot in the 2D array.
        /// Checks if there is a winner.
        /// Changes the current token in play.
        /// </summary>
        public void Update()
        {
            Console.WriteLine("Please Choose slot.");
            
            bool gameBeingPlayed = false;
            int choice = Game.GetInput();

            while (!gameBeingPlayed)
            {
                if (choice == 1 && SetToken(_currentToken, 0, 0))
                {
                    gameBeingPlayed = true;
                    break;
                }
                else if (choice == 2 && SetToken(_currentToken, 0, 1))
                {
                    gameBeingPlayed = true;
                }
                else if (choice == 3 && SetToken(_currentToken, 0, 2))
                {
                    gameBeingPlayed = true;
                }
                else if (choice == 4 && SetToken(_currentToken, 1, 0))
                {
                    gameBeingPlayed = true;
                }
                else if (choice == 5 && SetToken(_currentToken, 1, 1))
                {
                    gameBeingPlayed = true;
                }
                else if (choice == 6 && SetToken(_currentToken, 1, 2))
                {
                    gameBeingPlayed = true;
                }
                else if (choice == 7 && SetToken(_currentToken, 2, 0))
                {
                    gameBeingPlayed = true;
                }
                else if (choice == 8 && SetToken(_currentToken, 2, 1))
                {
                    gameBeingPlayed = true;
                }
                else if (choice == 9 && SetToken(_currentToken, 2, 2))
                {
                    gameBeingPlayed = true;
                }
                

                if (_currentToken == _player1Token)
                {
                    _currentToken = _player2Token;
                }
                else
                {
                    _currentToken = _player1Token;
                }
                
            }
        }

        /// <summary>
        /// Draws the board and let's the players know whose turn it is.
        /// </summary>
        public void Draw()
        {
            Console.WriteLine(_board[0, 0] + " | " + _board[0, 1] + " | " + _board[0, 2] + "\n" +
                                                  "__________ \n" +
                              _board[1, 0] + " | " + _board[1, 1] + " | " + _board[1, 2] + "\n" +
                                                  "__________ \n" +
                              _board[2, 0] + " | " + _board[2, 1] + " | " + _board[2, 2]);
        }

        public void End()
        {
            _gameOver = true;
        }

        /// <summary>
        /// Assigns the spot at the given indices int the board array to be the given token.
        /// </summary>
        /// <param name="token">The token to set the array index to.</param>
        /// <param name="posX">The x position of the token</param>
        /// <param name="posY">The y position of the token</param>
        /// <returns>Return false if the indices are out of range.</returns>
        public bool SetToken(char token, int posX, int posY)
        {
            /*
            int index = 0;
            posX = index / 3;
            posY = index % 3;
            */

            int choice;

            if (int.TryParse(_board[posX,posY].ToString(), out choice))
            {
                _board[posX, posY] = token;
                return true;
            }
            else
            {
                Console.WriteLine("A player has already choosen this slot!");
                
            }

            return false;
        }

        /// <summary>
        /// Checks to see if the token appears three times consecutively vertically, horizontally, or diagonally.
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Returns false if there is not a winner</returns>
        private bool CheckWinner(char token)
        {
            return false;
        }

        /// <summary>
        /// Resets the board to it's default state.
        /// </summary>
        public void ClearBoard()
        {
            _board = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        }
    }
}
