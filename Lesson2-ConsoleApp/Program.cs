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


