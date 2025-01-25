using Assignment_03.Part_02;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.sum(2, 2));
            Console.WriteLine(calculator.sum(2.5,2.7));
            Console.WriteLine(calculator.sum(2,2,1));
            #endregion


            #region Q2) Create a class named Rectangle with the following constructors:

            //Console.WriteLine(DateTime.Now.Date);
            Duration D1 = new(1, 10, 15);
            Duration D2 = new(7800);
            //Console.WriteLine(D2);
            Duration D3=new(666);
            //D3 = D1 + D2;
            //Console.WriteLine(D3);
            //Duration D4 = D1 + 7800;
            //Console.WriteLine(D4);
            //Duration D5 = 666 + D1;
            //Console.WriteLine(D5);
            //Duration D6 = ++D1;
            //Console.WriteLine(D6);
            //D3 = --D1;
            //Console.WriteLine(D3);
            D1 = D1 - D2;
            Console.WriteLine(D1);
            DateTime obj = (DateTime)D1;
            Console.WriteLine(obj.ToString());

            #endregion
        }
    }
}