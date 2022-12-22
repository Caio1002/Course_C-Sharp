using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj {
    internal class CalcParams {

        /*
            MAIN
            int s1 = CalcParams.Sum(2, 3);
            Console.WriteLine(s1);

            int s2 = CalcParams.Sum(2, 3, 4);
            Console.WriteLine(s2);
            */

        public static int Sum(params int[] numbers) {
            int sum = 0;
            for(int i=0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
