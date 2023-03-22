class Pelicula
{
    private string? Titulo;
    private int Año;
    private string? Pais;
    private string? Director; 
    
    private List<Actor> actores = new List<Actor>();  //Campos privados

    public Pelicula (string titulo, int año, string pais, string director) {this.Titulo = titulo; this.Año = año; this.Pais=pais; this.Director = director;}

    public string? titulo { get => Titulo; set => Titulo = value; } public int año { get => Año; set => Año = value; } 
    public string? pais { get => Pais; set => Pais = value; } public string? director { get => Director; set => Director = value; }  //propiedades
    internal List<Actor> Actores { get => actores; set => actores = value; }

    public void Imprime() 
    {
        Console.WriteLine($" \n\n Pelicula: {titulo} \n Año de lanzamiento: {año} \n Pais de origen: {pais} \n Director: {director}");
        foreach (Actor a in actores)
        {
            a.Imprime();
        }
    }

    public void AgregaActor(Actor actor) {Actores.Add(actor);}
}

class Actor
{
    private string? Nombre;
    private int Año;

    public Actor (string nombre, int año) {this.Nombre = nombre; this.Año = año;}

    public string? nombre { get => Nombre; set => Nombre = value; } public int año { get => Año; set => Año = value; }

    public void Imprime() {Console.WriteLine($"\n Actor/a: \n {nombre}, {año}");}

}


class Inicio
{
    
     static void Main()
    {
     Pelicula p1 = new Pelicula ("La La Land",2016,"Estados Unidos","Damien Chazelle");

     p1.AgregaActor(new Actor("Ryan Gosling", 1980));
     p1.AgregaActor(new Actor("Emma Stone", 1988));

     Pelicula p2 = new Pelicula ("La forma del agua",2017,"Mexico","Guillermo Del Toro");

     p2.AgregaActor(new Actor("Sally Hawkins", 1976));
  

     p1.Imprime();
     p2.Imprime();

        
    }
}