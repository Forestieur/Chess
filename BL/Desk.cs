

namespace Chess_1
{
    class Desk 
    {
        private int width { get; set; }
        private int length { get; set; }
        
        public Cell[,] Cells { get; set; }

        public Desk(int Length, int Width)
        {            
            width = Width;
            length = Length;           
        }

        public void MakeBoard()
        {
            Cells = new Cell[length, width];
            Cell WhiteCell = new Cell(SetOfColors.white);
            Cell BlackCell = new Cell(SetOfColors.black);
            
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Cells[i, j] = WhiteCell;
                        }
                        else
                        {
                            Cells[i, j] = BlackCell;
                        }
                    }
                    else
                    {
                        if (j % 2 == 1)
                        {
                            Cells[i, j] = WhiteCell;
                        }
                        else
                        {
                            Cells[i, j] = BlackCell;
                        }
                    }
                }
            }
            
        }
    }
}
