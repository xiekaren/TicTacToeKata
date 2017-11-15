using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Board
    {
        private readonly string _grid;

        public Board(string input)
        {
            _grid = input;
        }

        public List<string> GetDiagonals()
        {
            var middle = _grid.Length / 2;

            var diagonal1 = "";
            diagonal1 += _grid[middle - middle];
            diagonal1 += _grid[middle];
            diagonal1 += _grid[middle + middle];

            var diagonal2 = "";
            diagonal2 += _grid[middle - middle / 2];
            diagonal2 += _grid[middle];
            diagonal2 += _grid[middle + middle / 2];

            return new List<string> {diagonal1, diagonal2};
        }

        public List<string> GetRows()
        {
            var result = new List<string>();
            foreach (var i in Enumerable.Range(0, _grid.Length / 3))
            {
                result.Add(_grid.Substring(i * 3, 3));
            }
            return result;
        }

        public List<string> GetColumns()
        {
            var result = new List<string>();
            for (var column = 0; column < 3; column++)
            {
                var columnLine = "";
                for (var row = 0; row < 3; row++)
                {
                    columnLine += _grid[column + row * 3];
                }
                result.Add(columnLine);
            }
            return result;
        }
    }
}
