using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_200
    {
        public int NumIslands(char[][] grid)
        {
            int ans = 0;
            
            int m = grid.GetLength(0);
            int n = grid[1].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        ans++;
                        setone(grid, i, j);
                    }
                }
            }

            return ans;
        }

        public void setone(char[][] grid, int i, int j)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] != '1')
            {
                return;
            }
            grid[i][j] = '2';
            setone(grid, i + 1, j);
            setone(grid, i - 1, j);
            setone(grid, i, j+1);
            setone(grid, i, j);
        }
    }
}
