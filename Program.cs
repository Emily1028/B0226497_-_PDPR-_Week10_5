using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR _Week10_5");
            int a, b;
            string c = null;
            string ans = "yes";
            while (ans == "yes")
            {
                Console.Write("請輸入第一個運算元:");
                a = int.Parse(Console.ReadLine());
                Console.Write("請輸入第二個運算元:");
                b = int.Parse(Console.ReadLine());
                Console.Write("請輸入運算子加(+)、減(-)、乘(*)、除(/)、餘數(%):");
                c = Console.ReadLine();
                if (c == "+")
                    Console.WriteLine("if計算結果:{0}+{1}={2}", a, b, a + b);
                switch (c)
                {
                    case "+":
                        Console.WriteLine("switch計算結果:{0}+{1}={2}", a, b, a + b);
                        break;
                }
                if (c == "-")
                    Console.WriteLine("if計算結果:{0}-{1}={2}", a, b, a - b);
                switch (c)
                {
                    case "-":
                        Console.WriteLine("switch計算結果:{0}-{1}={2}", a, b, a - b);
                        break;
                }
                if (c == "*")
                    Console.WriteLine("if計算結果:{0}*{1}={2}", a, b, a * b);
                switch (c)
                {
                    case "*":
                        Console.WriteLine("switch計算結果:{0}*{1}={2}", a, b, a * b);
                        break;
                }
                if (c == "/")
                    Console.WriteLine("if計算結果:{0}/{1}={2}", a, b, a / b);
                switch (c)
                {
                    case "/":
                        Console.WriteLine("switch計算結果:{0}/{1}={2}", a, b, a / b);
                        break;
                }
                if (c == "%")
                    Console.WriteLine("if計算結果:{0}%{1}={2}", a, b, a % b);
                switch (c)
                {
                    case "%":
                        Console.WriteLine("switch計算結果:{0}%{1}={2}", a, b, a % b);
                        break;
                }
                if (c != "+" && c != "-" && c != "*" && c != "/" && c != "%")
                    Console.WriteLine("if運算子錯誤!");
                switch (c)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "%":
                        break;
                    default:
                        Console.WriteLine("switch運算子錯誤!");
                        break;
                }
                Console.Write("請輸入\"yes\"繼續計算，其它任意鍵離開:");
                ans = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
