﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Game
    {
        private bool _gameOver = false;
        private Board _gameBoard;

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

        public static int GetInput()
        {
            int choice = -1;
            __gameBoard = new Board();
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

            return choice;
        }
    }
}