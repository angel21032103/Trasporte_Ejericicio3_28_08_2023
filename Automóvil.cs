using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trasporte_Ejericicio3_28_08_2023
{
    internal class Automóvil : Transpote
    {

        #region Propiedades
        public override float Velocidad { 
            get => base.Velocidad;
            set
            {
                if (40 < value && value < 120)
                {
                    velocidad = value;
                    Console.WriteLine("Vas a una velocidad permitida\n");
                }
                else
                {
                    velocidad = 80;
                    Console.WriteLine("Exediste el limite de velocidad");
                }   
            } 
        }

        #endregion

        public Automóvil()
        {
            string modelo = "";
            string opcion = "";
            MostrarModelos();
            modelo = Console.ReadLine();
            MostarPrecio(modelo,1000);
            Console.WriteLine("Que deseas hacer, Acelerar o frenar: ");
            opcion=Console.ReadLine();

            if (opcion == "Acelerar")
            {
                //Console.WriteLine("Ingresa la velocidad a la que deseas ir: ");
                Velocidad = 110;
                Acelerar();
            }
            else
            {
                //Console.WriteLine("Ingresa la velocidad a que quieres reducir: ");
                Velocidad = 80;
                Frenar();
            }

            
            

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
