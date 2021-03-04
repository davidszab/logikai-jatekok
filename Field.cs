using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logikai_jatekok
{
    struct Field
    {
        public Panel panel;
        public int minesNearby; // -1 if the Field is mine
        public bool isRevealed;
        public bool isFlaged;
    }
}
