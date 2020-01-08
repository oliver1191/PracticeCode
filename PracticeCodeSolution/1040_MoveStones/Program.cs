using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1040_MoveStones
{
    class Program
    {
    //在一个长度无限的数轴上，第 i 颗石子的位置为 stones[i]。如果一颗石子的位置最小/最大，那么该石子被称作端点石子。

    //每个回合，你可以将一颗端点石子拿起并移动到一个未占用的位置，使得该石子不再是一颗端点石子。

    //值得注意的是，如果石子像 stones = [1, 2, 5]这样，你将无法移动位于位置 5 的端点石子，因为无论将它移动到任何位置（例如 0 或 3），该石子都仍然会是端点石子。

    //当你无法进行任何移动时，即，这些石子的位置连续时，游戏结束。

    //要使游戏结束，你可以执行的最小和最大移动次数分别是多少？ 以长度为 2 的数组形式返回答案：answer = [minimum_moves, maximum_moves] 。


        static void Main(string[] args)
        {
            int[] stones = new int[] {6,5,4,3,10};
            MoveStonesTool tool = new MoveStonesTool();
            var result=tool.numMovesStone(stones);
            Console.WriteLine("MinMove:{0},MaxMove:{1}",result[0],result[1]);            
            Console.ReadKey();
        }
    }
}
