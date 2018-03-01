using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoS
{
    public static class Seppia
    {
        public static Color Sepp(Color p)
        {
            int a = p.A;
            int r = p.R;
            int g = p.G;
            int b = p.B;

            int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
            int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
            int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

            if (tr > 255)
            {
                r = 255;
            }
            else
            {
                r = tr;
            }

            if (tg > 255)
            {
                g = 255;
            }
            else
            {
                g = tg;
            }

            if (tb > 255)
            {
                b = 255;
            }
            else
            {
                b = tb;
            }

            return Color.FromArgb(r,g,b);
        }

    }
}
