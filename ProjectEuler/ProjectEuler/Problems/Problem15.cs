using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    class Problem15 : Problem
    {        
        public override string name { get { return "Problem 15"; } }
        public override string description { get { return "Lattice paths"; } }

        public override object execute()
        {
            const int gridSize = 20;
            long[,] grid = new long[gridSize + 1, gridSize + 1];

            //Initialise the grid with boundary conditions
            for (int i = 0; i < gridSize; i++)
            {
                grid[i, gridSize] = 1;
                grid[gridSize, i] = 1;
            }
            for (int i = gridSize - 1; i >= 0; i--)
            {
                for (int j = gridSize - 1; j >= 0; j--)
                {
                    grid[i, j] = grid[i + 1, j] + grid[i, j + 1];
                }
            }
            return grid[0, 0];
        }
    }
}
