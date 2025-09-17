using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }







        /* --------------------------------------------------------------------- */
        public enum TipoMov {
            Aleatorio,
            Lineal
        }

        public interface IPersonaje {
            int _velocidad { get; set; }
            int _nivelVida { get; set; }
            TipoMov _tipoMovimiento { get; set; }
            void Moverse();
        }
       
        public interface IHeroe
        {
            bool _especial {  get; set; }
            void Encogerse();
            void Agarrar();
            void Atacar();
            void Agrandarse();

        }
        public interface IEnemigo { 
            void Agarrable();
        }
        public interface IDaño
        {
            void RecibeDaño();
            void Morir();
        }
        public interface ITroopa
        {
            void Retraerse();
            void rebotar();
            void Levantarse();
        }
        public interface IDireccionMov
        {
            void CambiarDireccion();
        }
        public interface IVolar
        {
            void Volar();
        }
        public interface ISalta
        {
            void Salta();
        }
        public interface IDetenerse
        {
            void Detenerse();
        }
        public class Mario : IPersonaje,IHeroe, IDaño, ISalta
        {
            public bool _especial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int _velocidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int _nivelVida { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            TipoMov IPersonaje._tipoMovimiento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Agarrar()
            {
                throw new NotImplementedException();
            }

            public void Agrandarse()
            {
                throw new NotImplementedException();
            }

            public void Atacar()
            {
                throw new NotImplementedException();
            }

            public void Encogerse()
            {
                throw new NotImplementedException();
            }

            public void Morir()
            {
                throw new NotImplementedException();
            }

            public void Moverse()
            {
                throw new NotImplementedException();
            }

            public void RecibeDaño()
            {
                throw new NotImplementedException();
            }

            public void Salta()
            {
                throw new NotImplementedException();
            }
        }
    }
}
