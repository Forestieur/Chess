using System.Collections.Generic;
using System.Diagnostics;
using System;


namespace Chess_1
{
    class Desk 
    {
        private int _width;
        private int _length;
              

        public Desk(int Length, int Width)
        {            
            _width = Width;
            _length = Length;           
        }

        public void MakeBoard(out Cell[,] Cells)
        {
            Cells = new Cell[_length, _width];
            Cell WhiteCell = new Cell(SetOfColors.white);
            Cell BlackCell = new Cell(SetOfColors.black);


            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _width; j++)
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
