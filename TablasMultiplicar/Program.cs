while (true)
{
	Console.WriteLine("Digite un numero de 1 a 20");
	Int32 numero = Convert.ToInt32(Console.ReadLine());

	for (int i = 1; i < 11; i++)
	{
		Int32 tabla = numero * i;
		//Console.WriteLine(i);
		Console.WriteLine(numero+ " x "+ i + " = " + tabla);
	}

	Console.WriteLine("¿Desea continuar?");
	Console.WriteLine("Digite cualquier tecla para continuar o no para salir");
	String salir = Console.ReadLine();
	if (salir == "no")
	{
		break;
	}
}
