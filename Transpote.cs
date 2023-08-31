using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trasporte_Ejericicio3_28_08_2023
{
    internal abstract class Transpote
    {
        #region Atributos
        private string modelo;
        private float precio;
        internal float velocidad;

        #endregion

        #region Propiedades

        public string Tipo { get => modelo; set => modelo = value; }
        public float Precio { get => precio; set => precio = value; }
        public virtual float Velocidad
        {
            get => velocidad;
            set
            {
                if (0 < value && value < 50)
                    velocidad = value;
                else
                   velocidad =40; 
            }
        }

        #endregion

        #region Metodos

        public void MostrarModelos()
        {
            Console.WriteLine("Hola, bienvenido al concesionario GIL\n\nEstos son nuestros modelos:\n");
            Console.WriteLine("Ferrai\nNissan\nJohn Deere\nTafe\nElige el modelo de tu agrado: ");
        }

        public void MostarPrecio(string modelo, float precio)
        {
            switch(modelo)
            {
                case "Ferrari":
                    Console.WriteLine("\nEl Ferrari tiene un Precio: {0}\n", precio+800000);
                    break;

                case "Nissan":
                    Console.WriteLine("\nEl Nissan tiene un Precio: {0}\n", precio);
                    break;

                case "John Deere":
                    Console.WriteLine("\nEl John Deere tiene un Precio: {0}\n", precio+1000);
                    break;

                case " Tafe":
                    Console.WriteLine("\nEl Tafe tiene un Precio: {0}\n", precio+1500);
                    break;
                
                default:
                    Console.WriteLine("\nEsa marca no está en nuestra base de datos\n");
                    break;

            }
        }

        public virtual void Acelerar()
        {
            
            Console.WriteLine("En este momento estas acelerando a una velocidad de {0} km/h\n",Velocidad);


        } 


        public virtual void Frenar()
        {
            Console.WriteLine("En este momento estas frenando y estas a una velocidad de {0} km/h\n",Velocidad);

        }
        #endregion

    }
}
