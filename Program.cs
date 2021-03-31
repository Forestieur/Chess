using System;


namespace Chess_1
{
    class Program
    {

        static void Main(string[] args)       
        {
            Console.WriteLine("Введите размер доски");
            View view = new View();
            Desk desk = new Desk(view.Input("Длина"), view.Input("Ширина"));
            desk.MakeBoard();
            view.PrintDesk(desk);       
            Console.ReadKey();            
        }
    }
}
