using System;
namespace Drill_226
{
    public class class1
    {
        public object squareNum(int int1)
        {
            int answer1 = int1 * int1;
            return answer1;
        }

        public object squareNum(decimal dec1)
        {
            decimal answer2 = dec1 * 3.141m;
            return (int)answer2;

        }

        public object squareNum(string str1)
        {
            int answer3 = Int32.Parse(str1);
            answer3 = answer3 * 300;

            return (int)answer3;

        }
    }
}
