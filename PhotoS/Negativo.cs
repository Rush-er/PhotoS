using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoS
{
    public static class Negativo
    {
        public static Color Nega(Color p)
        {
            int a = p.A;
            int r = p.R;
            int g = p.G;
            int b = p.B;
            
            r = 255 - r;
            g = 255 - g;
            b = 255 - b;

            return Color.FromArgb(r, g, b);
        }
    }
}
