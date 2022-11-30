using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("SWAP - Introduceti valorile variabilelor:");
		Console.Write("\n");
		int aux;
		int a;
		int b;
		Console.Write("a = ");
		a  = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());
		aux = a;
		a = b;
		b = aux;
		Console.Write("Valorile lor schimbate:");
		Console.Write("\n");
		Console.Write("a = ");
		Console.Write(a);
		Console.Write(" ");
		Console.Write("b = ");
		Console.Write(b);
	}
}
