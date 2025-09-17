using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    internal class Program
    {
         /* 
     1) ¿Que sucede cuando una clase abstracta se hereda en otra clase abstracta ?
         Los metodos instanciados en la clase padre no necesitan ser sobreescritos en la clase hija.

     2) ¿Cuales son las propiedades y metodos de la clase Circunferencia?¿Porque tiene estos?
         Lo metodos de la clase Circunferencia son:
             -   CalcularPerimetro()
             -   CalcularArea()
             -   ObtenerPerimetro()
         Tiene estos porque hereda los primeros dos de la super clase Figura que al ser abtracta la clase Circunferencia tiene que sobreescribirlos
         
     3) ¿Cuales son las propiedades y metodos de la clase Equilatero?¿Porque tiene estos?
         Lo metodos de la clase Equilatero son:
             -   CalcularPerimetro()
             -   CalcularArea()
         Tiene estos porque hereda los primeros dos de la super clase Figura que al ser abtracta la clase Equilatero tiene que sobreescribirlos
         
     4) ¿Al instanciar una clase Cuadrado, es valido hacerlo de la siguiente manera?¿Por que?
         Si, es valido instanciarlo de esa manera. Pero no debemos olvidar luego sobreescribir los metodos.

     5) ¿A que pilar de la POO esta ligado el punto 4?
         Esta ligada a la Herencia y la Abstraccion.
  */
        static void Main(string[] args)
        {

        }
    }
}
