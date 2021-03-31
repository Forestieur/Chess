

namespace Chess_1
{
    class Cell
    {
        private SetOfColors сolor;

        public Cell(SetOfColors Сolor)
        { 
            сolor = Сolor; 
        }

        public SetOfColors Сolor{ 
            get { return сolor; } 
            set { сolor = value; }
        }
        
    }

    enum SetOfColors
    {
        white,
        black
    }
}
