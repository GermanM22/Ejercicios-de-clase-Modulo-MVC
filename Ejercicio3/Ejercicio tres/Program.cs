// See https://aka.ms/new-console-template for more information
using Ejercicio_tres.Celulares;
using Ejercicio_tres.Perifericos;
Console.WriteLine("Hello, World!");

IPeriferico periferico = new Audifono();

Celular celular = new Celular(periferico);
