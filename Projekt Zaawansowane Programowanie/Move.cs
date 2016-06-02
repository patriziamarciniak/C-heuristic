using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Zaawansowane_Programowanie
{
    public class Move
    {

        int column;
        int index;

        public Move(int _column, int _index)
        {
            this.column = _column;
            this.index = _index;
        }

        public int getColumn()
        {
            return column;
        }
        public int getIndex()
        {
            return index;
        }

    }
}


