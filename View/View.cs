using System;


namespace Chess_1
{
    class View 
    {                
        public int Input(string property)
        {            
            do
            {
                try
                {
                    Console.Write($"{property} - ");
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вводите значения в формате целого числа");
                }
            } while (true);
        }

        public void PrintDesk(Desk desk)
        {
           
            for (int i = 0; i <= desk.Cells.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= desk.Cells.GetUpperBound(1); j++)
                {                                       
                    if (desk.Cells[i, j].Сolor == SetOfColors.white)
                        Console.Write(" ");
                    if (desk.Cells[i, j].Сolor == SetOfColors.black)
                        Console.Write("*");                   
                }

                Console.WriteLine();
            }                      
        }
    }
}
