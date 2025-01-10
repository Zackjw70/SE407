using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmatics
{
    public class AdvancedMath
    {
        public double Area(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Average(List<double> nums) 
        {
            double num = 0;
            for (int i = 0; i < nums.Count; i++) {
                num += nums[i];

            }
            num = num / nums.Count;
            return num;
        }
        public double Square(double num1)
        {
            return num1 * num1;
        }
        public double Pythag(double num1, double num2) {
            double num = Square(num1) + Square(num2);    
            return Math.Sqrt(num);
        }
    }
}
