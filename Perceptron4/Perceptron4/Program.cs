using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron4
{
	class Program
	{
		static void Main(string[] args)
		{
			//Tabla de verdad compuerta AND donde a,b,c,d son las entradas y dx son las salidas 
			int a1 = -1, b1 = -1, c1 = -1, d1 = -1, dx1 = -1,
				a2 = -1, b2 = -1, c2 = -1, d2 = +1, dx2 = -1,
				a3 = -1, b3 = -1, c3 = +1, d3 = -1, dx3 = -1,
				a4 = -1, b4 = -1, c4 = +1, d4 = +1, dx4 = -1,
				a5 = -1, b5 = +1, c5 = -1, d5 = -1, dx5 = -1,
				a6 = -1, b6 = +1, c6 = -1, d6 = +1, dx6 = -1,
				a7 = -1, b7 = +1, c7 = +1, d7 = -1, dx7 = -1,
				a8 = -1, b8 = +1, c8 = +1, d8 = +1, dx8 = -1,
				a9 = +1, b9 = -1, c9 = -1, d9 = -1, dx9 = -1,
				a10 = +1, b10 = -1, c10 = -1, d10 = +1, dx10 = -1,
				a11 = +1, b11 = -1, c11 = +1, d11 = -1, dx11 = -1,
				a12 = +1, b12 = -1, c12 = +1, d12 = +1, dx12 = -1,
				a13 = +1, b13 = +1, c13 = -1, d13 = -1, dx13 = -1,
				a14 = +1, b14 = +1, c14 = -1, d14 = +1, dx14 = -1,
				a15 = +1, b15 = +1, c15 = +1, d15 = -1, dx15 = -1,
				a16 = +1, b16 = +1, c16 = +1, d16 = +1, dx16 = +1;

			//Declaración de variables donde w es el peso, u es el umbral, r es el primer resultado, nw será el nuevo peso
			//nr sera el nuevo resultado y nu será el nuevo umbral al recalcular los valores 
			double w1, w2, w3, w4, u, nw1, nw2, nw3, nw4, nu, r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
				r11, r12, r13, r14, r15, r16, nr1, nr2, nr3, nr4, nr5, nr6, nr7, nr8, nr9, nr10, nr11,
				nr12, nr13, nr14, nr15, nr16;

			//Se le pide al usuario que ingrese los valores correspondientes para w y para u
			Console.WriteLine("Ingresa el valor para el peso de W1");
			w1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese el valor para el peso de W2");
			w2 = double.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese el valor para el peso de W3");
			w3 = double.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese el valor para el peso de W4");
			w4 = double.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese el valor del Umbral");
			u = double.Parse(Console.ReadLine());
			Console.WriteLine("\n");

			//Aqui se define la formula predeterminada para realizar el perceptron
			r1 = ((a1 * w1) + (b1 * w2) + (c1 * w3) + (d1 * w4) + u);
			r2 = ((a2 * w1) + (b2 * w2) + (c2 * w3) + (d2 * w4) + u);
			r3 = ((a3 * w1) + (b3 * w2) + (c3 * w3) + (d3 * w4) + u);
			r4 = ((a4 * w1) + (b4 * w2) + (c4 * w3) + (d4 * w4) + u);
			r5 = ((a5 * w1) + (b5 * w2) + (c5 * w3) + (d5 * w4) + u);
			r6 = ((a6 * w1) + (b6 * w2) + (c6 * w3) + (d6 * w4) + u);
			r7 = ((a7 * w1) + (b7 * w2) + (c7 * w3) + (d7 * w4) + u);
			r8 = ((a8 * w1) + (b8 * w2) + (c8 * w3) + (d8 * w4) + u);
			r9 = ((a9 * w1) + (b9 * w2) + (c9 * w3) + (d9 * w4) + u);
			r10 = ((a10 * w1) + (b10 * w2) + (c10 * w3) + (d10 * w4) + u);
			r11 = ((a11 * w1) + (b11 * w2) + (c11 * w3) + (d11 * w4) + u);
			r12 = ((a12 * w1) + (b12 * w2) + (c12 * w3) + (d12 * w4) + u);
			r13 = ((a13 * w1) + (b13 * w2) + (c13 * w3) + (d13 * w4) + u);
			r14 = ((a14 * w1) + (b14 * w2) + (c14 * w3) + (d14 * w4) + u);
			r15 = ((a15 * w1) + (b16 * w2) + (c15 * w3) + (d15 * w4) + u);
			r16 = ((a16 * w1) + (b16 * w2) + (c16 * w3) + (d16 * w4) + u);

			//Se definen nuestras condiciones para comparar los resultados de nuestra función
			if (r1 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx=" + dx1);

			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				//En caso de no cumplir el resultado con la salida deseada seasignan nuevos valores 
				nw1 = (dx1 * a1);
				nw2 = (dx1 * b1);
				nw3 = (dx1 * c1);
				nw4 = (dx1 * d1);
				nu = (dx1) + u;

				//Nueva variable con nuevo resultado
				nr1 = ((a1 * nw1) + (b1 * nw2) + (c1 * nw3) + (d1 * nw4) + nu);


				//Se muestra en consola un mensaje donde indica la operación que realizo en caso de que no se cumpla la funcion antes mensionada
				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr1);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx1 =" + dx1);

				//El resultado se recalcula 
				r2 = ((a2 * nw1) + (b2 * nw2) + (c2 * nw3) + (d2 * nw4) + nu);


			}
			if (r2 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx2=" + dx2);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx2 * a2);
				nw2 = (dx2 * b2);
				nw3 = (dx2 * c2);
				nw4 = (dx2 * d2);
				nu = (dx2) + u;


				nr2 = ((a2 * nw1) + (b2 * nw2) + (c2 * nw3) + (d2 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr2);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx2 =" + dx2);

				r3 = ((a3 * nw1) + (b3 * nw2) + (c3 * nw3) + (d3 * nw4) + nu);


			}


			if (r3 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx3=" + dx3);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx3 * a3);
				nw2 = (dx3 * b3);
				nw3 = (dx3 * c3);
				nw4 = (dx3 * d3);
				nu = (dx3) + u;


				nr3 = ((a3 * nw1) + (b3 * nw2) + (c3 * nw3) + (d3 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr3);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx3 =" + dx3);

				r4 = ((a4 * nw1) + (b4 * nw2) + (c4 * nw3) + (d4 * nw4) + nu);


			}
			if (r4 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx4=" + dx4);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx4 * a4);
				nw2 = (dx4 * b4);
				nw3 = (dx4 * c4);
				nw4 = (dx4 * d4);
				nu = (dx4) + u;


				nr4 = ((a4 * nw1) + (b4 * nw2) + (c4 * nw3) + (d4 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr4);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx4 =" + dx4);

				r5 = ((a5 * nw1) + (b5 * nw2) + (c5 * nw3) + (d5 * nw4) + nu);


			}
			if (r5 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx5=" + dx5);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx5 * a5);
				nw2 = (dx5 * b5);
				nw3 = (dx5 * c5);
				nw4 = (dx5 * d5);
				nu = (dx5) + u;


				nr5 = ((a5 * nw1) + (b5 * nw2) + (c5 * nw3) + (d5 * nw3) + nu);



				Console.WriteLine("Las variables W1, W2,W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr5);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx5 =" + dx5);

				r6 = ((a6 * nw1) + (b6 * nw2) + (c6 * nw3) + (d6 * nw4) + nu);


			}
			if (r6 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx6=" + dx6);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx6 * a6);
				nw2 = (dx6 * b6);
				nw3 = (dx6 * c6);
				nw4 = (dx6 * d6);
				nu = (dx6) + u;


				nr6 = ((a6 * nw1) + (b6 * nw2) + (c6 * nw3) + (d6 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr6);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx6 =" + dx6);

				r7 = ((a7 * nw1) + (b7 * nw2) + (c7 * nw3) + (d7 * nw4) + nu);


			}
			if (r7 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx7=" + dx7);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx7 * a7);
				nw2 = (dx7 * b7);
				nw3 = (dx7 * c7);
				nw4 = (dx7 * d7);

				nu = (dx7) + u;


				nr7 = ((a7 * nw1) + (b7 * nw2) + (c7 * nw3) + (d7 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr7);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx7 =" + dx7);

				r8 = ((a8 * nw1) + (b8 * nw2) + (c8 * nw3) + (d8 * nw4) + nu);


			}
			if (r8 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx8=" + dx8);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx8 * a8);
				nw2 = (dx8 * b8);
				nw3 = (dx8 * c8);
				nw4 = (dx8 * d8);
				nu = (dx8) + u;


				nr8 = ((a8 * nw1) + (b8 * nw2) + (c8 * nw3) + (d8 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr8);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx8 =" + dx8);

				r9 = ((a9 * nw1) + (b9 * nw2) + (c9 * nw3) + (d9 * nw4) + nu);

			}

			if (r9 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx9=" + dx9);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx9 * a9);
				nw2 = (dx9 * b9);
				nw3 = (dx9 * c9);
				nw4 = (dx9 * d9);
				nu = (dx9) + u;


				nr9 = ((a9 * nw1) + (b9 * nw2) + (c9 * nw3) + (d9 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr9);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx9 =" + dx9);

				r10 = ((a10 * nw1) + (b10 * nw2) + (c10 * nw3) + (d10 * nw4) + nu);

			}

			if (r10 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx10=" + dx10);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx10 * a10);
				nw2 = (dx10 * b10);
				nw3 = (dx10 * c10);
				nw4 = (dx10 * d10);
				nu = (dx10) + u;


				nr10 = ((a10 * nw1) + (b10 * nw2) + (c10 * nw3) + (d10 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr10);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx10 =" + dx10);

				r11 = ((a11 * nw1) + (b11 * nw2) + (c11 * nw3) + (d11 * nw4) + nu);

			}

			if (r11 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx11=" + dx11);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx11 * a11);
				nw2 = (dx11 * b11);
				nw3 = (dx11 * c11);
				nw4 = (dx11 * d11);
				nu = (dx11) + u;

				nr11 = ((a11 * nw1) + (b11 * nw2) + (c11 * nw3) + (d11 * nw4) + nu);


				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr11);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx11 =" + dx11);


				r12 = ((a12 * nw1) + (b12 * nw2) + (c12 * nw3) + (d12 * nw4) + nu);

			}

			if (r12 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx12=" + dx12);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx12 * a12);
				nw2 = (dx12 * b12);
				nw3 = (dx12 * c12);
				nw4 = (dx12 * d12);
				nu = (dx12) + u;


				nr12 = ((a12 * nw1) + (b12 * nw2) + (c12 * nw3) + (d12 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr12);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx12 =" + dx12);

				r13 = ((a13 * nw1) + (b13 * nw2) + (c13 * nw3) + (d13 * nw4) + nu);

			}

			if (r13 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx10=" + dx10);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx13 * a13);
				nw2 = (dx13 * b13);
				nw3 = (dx13 * c13);
				nw4 = (dx13 * d13);
				nu = (dx13) + u;


				nr13 = ((a13 * nw1) + (b13 * nw2) + (c13 * nw3) + (d13 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr13);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx13 =" + dx13);

				r14 = ((a14 * nw1) + (b14 * nw2) + (c14 * nw3) + (d14 * nw4) + nu);

			}
			if (r14 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx14=" + dx14);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx14 * a14);
				nw2 = (dx14 * b14);
				nw3 = (dx14 * c14);
				nw4 = (dx14 * d14);
				nu = (dx14) + u;


				nr14 = ((a14 * nw1) + (b14 * nw2) + (c14 * nw3) + (d14 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr14);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx14 =" + dx14);

				r15 = ((a15 * nw1) + (b15 * nw2) + (c15 * nw3) + (d15 * nw4) + nu);

			}

			if (r15 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx15=" + dx15);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx15 * a15);
				nw2 = (dx15 * b15);
				nw3 = (dx15 * c15);
				nw4 = (dx15 * d15);
				nu = (dx15) + u;


				nr15 = ((a15 * nw1) + (b15 * nw2) + (c15 * nw3) + (d15 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr15);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx15 =" + dx15);

				r16 = ((a16 * nw1) + (b16 * nw2) + (c16 * nw3) + (d16 * nw4) + nu);

			}

			if (r16 < 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx16=" + dx16);
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.White;
				nw1 = (dx16 * a16);
				nw2 = (dx16 * b16);
				nw3 = (dx16 * c16);
				nw4 = (dx16 * d16);
				nu = (dx16) + u;


				nr16 = ((a16 * nw1) + (b16 * nw2) + (c16 * nw3) + (d16 * nw4) + nu);



				Console.WriteLine("Las variables W1, W2, W3, W4 y U se tuvieron que recalcular para cumplir la tabla de verdad");
				Console.WriteLine("El nuevo resultado de W1 es: " + nw1);
				Console.WriteLine("El nuevo resultado de W2 es: " + nw2);
				Console.WriteLine("El nuevo resultado de W3 es: " + nw3);
				Console.WriteLine("El nuevo resultado de W4 es: " + nw4);
				Console.WriteLine("El nuevo resultado de U es: " + nu);
				Console.WriteLine("El nuevo resultado es: " + nr16);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("El valor de dx16 =" + dx16);

			}
			Console.ForegroundColor = ConsoleColor.Black;
			Console.ReadKey();

		}
	}
}