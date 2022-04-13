using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class Jugador
    {
        public float vel;


        public int BombasMax;
        public int CantidadBombas;

        public float tiempoExp;
        public int RangoExp;
        public void mover()
        {

        }
        public void ColocarBombas(float tiempo, int rango)
        {
            //si la cantidad de bombas es mayor a 0 
                //colocar bomba con rango y tiempo de exp
                //CantidadBombas--
        }
        public void RecargarBombas()
        {
            //CantidadBombas++
        }
        public void RecibirDmg()
        {
            //perder
        }
        public void RecogerPowerUp(int tipo)
        {
            switch (tipo)
            {
                case 0: //aumentar rango
                    break;
                case 1: //reducir tiempo
                    break;
               
                default:
                    break;
            }
        }
    }
}
