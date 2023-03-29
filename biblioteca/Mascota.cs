namespace biblioteca;
public class Mascota
{
    public int nivel {get;set;}
    public IEstado estado {get; private set;} 
    public Mascota (IEstado estado, int nivel)
    {
        this.nivel = nivel;
        this.estado = estado;
    }

    public void Jugar()
    {

    }

    public void Comer()
    {

    }

    internal void CambiarEstado(IEstado estado)
    {

    }

    public void Incrementar(int unidad) 
    {
        nivel = nivel+unidad;
    }
        
}
