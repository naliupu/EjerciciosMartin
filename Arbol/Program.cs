using System;
					
public class Program
{
	public static void Main()
	{
		int n=1;
		for(int i = 0; i < 5; i++){
			string fila= "";
			for(int j = 1; j <= i; j++){
				fila += n+" ";
				n++;
			}
			fila = fila.Trim();
			fila = ("           "+fila);
			Console.WriteLine(fila.Substring(fila.Length-9,9));
		}
	}
}
