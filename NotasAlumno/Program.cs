double SumaNotas= 0;
Console.WriteLine("Digite el numero de notas para sacar el promedio");
Int32 nNotas = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= nNotas; i++)
{
	Console.WriteLine("Digite una nota: ");
	double Notas = Convert.ToDouble(Console.ReadLine());
	SumaNotas = SumaNotas + Notas;
}
Console.WriteLine(SumaNotas);

double prom = SumaNotas / nNotas;
	if(prom < 3)
	{
		Console.WriteLine("Perdiste la materia, malo");
	}else if (prom < 4)
	{
		Console.WriteLine("Ganaste la materia, bueno");
	}else if (prom > 4)
	{
		Console.WriteLine("Ganaste la materia , muy bien");
	}
	Console.WriteLine("El promedio de las notas es: "+ prom);

