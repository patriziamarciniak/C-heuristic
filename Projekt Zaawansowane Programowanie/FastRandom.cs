using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Zaawansowane_Programowanie
{

        public class FastRandom
        {
            const double REAL_UNIT_INT = 1.0 / ((double)int.MaxValue + 1.0);
            const double REAL_UNIT_UINT = 1.0 / ((double)uint.MaxValue + 1.0);
            const uint Y = 842502087, Z = 3579807591, W = 273326509;

            uint x, y, z, w;

            public FastRandom()
            {
                Reinitialise((int)Environment.TickCount);
            }

            public void Reinitialise(int seed)
            {
                x = (uint)seed;
                y = Y;
                z = Z;
                w = W;
            }


            public int Next()
            {
                uint t = (x ^ (x << 11));
                x = y; y = z; z = w;
                w = (w ^ (w >> 19)) ^ (t ^ (t >> 8));


                uint rtn = w & 0x7FFFFFFF;
                if (rtn == 0x7FFFFFFF)
                    return Next();
                return (int)rtn;
            }
        public int Next(int lowerBound, int upperBound)
        {
            if (lowerBound > upperBound)
                throw new ArgumentOutOfRangeException("upperBound", upperBound, "upperBound must be >=lowerBound");

            uint t = (x ^ (x << 11));
            x = y; y = z; z = w;

            int range = upperBound - lowerBound;
            if (range < 0)
            {  	
                return lowerBound + (int)((REAL_UNIT_UINT * (double)(w = (w ^ (w >> 19)) ^ (t ^ (t >> 8)))) * (double)((long)upperBound - (long)lowerBound));
            }
            return lowerBound + (int)((REAL_UNIT_INT * (double)(int)(0x7FFFFFFF & (w = (w ^ (w >> 19)) ^ (t ^ (t >> 8))))) * (double)range);
        }

    }
    }

