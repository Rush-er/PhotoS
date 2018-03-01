using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoS
{
    public static class Distruggi
    {
        public static Color Dist(Color p)
        {
            Random rand = new Random();

            int a = rand.Next(256);
            int r = rand.Next(256);
            int g = rand.Next(256);
            int b = rand.Next(256);

            return Color.FromArgb(a,r, g, b);

        }
    }

    }
