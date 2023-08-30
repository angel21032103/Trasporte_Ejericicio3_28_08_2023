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
        private float velocidad;

        public string Tipo { get => modelo; set => modelo = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Velocidad { get => velocidad; set => velocidad = value; }
        #endregion

        #region Metodos
        
        public void MostarPrecio(string modelo, float precio)
        {
            switch(modelo)
            {
                case "Ferrari":
                    Console.WriteLine(" El Ferrari tiene un Precio: {0}", precio+800000);
                    break;

                case "Nissan":
                    Console.WriteLine("El Nissan tiene un Precio: {0}", precio);
                    break;

                case "John Deere":
                    Console.WriteLine("El John Deere tiene un Precio: {0}", precio+1000);
                    break;

                case " Tafe":
                    Console.WriteLine("El Tafe tiene un Precio: {0}", precio+1500);
                    break;
                
                default:
                    Console.WriteLine("Esa marca no está en nuestra base de datos");
                    break;

            }
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("En este momento estas acelerando\n");


        } 


        public virtual void Frenar()
        {
            Console.WriteLine("En este momento estas frenando\n");

        }
        #endregion

    }
}
