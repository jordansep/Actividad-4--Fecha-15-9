using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Poligono : Figura
{
    public decimal _ladoUno {  get; set; }
    public int _cantLados {  get; set; }

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
    public decimal _lado2 {  get; set; }
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

    public decimal Base{get; set;}
    public decimal Altura { get; set; }
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
    public decimal _lado2 { get; set; }
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
