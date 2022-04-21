while (true)
{
	Console.WriteLine("Digite un año, para comprobar si es bisiesto");
	Int32 year = Convert.ToInt32(Console.ReadLine());

	if ((year % 4) == 0 || (year % 400) == 0 && (year % 100) != 0)
	{
		Console.WriteLine("El año: " + year + " es bisiesto");
	}
	else
	{
		Console.WriteLine("El año: " + year + " no es bisiesto");
	}

	Console.WriteLine("¿Desea continuar?");
	Console.WriteLine("Digite cualquier tecla para continuar o no para salir");
	String salir = Console.ReadLine();
	if (salir == "no")
	{
		break;
	}
}