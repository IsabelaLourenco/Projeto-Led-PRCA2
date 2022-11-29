using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Leds_PRCA2
{
    class Leds
    {
        private byte estado;
        public Leds()
        {
            this.estado = 0;
        }
        public Leds(byte estado)
        {
            this.estado = estado;
        }
        public void acender(int Led)
        {
            this.estado = (byte)(
                (int)this.estado |
                (int)Math.Pow(2, Led - 1));
        }
        public void apagar(int Led)
        {
            this.estado = (byte)(
               (int)this.estado &
               (int)(255 - Math.Pow(2, Led - 1)));
        }
        public byte getEstado()
        {
            return this.estado;
        }

        public bool getEstado(int Led)
        {
            byte aux;
            aux = (byte)(
                (int)this.estado &
                 (int)(Math.Pow(2, Led)));
            return (aux > 0);
        }
    }
}
