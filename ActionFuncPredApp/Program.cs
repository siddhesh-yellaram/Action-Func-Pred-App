using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncPredApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Predicate
            Predicate<String> isLenGreater = isNameLengthGreater;
            Console.WriteLine(isLenGreater("Sachin Tendulkar"));

            //Using Anonymous Func 
            Predicate<int> isEvenNo = delegate (int no){
                return no % 2 == 0;
            };
            Console.WriteLine(isEvenNo(4));

            //Using Lamda Func
            Predicate<int> isPrimeNo = (no) =>
            {
                for(int i = 2; i < Math.Sqrt(no); i++)
                {
                    if (no % i != 0)
                        return true;
                }
                return false;
            };
            Console.WriteLine(isPrimeNo(13));

            //Using Func 
            Func<int, long, double> Add = addNumbers;
            Console.WriteLine(Add(12, 45));

            //Using Anonymous Func 
            Func<int, long, double> MultiNo = delegate (int n1, long n2){
                 return (double)n1 * n2;
            };
            Console.WriteLine(MultiNo(12, 30));

            //Using Lamda Func
            Func<int, long, double> DivideNo = (n1, n2) =>  {
                return (double)n1 / n2;
            };
            Console.WriteLine(DivideNo(4, 3));

            //Using action Func
            Action<int, int, int> Multiply = MultiplyNos;
            Multiply(12, 3, 4);

            //Using Anonymous Func 
            Action<int, long, long> Sub = delegate (int n1, long n2, long n3){
                  Console.WriteLine((n1 - n2 - n3));
             };
            Sub(40,2,1);

            //Using Lamda Func
            Action<double, int, long> Divide = (n1, n2, n3) =>{
                Console.WriteLine((n1 / n2) / n3);
             };
            Divide(12, 4, 3);

            Console.ReadLine();
        }

        static bool isNameLengthGreater(String name)
        {
            return name.Length > 8;
        }

        static double addNumbers(int n1, long n2)
        {
            return (double)n1 + n2;
        }

        static void MultiplyNos(int n1, int n2, int n3)
        {
            Console.WriteLine(n1 * n2 * n3);
        }
    }
}
