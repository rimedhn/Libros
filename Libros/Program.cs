

using System;

class Libros
{
    static void Main(string[] args)
    {
        // Crear libros
        Libro libro1 = new Libro("El Principito", "Antoine de Saint-Exupéry", 1943);
        Libro libro2 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 1967);
        Libro libro3 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605);

        // Crear personas
        Persona persona1 = new Persona("Sofía", "García", 25);
        Persona persona2 = new Persona("Juan", "Pérez", 30);

        // Crear estante y agregar libros
        Estante estante1 = new Estante(1, 5);
        estante1.LibrosEnEstante.Add(libro1);
        estante1.LibrosEnEstante.Add(libro2);
        estante1.LibrosEnEstante.Add(libro3);

        // Mostrar información de todos los libros
        Console.WriteLine("Información de los libros:");
        libro1.MostrarInformacion();
        libro2.MostrarInformacion();
        libro3.MostrarInformacion();
        Console.WriteLine();

        // Mostrar saludo de las personas
        Console.WriteLine("Saludos de las personas:");
        persona1.Saludar();
        persona2.Saludar();
        Console.WriteLine();

        // Mostrar contenido del estante
        Console.WriteLine("Contenido del estante:");
        estante1.MostrarContenido();

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
