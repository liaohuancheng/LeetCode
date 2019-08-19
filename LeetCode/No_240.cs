using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class No_240
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix.Length == 0)
                return false;
            int i = matrix.GetLength(0)-1;
            int j = 0;
            while(true)
            {
                if (target == matrix[i, j])
                {
                    return true;
                }
                else if (target > matrix[i, j])
                {
                    j++;
                }
                else if (target < matrix[i, j])
                {
                    i--;
                }
                
                if (i <0  || j >= matrix.GetLength(1))
                    return false;
            }
            
        }
    }
}
