using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Piskvorky.Data
{
    public class Pole
    {
        public Space[,] _Pole;

        public Pole()
        {
            _Pole = new Space[10, 10];
            for (int i = 0; i < Math.Sqrt(_Pole.Length); i++)
            {
                for (int s = 0; s < Math.Sqrt(_Pole.Length); s++)
                {
                    _Pole[i, s] = new Space()
                    {

                    };
                }
            }
        }
    }
}
