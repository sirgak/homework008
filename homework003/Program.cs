using System;

namespace homework003
{
    class Program
    {
        static void Main(string[] args)
        {
            int pics = 52;
            int amountPicsInRow = 3;
            int picsRow = pics / amountPicsInRow;
            int picsRemainder = pics % amountPicsInRow ;
            Console.WriteLine("Количество заполненных рядов " + picsRow);
            Console.WriteLine("Количество картин сверх меры " + picsRemainder);
        }
    }
}
