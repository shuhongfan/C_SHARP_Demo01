using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_24
{
    class TestCard
    {
        static void Main(string[] args)
        {
            int i, j, temp;
            Random Rnd = new Random();              // 随机数生成器
            int k;
            int[] Card = new int[52];
            int[,] Player = new int[4, 13];
            for (i = 0; i < 4; i++)              	//  52张牌初始化
                for (j = 0; j < 13; j++)
                    Card[i * 13 + j] = (i + 1) * 100 + j + 1;
            Console.Write("要洗几次牌: ");
            string s = Console.ReadLine();
            int times = Convert.ToInt32(s);
            for (j = 1; j <= times; j++)
                for (i = 0; i < 52; i++)
                {
                    k = Rnd.Next(51 - i + 1) + i;     // 产生i到52之间的随机数
                    temp = Card[i];
                    Card[i] = Card[k];
                    Card[k] = temp;
                }
            k = 0;
            for (j = 0; j < 13; j++)       			//  52张牌分发给4个玩家
                for (i = 0; i < 4; i++)
                    Player[i, j] = Card[k++];
            for (i = 0; i < 4; i++)       			// 显示4个玩家的牌
            {
                Console.WriteLine("玩家{0}的牌：", i + 1);
                for (j = 0; j < 13; j++)
                {
                    k = (int)Player[i, j] / 100;   	// 分离出牌的种类
                    switch (k)
                    {
                        case 1:         	// 红桃
                            s = Convert.ToString('\x0003');
                            break;
                        case 2:         	// 方块
                            s = Convert.ToString('\x0004');
                            break;
                        case 3:        		// 梅花
                            s = Convert.ToString('\x0005');
                            break;
                        case 4:       		// 黑桃
                            s = Convert.ToString('\x0006');
                            break;
                    }
                    k = Player[i, j] % 100;    	// 分离出牌号
                    switch (k)
                    {
                        case 1:
                            s = s + "A";
                            break;
                        case 11:
                            s = s + "J";
                            break;
                        case 12:
                            s = s + "Q";
                            break;
                        case 13:
                            s = s + "K";
                            break;
                        default:
                            s = s + Convert.ToString(k);
                            break;
                    }
                    Console.Write(s);
                    if (j < 12)
                        Console.Write(", ");
                    else
                        Console.WriteLine(" ");
                }
            }
            Console.Read();
        }
    }
}
