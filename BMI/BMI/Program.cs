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
            //設定後景色為白色、前景色為暗青色
            Console.BackgroundColor = ConsoleColor.White ;
            Console.ForegroundColor = ConsoleColor.DarkCyan ;
            Console.WriteLine ("＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝　　　　　　　") ;

            //提示用戶輸入身高，將輸入的身高除以100設為浮點數H
            Console.WriteLine ("｜　　　　　　　　　請輸入身高：　　　　　　　　　　　　　｜　　　　　　　") ;
            String height = Console.ReadLine() ;
            float H = (float) int.Parse(height) / 100 ;

            //提示用戶輸入體重
            Console.WriteLine ("｜　　　　　　　　　請輸入體重：　　　　　　　　　　　　　｜　　　　　　　") ;
            String weight = Console.ReadLine() ;

            //計算並顯示其BMI值
            float bmi =(int.Parse(weight) / (H * H));
            Console.WriteLine ("｜　　　　　　　　您的BMI值是" + bmi +"　 　　　 　　　　　 ｜　　　　　　　") ;

            //偵測並顯示BMI所屬範圍
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
                Console.WriteLine ("｜　　　　　　　　您的BMI值正常　　　　　　　 　　　　　　｜              ") ;
            }
            Console.WriteLine ("＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝　　　　　　　") ;

            //防止自動跳出此頁面
            Console.ReadLine();

        }
    }
}
