using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trasporte_Ejericicio3_28_08_2023
{
    internal class Tractor : Transpote
    {
        public Tractor()
        {
            MostarPrecio("Tafe", 1000);
            Acelerar();
            Frenar();
        }

        #region Metodos
        public override void Acelerar()
        {
            base.Acelerar();
        }

        public override void Frenar()
        {
            base.Frenar();
        }

        #endregion
    }
}
