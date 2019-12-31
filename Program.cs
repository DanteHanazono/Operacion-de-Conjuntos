using System;

namespace ConsoleApp1
{
    class Program
    {
        static string llenado (int i, string []u)
        {
			string elemento;
			int j;
			int encontrado;
			do
			{
				Console.WriteLine("digite elemento #{0}: ",i+1);
				elemento = Console.ReadLine();
				encontrado = 0;
				for (j = 0; j < 15; j++)
				{
					if (elemento == u[j])
					{
						encontrado = 1;
						break;
					}
				}
			} while (encontrado == 0);
			return elemento;
		}
		static void Mostrar(string []a, int b, string l)
		{
			Console.WriteLine("{0}={",l);
			for (int i = 0; i < b; i++)
			{
				if (i == 0) Console.WriteLine(a[i]);
				else Console.WriteLine( ", {0}",a[i]);
			}
			Console.WriteLine("}");
		}

		static void Main(string[] args)
        {
			int cA = 0, cB = 0, opcion, i;
			int k = 0, l = 0, m = 0, j;
			string linea;
			string [] u = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "a", "e", "i", "o", "u" };
			string[] A = new string[15];
			string[] B = new string[15];
			string[] C = new string[15];
			do
			{
				Console.WriteLine("");
				Console.WriteLine("");
				Console.WriteLine("MENU DE OPCIONES");
				Console.WriteLine("1. Llenado de conjuntos");
				Console.WriteLine("2. Union de conjuntos");
				Console.WriteLine("3. Interseccion de conjuntos");
				Console.WriteLine("4. Diferencia de conjuntos");
				Console.WriteLine("5. SALIR");
				Console.WriteLine("");
				linea = Console.ReadLine();
				opcion = int.Parse(linea);
				switch (opcion)
				{
					case 1:
						Console.WriteLine("Digite la cantidad de elementos del conjunto A");
						linea = Console.ReadLine();
						cA = int.Parse(linea);
						for (i = 0; i<cA; i++)
						{
							A[i] = llenado(i, u);
							if (i > 0)
							{
								for (j=0; j<i; j++)
								{
									if (A[j] == A[i])
									{
										Console.WriteLine("Este valor ya esta registrado");
										i--;
										break;
									}
								}
							}
						}
						Console.WriteLine("Digite la cantidad de elementos del conjunto B");
						linea = Console.ReadLine();
						cB = int.Parse(linea);
						for (i = 0; i < cB; i++)
						{
							B[i] = llenado(i, u);
							if (i > 0)
							{
								for (j = 0; j < i; j++)
								{
									if (B[j] == B[i])
									{
										Console.WriteLine("Este valor ya esta registrado");
										i--;
										break;
									}
								}
							}
						}
						Console.WriteLine("");
						Console.WriteLine("");
						Console.Write("Conjunto A:{");
						for (i = 0; i < cA; i++)
						{
							if(i < cA - 1)
							{
								Console.Write("{0}, ", A[i]);
							}
							else
							{
								Console.Write(A[i]);
							}
						}
						Console.WriteLine("}");
						Console.WriteLine("");
						Console.WriteLine("");
						Console.Write("Conjunto B:{");
						for (i = 0; i < cB; i++)
						{
							if (i < cB - 1)
							{
								Console.Write("{0}, ", B[i]);
							}
							else
							{
								Console.Write(B[i]);
							}
						}
						Console.WriteLine("}");
						break;
					case 2:
						int encontrado;
						Console.WriteLine("");
						Console.WriteLine("");
						Console.WriteLine("Union de conjuntos");
						for (i = 0; i < cA; i++)
						{
							C[k] = A[i];
							k++;
						}
						for (i = 0; i < cB; i++)
						{
							encontrado = 0;
							for (j = 0; j < cA; j++)
							{
								if (A[j] == B[i])
								{
									encontrado = 1;
									break;
								}
							}
							if (encontrado == 0)
							{
								C[k] = B[i];
								k++;
							}
						}
						Mostrar(A, cA, "A");
						Console.WriteLine("");
						Mostrar(B, cB, "B");
						Console.WriteLine("");
						Mostrar(C, k, "A U B");
						break;
					case 3:
							break;
				}
			} while (opcion != 5);
		}
    }
}
