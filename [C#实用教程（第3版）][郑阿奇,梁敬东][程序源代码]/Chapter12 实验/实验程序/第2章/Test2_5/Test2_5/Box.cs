using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2_5
{
    // 定义 IEnglishDimensions 和 IMetricDimensions 接口
    interface IEnglishDimensions
    {
        float Length();
        float Width();
    }
    interface IMetricDimensions
    {
        float Length();
        float Width();
    }
    // 从IEnglishDimensions 和 IMetricDimensions 接口派生类Box
    class Box:IEnglishDimensions,IMetricDimensions
    {
        float lengthInches;
        float widthInches;
        public Box(float length, float width)
        {
            lengthInches = length;
            widthInches = width;
        }
        float IEnglishDimensions.Length()
        {
            return lengthInches;
        }
        float IEnglishDimensions.Width()
        {
            return widthInches;
        }
        float IMetricDimensions.Length()
        {
            return lengthInches * 2.54f;
        }
        float IMetricDimensions.Width()
        {
            return widthInches * 2.54f;
        }
        //主程序
        static void Main(string[] args)
        {
            // 定义一个实类对象 "myBox":
            Box myBox = new Box(30.0f, 20.0f);
            // 定义一个接口"eDimensions"
            IEnglishDimensions eDimensions = (IEnglishDimensions)myBox;
            // 定义一个接口"mDimensions"
            IMetricDimensions mDimensions = (IMetricDimensions)myBox;
            // 输出
            Console.WriteLine(" Length(in): {0}", eDimensions.Length());
            Console.WriteLine(" Width (in): {0}", eDimensions.Width());
            Console.WriteLine(" Length(cm): {0}", mDimensions.Length());
            Console.WriteLine(" Width (cm): {0}", mDimensions.Width());
            Console.Read();
        }
    }
}
