using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Game
    {
        private bool _gameOver = false;
        private Board _gameBoard;
        private static int _currentScene;
        private static int _sceneCount = 2;

        /// <summary>
        /// Begine the game.
        /// </summary>
        public void Run()
        {
            Start();

            while (!_gameOver)
            {
                Draw();
                Update();
            }

            End();
        }

        /// <summary>
        /// Called when the game starts.
        /// </summary>
        public void Start()
        {
            _gameBoard = new Board();
            _gameBoard.Start();
        }

        /// <summary>
        /// Called every tiem the game loops.
        /// </summary>
        public void Update()
        {
            switch(_currentScene)
            {
                case 0:
                    _gameBoard.Update();
                    break;
                case 1:
                    RestartGame();
                    break;
            }
            _gameBoard.Update();
        }

        /// <summary>
        /// Updates the display to reflect any changes made while running.
        /// </summary>
        private void Draw()
        {
            Console.Clear();
            _gameBoard.Draw();
        }

        /// <summary>
        /// Called when the game ends.
        /// </summary>
        public void End()
        {
            _gameBoard.End();
        }

        public void RestartGame()
        {
            Console.WriteLine("Restart? \n 1. Yes \n 2. No");
            int choice = GetInput();

            if (choice == 1)
            {
                _currentScene = 0;
                _gameBoard.InitializeBoard();
            }
            else if (choice == 2)
            {
                EndApplication();
            }
            else
            {

            }

        }

        public static int GetInput()
        {

            int choice = -1;
            
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

            return choice;
        }

        public static bool SetCurrentScene(int index)
        {
            if ( index < 0 || index > _sceneCount)
            {
                return false;
            }
            _currentScene = index;
            return true;
        }
    }
}
