using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Poligono : Figura
{
    private decimal _ladoUno = 0;
    private int _cantLados = 0;

}

// ------------- Heredan de Poligono -------------------
public class Cuadrado : Poligono{
    public override decimal CalcularPerimetro()
    {
        decimal numero = 0;
        return numero;
    }
    public override decimal CalcularArea()
    {
        decimal numero = 0;
        return numero;
    }
}
public class Rectangulo : Poligono{
    private decimal _lado2;
    public override decimal CalcularPerimetro()
    {
        decimal numero = 0;
        return numero;
    }
    public override decimal CalcularArea()
    {
        decimal numero = 0;
        return numero;
    }
}

// ----------------------------------------------

 public abstract class Triangulo : Poligono
{

    private decimal Base;
    private decimal Altura;
    public override decimal CalcularPerimetro()
    {
        decimal numero = 0;
        return numero;
    }
    public override decimal CalcularArea()
    {
        decimal numero = 0;
        return numero;
    }
}
// --------------- Heredan de Triangulo -----------------------
public class Equilatero : Triangulo {
    public override decimal CalcularPerimetro()
    {
        decimal numero = 0;
        return numero;
    }
    public override decimal CalcularArea()
    {
        decimal numero = 0;
        return numero;
    }
}
public class Isosceles : Triangulo{ 
    private decimal _lado2;
    public override decimal CalcularPerimetro()
    {
        decimal numero = 0;
        return numero;
    }
    public override decimal CalcularArea()
    {
        decimal numero = 0;
        return numero;
    }
}
