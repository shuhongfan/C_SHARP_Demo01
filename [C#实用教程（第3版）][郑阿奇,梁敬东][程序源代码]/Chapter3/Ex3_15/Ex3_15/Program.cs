using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_15
{
    class cashRegister
    {
        int numItems;           	// 商品总数
        double cost;　          	//  商品单价
        static double cashSum;   	// cashSum是静态变量，即销售总额   
        public cashRegister(int numItems, double cost)
        {
            this.numItems = numItems;
            this.cost = cost;
        }
        public cashRegister()
        {
            numItems = 0;
            cost = 0.0;
        }
        static cashRegister()
        {
            cashSum = 0.0;
            //  this.cashSum=0.0;      错误，静态方法不允许使用this
        }
        public void makeSale(int num)    	// 实例方法
        {
            this.numItems -= num;
            cashSum += cost * num;      	// 实例方法可以访问静态成员
        }
        public static double productCost()  	// 静态方法，只能访问静态成员
        {
            return cashSum;
            //  return this.cashSum;  错误，静态方法不能使用this
        }
        public int productCount()
        {
            return numItems;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            cashRegister Candy = new cashRegister(200, 1);
            cashRegister Chips = new cashRegister(500, 3.5);
            Candy.makeSale(5);
            Console.Write("Candy.numItems={0} ", Candy.productCount());
            // 调用实例方法与对象Candy相关联
            Console.WriteLine("cashSum={0} ", cashRegister.productCost());
            // 调用静态方法与类cashRegister相关联
            Chips.makeSale(10);
            Console.Write("Chips.numItems={0} ", Chips.productCount());
            // 调用实例方法与对象Chips相关联
            Console.WriteLine("cashSum={0} ", cashRegister.productCost());
            // cashSum即Candy和Chips售出总价
            Console.Read();
        }
    }
}
