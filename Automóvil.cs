using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trasporte_Ejericicio3_28_08_2023
{
    internal class Automóvil : Transpote
    {
        public Automóvil()
        {

            MostarPrecio("Ferrari",1000);
            Acelerar();
            Frenar();

        }

        #region Métodos
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
