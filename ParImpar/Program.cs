while (true)
{

	Console.WriteLine("Digite un numero, para saber si es par o impar");
	Double numero = Convert.ToDouble(Console.ReadLine());
	if((numero % 2) == 0)
	{
		Console.WriteLine("El numero: "+ numero + " es par");
	}
	else
	{
		Console.WriteLine("El numero: " + numero + " es impar");
	}

	Console.WriteLine("¿Desea continuar?");
	Console.WriteLine("Digite cualquier tecla para continuar o no para salir");
	String salir = Console.ReadLine();
	if (salir == "no")
	{
		break;
	}
}