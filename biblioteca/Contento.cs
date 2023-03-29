namespace biblioteca;

public class Contento : IEstado
{
    public void Comer(Mascota mascota) => mascota.nivel +=1;


    public void Jugar(Mascota mascota) => mascota.nivel += 2;

}
