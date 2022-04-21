while (true)
{
	Console.WriteLine("Digite la altura de un usuario. (EJM - 1,7)");
	double altura = Convert.ToDouble(Console.ReadLine());
	if (altura < 1.7)
	{
		Console.WriteLine("El usuario es pequeño");
	}else if(altura < 1.8)
	{
		Console.WriteLine("El usuario es promedio");
	}else if(altura >= 1.8)
	{
		Console.WriteLine("El usuario es alto");
	}

	Console.WriteLine("¿Desea continuar?");
	Console.WriteLine("Digite cualquier tecla para continuar o no para salir");
	String salir = Console.ReadLine();
	if (salir == "no")
	{
		break;
	}
}