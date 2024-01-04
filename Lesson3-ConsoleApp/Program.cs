/*
int num1 = 0;
int num2 = 0;

greetings();
greetings();
void suma()
{
    int resultado = num1 + num2;
    Console.WriteLine($"la suma es: {resultado} ");
}

Console.WriteLine("Ingrese un numero: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

suma();


Console.ReadKey();



void greetings()
{
    Console.WriteLine("Hello im a function");
}

*/


/*
int passwordCreate = GetValidPassword();
int passwordVerification = GetPasswordVerification(passwordCreate);
char profile = GetProfile(passwordCreate, passwordVerification);

Console.ReadKey();


int GetValidPassword()
{
    int passwordCreate;

    while (true)
    {
        Console.WriteLine("Please create your password (numeric, at least 8 digits): ");
        passwordCreate = Convert.ToInt32(Console.ReadLine());

        if (passwordCreate.ToString().Length >= 8)
        {
            Console.WriteLine("Password saved");
            return passwordCreate;
        }
        else
        {
            Console.WriteLine("Incorrect password, please select a numeric password with 8 or more digits");
        }
    }
}

int GetPasswordVerification(int passwordCreate)
{
    int passwordVerification;

    while (true)
    {
        Console.WriteLine("Please enter your password to access the system: ");
        passwordVerification = Convert.ToInt32(Console.ReadLine());

        if (passwordCreate == passwordVerification)
        {
            Console.WriteLine("Password verified");
            return passwordVerification;
        }
        else
        {
            Console.WriteLine("Incorrect password, please try again");
        }
    }
}

char GetProfile(int passwordCreate, int passwordVerification)
{
    char profile;

    while (true)
    {
        Console.WriteLine("Please select your profile (A: Administrator, U: User, X: New Profile): ");
        profile = Convert.ToChar(Console.ReadLine());

        switch (profile)
        {
            case 'A':
                Console.WriteLine("Welcome Administrator");
                return profile;
            case 'U':
                Console.WriteLine("Welcome User");
                return profile;
            case 'X':
                Console.WriteLine("Welcome, undefined profile, please create your profile");
                return profile;
            default:
                Console.WriteLine("Invalid profile");
                break;
        }
    }
}
*/


// ACTIVIDAD COLABORATIVA

// una tienda desea realizar una venta y desea hacerlo a traves de una aplicacion.
//tenemos un listado de materiales 
//el cliente debe seleccionar el producto que desea comprar a traves del codigo.




using System.Xml.Schema;

string products = GetProducts();

string GetProducts()
{
    int price;
    int amount;
    int total;

    Console.WriteLine($"LISTA DE PRODUCTOS\n DETERGENTE \t\t PRECIO:{price = 300}\n JABON EN POLVO\t\t PRECIO:{price = 200}\n DETERGENTE\t\t PRECIO:{price = 250} ");

    string code;

    while (true)
    {
        Console.WriteLine("Porfavor seleccione el producto a comprar o confirme su compra:\n (DES: Desodorante, JP: Jabon en polvo, DET: Detergente, FIN: para confirmar su compra): ");
        code = Console.ReadLine();

        switch (code)
        {
            case "DES":
                price = 300;
                Console.WriteLine("Usted selecciono Desodorante.");
                Console.WriteLine($"El precio Desodorante es: {price}");
                Console.WriteLine("Por favor indique la cantidad que desea comprar");
                amount = Convert.ToInt32(Console.ReadLine());
                total = price * amount;
                Console.WriteLine($"El total a pagar es: {total}, Desea confirmar su compra?\n Para confirmar su compra introduzca el codigo FIN");

                break;
            case "JP":
                price = 200;
                Console.WriteLine("Usted selecciono Jabon en polvo.");
                Console.WriteLine($"El precio del Jabon en polvo es: {price}");
                Console.WriteLine("Por favor indique la cantidad que desea comprar");
                amount = Convert.ToInt32(Console.ReadLine());
                total = price * amount;
                Console.WriteLine($"El total a pagar es: {total}, Desea confirmar su compra?\n Para confirmar su compra introduzca el codigo FIN");

                break;
            case "DET":
                price = 250;
                Console.WriteLine("Usted selecciono Detergente.");
                Console.WriteLine($"El precio del Detergente es: {price}");
                Console.WriteLine("Por favor indique la cantidad que desea comprar");
                amount = Convert.ToInt32(Console.ReadLine());
                total = price * amount;
                Console.WriteLine($"El total a pagar es: {total}, Desea confirmar su compra?\n Para confirmar su compra introduzca el codigo FIN");

                break;

            case "FIN":
                Console.WriteLine("Por favor vuelva a ingresar la cantidad deseada");
                amount = Convert.ToInt32(Console.ReadLine());
                total = price * amount;
                Console.WriteLine($"Compra confirmada el total a pagar es: {total}");
                return code;

            default:
                Console.WriteLine("Invalid product");
                break;
        }
    }
}
