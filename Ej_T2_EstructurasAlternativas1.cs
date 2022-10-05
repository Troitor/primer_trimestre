/* 
Martínez Perales, Beatriz
Ejercicio 2.1
Estructuras alternativas I 
*/

using System;

public class Ej_EstructurasAlternativas
	
	{
		public static void Main()
		
		 {
			 //Ejercicio 2.1.1.1
			/*int num;
			
			Console.WriteLine ("Introduce un número entero: ");
			num=Convert.ToInt32(Console.ReadLine());
		
			
			if( num % 2 == 0)
			
			
			{
				Console.WriteLine ("Tu número es par");
				
			}
			
			else
			
			{
				Console.WriteLine ("Tu número  es impar");
				
			}*/
			
			//Ejercicio 2.1.1.2
			/*{
				int num1,num2;
				
				Console.WriteLine ("Introduce un número entero: ");
				num1=Convert.ToInt32(Console.ReadLine());
				
					
				Console.WriteLine ("Introduce otro número entero: ");
				num2=Convert.ToInt32(Console.ReadLine());
				
				if (num1>num2)
				
				{
					Console.WriteLine(" El número {0} es mayor al número {1}",num1,num2);
					
				}
				
				else
				
				{
					Console.WriteLine ("El número {1} es mayor al número {0}",num1,num2);
				}*/
			
				//Ejercicio 2.1.1.3
				
				/*int n1,n2;
			
				Console.WriteLine ("Introduce un número entero: ");
				n1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine ("Introduce otro número entero: ");
				n2=Convert.ToInt32(Console.ReadLine());
		
			
				if( n1 % n2 == 0)
			
			
				{
					Console.WriteLine ("El número {0} es múltiplo de {1}",n1,n2);
				
				}
			
				else
			
				{
					Console.WriteLine ("El número {0} no es múltiplo de {1}",n1,n2);
				
				}*/
				
				//Ejercicio 2.1.2.1
				
				/*int n1;
			
				Console.WriteLine ("Introduce un número entero: ");
				n1=Convert.ToInt32(Console.ReadLine());
			
	
				if( n1 % 10 == 0 && n2 % 10 == 0)
			
			
				{
					Console.WriteLine ("El número {0} es múltiplo de 10",n1);
					
					
					
				
				}
				int n2;
				
					Console.WriteLine ("Introduce otro número: ");
					n2=Convert.ToInt32(Console.ReadLine());
				
				else if
				{
					Console.WriteLine ("El número {0} es múltiplo de 10",n2);				
					
				}
				
				else
				{
					Console.WriteLine ("No son múltiplos");
				}*/
				
				//Ejercicio 2.1.3.1
				
				/*int n1, n2;
				
					Console.WriteLine ("Introduce un número entero: ");
					n1=Convert.ToInt32(Console.ReadLine());
					
					
				if (n1 == 0)
				{
					Console.WriteLine ("El producto de 0 por cualquier número es 0");
				}
				else if (n1!=0)
				
				{
					Console.WriteLine ("Introduce otro número entero: ");
					n2=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine ("El resultado de la múltiplicación es:  ");
					Console.Write (n1*n2);
				}*/
				
				/*****************************************************/
				//Ejercicio 2.1.3.2	
				
				/*int n1, n2;
				
					Console.WriteLine ("Introduce un número entero: ");
					n1=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine ("Introduce otro número");
					n2=Convert.ToInt32(Console.ReadLine());
					
					
				if (n2 != 0)
				{
					Console.WriteLine ("El resultado de tu división es: ");
					Console.WriteLine (n1/n2);
				}
				else if (n2 == 0)
				
				{
					Console.WriteLine ("Error: No se puede dividir entre cero");
					
					
				
				}*/
				
					/*********************************************/
				//EJ_2.1.5*
				
				/*int numero;
				
				Console.WriteLine ("Introduce un número");
				numero=Convert.ToInt32(Console.ReadLine());
				
				if (numero%2==0) 
				{
					Console.WriteLine("El número {0} es múltiplo de 2",numero);
				}
				else if(numero%3==0)
				{ 
					Console.WriteLine("El número {0} es múltiplo de 3",numero);
					
				}
				else if (numero%2==0 || numero%3==0) 
				{
					Console.WriteLine("El número {0} es múltiplo de 2 o de 3",numero);
				}
				else if (numero%2==0 && numero%3==0)
				{
					Console.WriteLine("El número {0} es múltiplo de 2 y de 3",numero);
				}
				else
				{
					Console.WriteLine("El número introducido no es múltiplo ni de 2 ni de 3");
				}*/
					/*********************************************/
					
				//EJ_2.1.5.7
				
				/*int n1,n2;
				Console.WriteLine("Introduce un número: ");
				n1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce otro número: ");
				n2=Convert.ToInt32(Console.ReadLine());
				
				if (n1%2==0 && n2%2==0)
				
				{
					Console.WriteLine("Tus números son pares");
				}
				else if (n1%2==0 || n2%2==0)
				{
					Console.WriteLine ("Uno de tus números es par");
				}
				else
				{
					Console.WriteLine ("Ninguno es par");
				}*/
				
				/*********************************************/
				//EJ_2.1.5.8
				/*int num,num1;
				
				Console.WriteLine("Introduce un número: ");
				num=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce otro número: ");
				num1=Convert.ToInt32(Console.ReadLine());
				if (num>=0 && num1>=0)
				{
					Console.WriteLine ("Los dos números son positivos");
				}
				else if (num>=0 || num1>=0)
				{
					Console.WriteLine ("Uno de los dos es positivo");
				}
				else
				{
					Console.WriteLine("Ninguno es positivo");
				}*/
				
				/********************************************************/
				//EJ_2.1.5.10 y 2.1.5.9
				
				/* int n1,n2,n3;
				
					Console.WriteLine("Introduce un número: ");
					n1=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Introduce otro número: ");
					n2=Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Introduce otro número más: ");
					n3=Convert.ToInt32(Console.ReadLine());
					
				if(n1>n2 && n1>n3)
				{
					Console.WriteLine("El primer número es mayor al segundo y al tercero");
				}
				else if (n2>n1 && n2>n3)
				{
					Console.WriteLine("El segundo número es mayor al primero y al tercero");
				}
				else if (n3>n1 && n3>n2)
				{
					Console.WriteLine("El tercer número es mayor al primero y al segundo");
				}
				else
				{
					Console.WriteLine("Todos son iguales!!");
				}*/

				
				
				
				
				
				
				
				
			
			
		}
	
	}
	

	
			
		
	
