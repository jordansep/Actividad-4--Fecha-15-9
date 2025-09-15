using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Conico : Figura {
    public decimal _radio {  get; set; }

}
// ---------------- Heredan de Conico ------------------------
public class Circunferencia : Conico
{
    public override decimal CalcularPerimetro() {
        decimal numero = 0;
        return numero;
    }
    public override decimal CalcularArea()
    {
        decimal numero = 0;
        return numero;
    }

    private decimal _diametro;
    public decimal ObtenerDiametro()
    {
        decimal diametro = 0;
        this._diametro = diametro;
        return diametro;
    }
}
public class Elipse : Conico
{

    public decimal _radioMayor {get;set;}
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

