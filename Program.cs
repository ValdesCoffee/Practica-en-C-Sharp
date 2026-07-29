// // 1
// Console.WriteLine("¡Hola mundo!");
// 2 
// Console.WriteLine("Escribe tu tipo de dato: ");
// int i = int.Parse(Console.ReadLine());
// Console.WriteLine($"{i} es tu dato entero");
// Thread.Sleep(1000);
// Console.WriteLine("Escribe tu tipo de dato: ");
// string str = Console.ReadLine()!;
// Console.WriteLine($"{str} es tu dato es texto");

//3 
// string strmain = "texto";
// string strtoUper = strmain.ToUpper();
// Console.WriteLine(strtoUper);


// 4
// Console.WriteLine("Escribe tu primer entero");
// int firstint = int.Parse(Console.ReadLine());

// Console.WriteLine("Escribe tu segundo entero");
// int secondtint = int.Parse(Console.ReadLine());
// // operaciones
// int mults = firstint * secondtint;
// int suma = firstint + secondtint;
// int resta = firstint - secondtint;
// Console.WriteLine($"{mults} este es el resultado de tu multiplicacion");
// Console.WriteLine($"{suma} este es el resultado de tu suma");
// Console.WriteLine($"{resta} este es el resultado de tu resta");

//5 
// // Console.WriteLine("Escribe tu primer entero");
// // int firstint = int.Parse(Console.ReadLine());

// // Console.WriteLine("Escribe tu segundo entero");
// // int secondtint = int.Parse(Console.ReadLine());
// // if (firstint == secondtint)
// // {
// //     Console.WriteLine("Tus numeros son iguales");
// // };
// // if (firstint != secondtint)
// // {
// //      Console.WriteLine("son diferentes");
// // };
// 6
// string text = "hola esto es un texto";
// string str = "texto";
// Console.WriteLine(str);
// string newStr = str.Replace("texto", "Holaa");
// Console.WriteLine(newStr);
//  7
// Console.WriteLine("Escribe tu nombre: ");
// string str = Console.ReadLine()!;
// Console.WriteLine("Escribe tu edad: ");
// int edad = int.Parse(Console.ReadLine());
// Console.WriteLine($"{edad} es tu edad, tu nombre es {str}");
// 8 
// int i  = 10;
// Console.WriteLine("Escribe tu numero");
// int i2 = int.Parse(Console.ReadLine());
// if (i > i2)
// {
//     Console.WriteLine($"10 es mayor que tu {i2}");
// } else
// {
//     Console.WriteLine("10 es menor");

// 9
// double i = 10.984958;
// double i2= 20.644;
// operaciones
// double mults = i * i2;
// double suma = i + i2;
// double resta = i - i2;
// Console.WriteLine($"{mults} este es el resultado de tu multiplicacion");
// Console.WriteLine($"{suma} este es el resultado de tu suma");
// Console.WriteLine($"{resta} este es el resultado de tu resta");

// 10 

// // string name = "Normandia"; 
// // string name2 = "Alemanya";
// // Console.WriteLine($@"Hay dos paises {name}, {name2}
// // eso es todo por amigos");

// // 11
// int number = 45;
// double noshe = number + 0.67D;
// Console.WriteLine($"{noshe} es entero con decimal crack");
// // 12
// Console.WriteLine("Escribe tu primer entero");
// int firstint = int.Parse(Console.ReadLine());

// if (firstint > 0)
// {
//     Console.WriteLine("Tu numero es positivo");
// };
// if (firstint < 0)
// {
//      Console.WriteLine("Tu numero es negativo");
// };
// 13
// for (int i = 0; i <=10; i++)
// {
//     Console.WriteLine($"Numero: {i}");
// }
// 14
// string textoSucio = " ASJDHASJDHSAJD ";
//
// if (string.IsNullOrEmpty(textoSucio))
// {
//     Console.WriteLine(textoSucio);
//     return;
// }
//
// string textoLimpio = textoSucio.Trim();
//
// string minus = textoLimpio.ToLower();
// string resultado = char.ToUpper(minus[0]) + minus.Substring(1);
// Console.WriteLine(resultado);

// 15
// Console.Write($"Ingrese un número ");
// string numeroTexto = Console.ReadLine();
// double numero;
// if (double.TryParse(numeroTexto, out numero))
// {
//     int i = 0;
//     while (i <= 10) {
//         double multiplicacion = numero * i;
//         Console.WriteLine($"{numero} * {i} = {multiplicacion}");
//         i++;
//     }
// }
// else
// {
//     Console.WriteLine("¡El valor ingresado no es un número!");
// }

// 16
// string saludo = "Hola",
//     nombre = "Auricita";
// string resultado = string.Concat("¡", saludo, " ",nombre, "!");
// int length = resultado.Length;
// Console.WriteLine(length);

// 17
// string texto = "Auri, la pro en C#";
// string subcadena = texto.Substring(6);
// Console.WriteLine(subcadena.Length);