using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

List<Estudiantes> estudiantes = new List<Estudiantes>();

Console.Write("¿Cuántos estudiantes desea registrar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Estudiantes e = new Estudiantes();
    Console.WriteLine("\nEstudiante" + (i + 1));

    Console.Write("Nombre: ");
    e.nombre = Console.ReadLine();

    Console.Write("Nota 1: ");
    e.nota1 = double.Parse(Console.ReadLine());

    Console.Write("Nota 2: ");
    e.nota2 = double.Parse(Console.ReadLine());

    Console.Write("Nota 3: ");
    e.nota3 = double.Parse(Console.ReadLine());

    estudiantes.Add(e);
}

Console.WriteLine("-----LISTA DE ESTUDIANTES-----");
for (int i = 0;i < estudiantes.Count;i++)
{
    estudiantes[i].Mostrar();
}

double mejorPromedio = estudiantes[0].CalcularPromedio();
string mejorEstudiante = estudiantes[0].nombre;

for (int i = 1; i < estudiantes.Count; i++)
{
    if (estudiantes[i].CalcularPromedio() > mejorPromedio)
    {
        mejorPromedio = estudiantes[i].CalcularPromedio();
        mejorEstudiante = estudiantes[i].nombre;
    }
}

Console.WriteLine("El estudiante con el mejor promedio es: ");
Console.WriteLine("Promedio " + mejorPromedio);

class Estudiantes
{
    public string nombre;
    public double nota1;
    public double nota2;
    public double nota3;
    
    public double CalcularPromedio()
    {
        return (nota1 + nota2 + nota3) / 3;
    }
    public string Estado()
    {
        if (CalcularPromedio() >= 61)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprobado";
        }
    }
    public void Mostrar()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Promedio: " + CalcularPromedio());
        Console.WriteLine("Estado: " + Estado);
    }
}