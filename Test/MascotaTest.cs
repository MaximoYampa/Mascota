using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca;

namespace Test;

public class MascotaTest
{
    public Mascota Mascota { get; set; }
    public IEstado IEstado { get; }

    private int nivel;

    public MascotaTest(IEstado IEstado , int nivel)
    {
        this.IEstado = IEstado;
        this.nivel = nivel;
    }
}