﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_dp
{
    class singleton_dp
    {
        public sealed class Rektor
        {
            private static Rektor? _instance;

            private Rektor()
            {
                Console.Write("Rektor baru dipilih");
            }

            public static Rektor GetRektor()
            {
                if (_instance == null)
                {
                    _instance = new Rektor();
                }
                return _instance;
            }
            public void Tandatangan()
            {
                Console.WriteLine("Rektor telah tanda tangan");
            }
        }
    }
}
