using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1040_MoveStones
{
    class MoveStonesTool
    {
        public int[] numMovesStone(int[] stones)
        {            
            int maxMove = 0;
            Array.Sort(stones);
            int n = stones.Length;
            int noValueLength = stones[n - 1] - stones[0] + 1 - n;
            maxMove = noValueLength - Math.Min(stones[n-1]-stones[n-2] + 1 - 2, stones[1]-stones[0]+1-2);
            int minMove = n;
            for (int i = 0, j = 0; j < n; ++j)
            {
                //当前窗口的大小大于n
                while (stones[j] - stones[i] + 1 > n) i++;

                //当前窗口的石子个数
                int already_stone = (j - i + 1);

                //前n-1个石子的顺序连续，最后一个石子不连续，需要移动2步。
                //比如3 4 5 6 10，我们不能直接将10变为2，而是将3变为8，然后10变为7来移动
                if (already_stone == n - 1 && stones[j] - stones[i] + 1 == n - 1)
                {
                    minMove = Math.Min(minMove, 2);
                }
                else
                {
                    minMove = Math.Min(minMove, n - already_stone);
                }
            }
                
            return  new int[2]{ minMove, maxMove };
        }         
    }
}
