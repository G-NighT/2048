using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_gridView
{
    public class UpdateMovesEventArgs : EventArgs
    {
        private int _moves;

        public UpdateMovesEventArgs(int Moves)
        {
            this._moves = Moves;
        }

        public int Moves
        {
            get { return _moves; }
            set { _moves = value; }
        }
    }
}
