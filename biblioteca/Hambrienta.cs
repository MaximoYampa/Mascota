namespace biblioteca;

public class Hambrienta : IEstado
{

    public void Comer(Mascota mascota) => mascota.CambiarEstado(new Contento());
        
    

    public void Jugar(Mascota mascota)
    {

    }
}
