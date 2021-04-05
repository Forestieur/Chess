using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_1
{
    class ConsoleOutput
    {
        private Desk _desk;
        private View _view;

        public void StartBoard()
        {
            int height, weight;
            Cell[,] cells;

            _view = new View();
            _view.InputParameters(out height, out weight);
            _desk = new Desk(height, weight);
            _desk.MakeBoard(out cells);
            _view.PrintDesk(cells);
        }
    }
}
