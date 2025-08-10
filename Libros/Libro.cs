

using System;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AñoPublicacion { get; set; }

    public Libro(string titulo, string autor, int añoPublicacion)
    {
        Titulo = titulo;
        Autor = autor;
        AñoPublicacion = añoPublicacion;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Año: {AñoPublicacion}");
    }
}
