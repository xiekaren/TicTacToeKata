﻿using System;
using System.Text;

namespace TicTacToe
{
    public class TicTacToe
    {
        public int Solve(string board)
        {
            return board.IndexOf(" ", StringComparison.Ordinal);
        }

        public string MakePlay(string board, string token, int position)
        {
            var newBoard = new StringBuilder(board) {[position] = char.Parse(token)};
            return newBoard.ToString();
        }

        public bool IsValidPlay(string board, int position)
        {
            if (position >= board.Length || position < 0)
            {
                throw new ArgumentException("Position is not on the board.");
            }

            if (board[position] != ' ')
            {
                throw new ArgumentException("Position has been taken.");
            }

            return true;
        }
    }
}