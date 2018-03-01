using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoS
{
    public static class Grigio
    {
        public static Color Grigg(Color p)
        {
            int a = p.A;
            int r = p.R;
            int g = p.G;
            int b = p.B;
            int avg = (r + g + b) / 3;

            return Color.FromArgb(a, avg, avg, avg);        
        }
    }
}
