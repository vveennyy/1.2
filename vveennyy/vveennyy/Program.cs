using System;

namespace vveennyy
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание объекта класса
            Account account = new Account();
            //заполнение данными
            account.DataInput();
            //вывод на экран
            Console.WriteLine(account.ToString());
            Console.ReadKey();
        }
    }
}
