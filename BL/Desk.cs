using System.Collections.Generic;


namespace Chess_1
{
    class Desk 
    {
        private int width { get; set; }
        private int length { get; set; }
        
        public Cell[,] Cells { get; set; }
        //public Cell this[Cell] { get { return cels; } set; }
        private List<Cell> cels { get { if (cels.Capacity == 0) { return null; } else return this.cels; } set { if (value == null) { } else cels = value; } }
       // private List<Cell> Cel1() { return cels; }
        public List<Cell> Cellls
        {
            get { return cels; }
            
        }
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
          //  cels = new List<Cell>(width);
            
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
            
          /*  for (int i = 0; i < width; i++)
            {
                if (i % 2 == 0)
                    cels[i] = WhiteCell;
                else
                    cels[i] = BlackCell;
            }*/
            
        }
    }
}
