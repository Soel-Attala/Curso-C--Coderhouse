


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