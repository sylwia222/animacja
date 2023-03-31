﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektN1_Karpowicz61959
{
    internal class EkstremumSzeregu
    {
        public static double MinSX(double[,] TWS)
        {// 
            double AktualneMin;
            //
            AktualneMin = TWS[0, 1];
            //
            for (int i = 0; i < TWS.GetLength(0); i++)
                if (AktualneMin > TWS[i, 1])
                    // został znaleziony element mniejszy od AktualneMin i ten będzie nową wartością AktualneMin
                    AktualneMin = TWS[i, 1];
            // zwrotne przekazanie wartości minimalnej szeregu potęgowego
            return AktualneMin;
        }
        public static double MaxSX(double[,] TWS)
        {// deklaracja pomocnicza
            double AktualneMax;
            // ustalenie stanu początkowego
            AktualneMax = TWS[0, 1];
            // analiza TWS i szukanie wartości maksymalnej S(X)
            for (int i = 0; i < TWS.GetLength(0); i++)
                if (AktualneMax < TWS[i, 1])
                    AktualneMax = TWS[i, 1];
            // zwrotne przekazanie wartości maksymalnej szeregu
            return AktualneMax;
        }
    }
}
