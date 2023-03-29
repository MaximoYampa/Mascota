using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca;
using Xunit;

namespace Test;

public class MascotaTest
{
    public Mascota Mochi { get; set; }

    public MascotaTest()=> Mochi = new Mascota();

    [Fact]
    public void MochiAburridoPorDefecto()
    {
        Assert.IsType<Aburrido>(Mochi.estado);
    }

    [Fact]
    public void MochiAburridoJuega()
    {
        Mochi.Jugar();
        Assert.IsType<Contento>(Mochi.estado);
    }
}