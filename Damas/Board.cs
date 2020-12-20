using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Damas {
    public interface Board {
        Piece Piece { get; set; }
        char Matrix { get; set; }

        void Dispay();
    }
}