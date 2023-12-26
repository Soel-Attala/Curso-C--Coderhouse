/*


int productSold;
int productsInDeposit = 50;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos");
productSold = Convert.ToInt32(Console.ReadLine());

stock = productsInDeposit - productSold;

if (stock == 0)
{
    Console.WriteLine("se debe reponer stock");
    productsInDeposit += 10;
    Console.WriteLine("Se repusieron 10 nuevos productos");
}
else
{
    if (stock <= 5)
    {
        Console.WriteLine($"El stock esta al minimo, por favor reponer, productos actuales: {stock}");
        productsInDeposit += 20;
        Console.WriteLine("Se han agregado 20 productos al deposito");

    }
    Console.WriteLine($"Quedan {stock} productos en stock");
}

Console.ReadKey();
*/



/* Ejercicio 2: Supongamos que tenemos una lista de empleados y queremos:
 * Mostrar a que categoría corresponden segun su código a saber:
 * a - es Administrativo
 * b - es Profesional
 * c - es Maestranza
 * Ninguno de los anteriores es Sin Categoría
 * 
 * Observar el uso del ReadLine() en este caso al asignarse a una variable string que no fuera necesario convertir
 * 
 */

/*
string category;

Console.WriteLine("Please insert a category A, B or C");
category = Console.ReadLine();
switch (category)
{
    case "A":
        Console.WriteLine("Administrative employee");
        break;
    case "B":
        Console.WriteLine("Profesional employee");
        break;
    case "C":
        Console.WriteLine("Maestranza employee");
        break;
    default:
        Console.WriteLine("No category");
        break;
}

Console.ReadKey();

*/

/*La secretaria de una universidad nos pide un sistema para poder cargar los datos de sus alumnos, 
 * necesitan poder cargar la comisión que puede ser A si son de turno mañana, B si son de turno tarde, 
 * C si son de turno noche y en caso de no tener comisión indica que no tienen turno fijado.

También cada docente califica a sus alumnos con una nota entre 0 y 10, 
en caso de ser menor a 4 el alumno Recursa la Materia, si está entre 4 y 7 es Aprobó Cursada 
y si es mayor que 7 Promociona la Materia.
*/

string course;

Console.WriteLine("Please insert a course A,B or C");
Console.WriteLine("A. Morning course");
Console.WriteLine("B. Afternoon course");
Console.WriteLine("C. Night course");
Console.WriteLine("D. Not enrolled in any courses");

course = Console.ReadLine();

switch (course)
{
    case "A":
        Console.WriteLine("The student belongs to the morning shift course");
        break;
    case "B":
        Console.WriteLine("The student belongs to the afternoon shift course");
        break;
    case "C":
        Console.WriteLine("The student belongs to the night shift course");
        break;
    default:
        Console.WriteLine("This student is not enrolled in any courses");
        break;
}


int califications;
Console.WriteLine("Please instert the student calification: ");
califications = Convert.ToInt32(Console.ReadLine());

if (califications < 4)
{
    Console.WriteLine("The student must retake the course");
}
else if (califications >= 4 || califications <= 7)
{
    Console.WriteLine("The student has passed the course");
}
else
{
    Console.WriteLine("The student promoted the course");
}

Console.ReadKey();

