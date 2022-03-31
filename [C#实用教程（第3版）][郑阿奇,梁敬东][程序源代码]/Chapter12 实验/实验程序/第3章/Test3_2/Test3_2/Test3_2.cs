using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test3_2
{
    class Card
    {
        long cardNo;                // 卡号
        decimal balance;            // 余额
        int currentNum;             // 当日业务实际发生笔数
        static int number;          // 每张卡允许当日存款或取款的总次数
        decimal[] currentMoney;     // 存放当日存取款金额,正值代表存款,负值代表取款
        public Card()
        {
            currentMoney = new decimal[number];
        }
        public Card(long No, decimal Balance)
        {
            cardNo = No;
            balance = Balance;
            currentMoney = new decimal[number];
        }
        public void store(decimal Money,out int status)
        {
            if (currentNum == number)           // 本卡已达当日允许的业务次数
            {
                status = 0;
                return;
            }
            if (balance + Money < 0)
            {
                status = -1;                    // 存款余额不足,不能完成本次的取款业务
                return;
            }
            currentMoney[currentNum] = Money;   // 记录当日存取款金额
            balance += Money;                   // 更新当前余额
            currentNum++;                       // 当日业务次数加1
            status = 1;                         // 成功处理完当前业务
        }
        public void show()
        {
            Console.WriteLine("卡号：{0},  当前余额：{1}, 当日发生业务的次数：{2}", cardNo, balance, currentNum);
            for (int i = 0; i < currentNum; i++)
            {
                Console.WriteLine("当日存款/取款的情况：{0}", currentMoney[i]);
            }
        }
        static public int Number                // 设置允许当日存款或取款的总次数
        {
            set
            {
                number = value;
            }
        }
        public long CardNo                      // 设置CardNo属性是为了查看卡号
        {
            get
            {
                return cardNo;
            }
        }
    }

    class Test3_2
    {
        static void Main(string[] args)
        {
            Test3_2 T = new Test3_2();
            Card[] person;
            int Num, status, k;
            long CardNo;
            decimal Balance, Money;
            Console.Write("请输入允许当日存款或取款的总次数： ");
            string sline = Console.ReadLine();
            Card.Number = int.Parse(sline);
            Console.Write("请输入某银行发出的储蓄卡总数： ");
            sline = Console.ReadLine();
            Num = int.Parse(sline);
            person = new Card[Num];
            for (int i = 0; i < Num; i++)
            {
                Console.Write("请输入卡号： ");
                sline = Console.ReadLine();
                CardNo = long.Parse(sline);
                Console.Write("请输入{0} 账户余额： ", CardNo);
                sline = Console.ReadLine();
                Balance = decimal.Parse(sline);
                person[i] = new Card(CardNo, Balance);
            }
            while(true)
            {
                Console.WriteLine("现在正进行存款取款的业务处理,如果输入的卡号<0，则结束业务处理");
                Console.Write("请输入卡号： ");
                sline = Console.ReadLine();
                CardNo = long.Parse(sline);
                if (CardNo < 0)
                    break;
                k = T.Locate(person, CardNo);
                if (k == -1)
                {
                    Console.WriteLine("对不起，不存在{0}号的储蓄卡", CardNo);
                    continue;
                }
                Console.WriteLine("请输入卡金额（正值代表存款，负值代表取款）：");
                sline = Console.ReadLine();
                Money = decimal.Parse(sline);
                person[k].store(Money, out status);
                switch(status)
                {
                    case -1:
                        Console.WriteLine("存款余额不足,不能完成本次的取款业务");
                        break;
                    case 0:
                        Console.WriteLine("本卡已达当日允许的业务次数");
                        break;
                    case 1:
                        Console.WriteLine("成功处理完当前业务");
                        person[k].show();
                        break;
                }
            }
        }

        int Locate(Card[] person, long cardNo)
        {
            int index = -1;
            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].CardNo == cardNo)
                {
                    index = i;
                }                
            }
            return index;
        }
    }
}
