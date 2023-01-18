using System;

namespace LambdaOperator
{
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegateAdd;
            MyDelegate myDelegateSub;
            MyDelegate myDelegateMul;
            MyDelegate myDelegateDiv;

            myDelegateAdd = (a, b) => { return a + b; };
            myDelegateSub = (a, b) => { return a - b; };
            myDelegateMul = (a, b) => { return a * b; };
            myDelegateSub = (a, b) =>
            {
                if (b == 0)
                {
                    Console.WriteLine("Делить на 0 нельзя! Измените значение b");
                    throw new Exception();
                }

                return a / b;
            };

            var resultAdd = myDelegateAdd(5, 9);
            var resultSub = myDelegateSub(29, 3);
            var resultMul = myDelegateMul(24, 2);
            var resultDiv = myDelegateSub(10, 2);

            Console.WriteLine("{0} {1} {2} {3}", resultAdd, resultSub, resultMul, resultDiv);
        }
    }
}
