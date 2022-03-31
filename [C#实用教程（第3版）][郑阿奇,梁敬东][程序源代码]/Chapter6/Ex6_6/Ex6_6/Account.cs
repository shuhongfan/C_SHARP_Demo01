using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex6_6
{
    class Account
    {
            int balance;                            	// 开始的位置
    Random r = new Random();
    public Account(int initial)
    {
        balance = initial;
    }
    private void Withdraw(int amount)
    {
        if (balance < 0)
        {
            throw new Exception("在0点下");  	//如果balance小于0则抛出异常
        }
        lock (this)
        {
            if (balance >= amount)
            {
                Console.WriteLine("修改前距0点的位置 :  " + balance);
                Console.WriteLine("修改位置值        : -" + amount);
                balance = balance - amount;
                Console.WriteLine("修改后距0点的位置 :  " + balance);
            }
        }
    }
    public void DoTransactions()
    {
        for (int i = 0; i < 100; i++)
        {
            Withdraw(r.Next(1, 100));     		// 调用Withdraw方法，参数为1到100的随机数
        }
    }

    }
}
