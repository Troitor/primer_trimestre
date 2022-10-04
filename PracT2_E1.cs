/*
 Martínez Perales, Beatriz
Practica Evaluable Tema 2
Triángulo Invertido
 */


using System;

	public class TrianguloInvertido
	{
		public static void Main ()
		
		{
			int anchura;
		
			Console.WriteLine("dame la anchura");
			anchura=Convert.ToInt32(Console.ReadLine());
			
			for(int i=0;i<anchura;i++)
			
			{
			
			for(int j=0;j<anchura;j++)
			
			{
				if(j>i-1)
				
				{
					Console.Write("#");
				}
				
				else if (j>i+1)
				{
					Console.Write ("#");
					
				}
				
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
			
		
		}
	}
}

