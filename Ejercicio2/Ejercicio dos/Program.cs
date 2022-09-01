using Ejercicio_dos.Entities;
//polimorfismo y caste (Atributos)
Entity ci = new Celulariphone(id:"1", serial:"FT45FIH", calidaddefotos:78);
var cil = (Celulariphone)ci;
Console.WriteLine(cil.Calidaddefotos);

//polimorfismo y caste (Metodos)
Entity cs = new Celularsamsung(id: "2", serial: "X45JHF");
var csl = (Celularsamsung)cs;
csl.ImprimirValores();


