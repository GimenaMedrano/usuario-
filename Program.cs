string clave = "abc", pwd;
int intentos = 3;

do
{
    Console.WriteLine("Hola, ingresa tu contraseña");
    pwd = Console.ReadLine();

    if (clave.Equals(pwd))
    {
        Console.WriteLine("contraseña correcta");
        break;
    }
    else
    {
        Console.WriteLine("contraseña incorrecta");
        intentos--;
        Console.WriteLine($"te quedan {intentos} intentos");

    }

} while (intentos > 0 || !clave.Equals(pwd));
