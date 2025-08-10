

using System;
using System.Collections.Generic;

public class Estante
{
    public int NumeroEstante { get; set; }
    public int CapacidadMaxima { get; set; }
    public List<Libro> LibrosEnEstante { get; set; }

    public Estante(int numeroEstante, int capacidadMaxima)
    {
        NumeroEstante = numeroEstante;
        CapacidadMaxima = capacidadMaxima;
        LibrosEnEstante = new List<Libro>();
    }

    public void MostrarContenido()
    {
        Console.WriteLine($"Estante N°: {NumeroEstante} (Capacidad: {CapacidadMaxima} libros)");
        if (LibrosEnEstante.Count == 0)
        {
            Console.WriteLine("El estante está vacío.");
        }
        else
        {
            Console.WriteLine("Libros en el estante:");
            foreach (var libro in LibrosEnEstante)
            {
                libro.MostrarInformacion();
            }
        }
    }
}

