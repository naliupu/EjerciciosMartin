double saldo = 0;

while (true)
{
	Console.WriteLine("Menu");
	Console.WriteLine("1. Ver saldo");
	Console.WriteLine("2. Retirar");
	Console.WriteLine("3. Depositar");
	Console.WriteLine("4. Salir");
	Console.WriteLine();
	String op = Console.ReadLine();
	Console.WriteLine();

	switch (op)
	{
		case "1":
			Console.WriteLine("Su saldo total es: " + saldo);
			break;
		case "2":
			Console.WriteLine("Cuanto desea retirar:");
			double retirar = Convert.ToDouble(Console.ReadLine());
			if (retirar > saldo)
			{
				Console.WriteLine("No tiene la cantidad de dinero a retirar");
				break;
			}
			saldo = saldo - retirar;
			Console.WriteLine("Su rertiro fue exitoso, su total es : " + saldo);
			break;
		case "3":
			Console.WriteLine("Cuanto desea depositar:");
			double depositar = Convert.ToDouble(Console.ReadLine());
			saldo = saldo + depositar;
			Console.WriteLine("Su deposito fue correcto, su total es de: " + saldo);
			break;
		case "4":
			Console.WriteLine("Salio correctaente del sistema:");
			break;
		default:
			Console.WriteLine("Opcion no valida");
			break;
	}

	if(op == "4")
	{
		break;
	}

	Console.WriteLine("¿Desea continuar en el cajero?");
	Console.WriteLine("Digite si para continuar o no para salir");
	String salir = Console.ReadLine();
	if (salir == "no")
	{
		break;
	}
}