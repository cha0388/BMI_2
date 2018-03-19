using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White ;
            Console.ForegroundColor = ConsoleColor.DarkCyan ;
            Console.WriteLine ("＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝　　　　　　　") ;

            Console.WriteLine ("｜　　　　　　　　　請輸入身高：　　　　　　　　　　　　　｜　　　　　　　") ;
            String height = Console.ReadLine() ;
            float H = (float) int.Parse(height) / 100 ;

            Console.WriteLine ("｜　　　　　　　　　請輸入體重：　　　　　　　　　　　　　｜　　　　　　　") ;
            String weight = Console.ReadLine() ;

            float bmi =(int.Parse(weight) / (H * H));
            Console.WriteLine ("｜　　　　　　　　您的BMI值是" + bmi +"　 　　　 　　　　　 ｜　　　　　　　") ;

            if(bmi<18.5)
            {
                Console.WriteLine ("｜　　　　　　　　您的BMI值過低　　　　　　　 　　　　　　｜") ;
            }
            if (bmi > 24)
            {
                Console.WriteLine ("｜　　　　　　　　您的BMI值過高　　　　　　　 　　　　　　｜") ;
            }
            if (17 > bmi || bmi > 31)
            {
                Console.WriteLine ("｜　　　　　　　　　　您免役　　　　　　　　  　　　　　　｜") ;
            }
            else
            {
                Console.WriteLine ("｜　　　　　　　　您的BMI值正常　　　　　　　 　　　　　　｜") ;
            }
            Console.WriteLine ("＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝　　　　　　　") ;

            Console.ReadLine();

        }
    }
}
