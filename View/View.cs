using System;


namespace Chess_1
{
    class View 
    {                
        public void InputParameters(out int height, out int width)
        {
            Console.WriteLine("Введите длину и ширину через запятую");
            string parameters = Console.ReadLine();
            string[] destinationParametrs = parameters.Split(new char[] { ',' }, 2);

            
            if(!int.TryParse(destinationParametrs[1], out width))
            {
                throw new ArgumentException("Ширина не являются числом");
            }

            if (!int.TryParse(destinationParametrs[0], out height))
            {
                throw new ArgumentException("Длина не являются числом");
            }            
        }

        public void PrintDesk(Cell[,] cells)
        {
            for (int i = 0; i <= cells.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= cells.GetUpperBound(1); j++)
                {
                    if (cells[i, j].Сolor == SetOfColors.white)
                        Console.Write(" ");
                    if (cells[i, j].Сolor == SetOfColors.black)
                        Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
