using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Figura
{
    public string _nombre {  get; set; }
    public abstract decimal CalcularPerimetro();
    public abstract decimal CalcularArea();
}
