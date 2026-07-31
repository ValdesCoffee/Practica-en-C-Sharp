// See https://aka.ms/new-console-template for more information
// ciclo "for"
//  for  (var i = 0; i < 10; i++)
// {
//     Console.WriteLine($"{i+1}. No puede ser " );
// }

// ciclo while

// 1

// for (var i = 0; i <100;  i++)
// {
//     Console.WriteLine($"{i+1}");
// }
//2

// Console.ForegroundColor = ConsoleColor.DarkRed;
// Console.Write("Pide numero entero positivo: ");
// string Verfinumber = Console.ReadLine();
// int number;
// if (int.TryParse(Verfinumber, out number))
// {
//     if(number > 0)
//     {
//         for(int i= 1; i <= number; i++)
//         {
//             if(i % 2 == 0)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("NO ES POSITIVO");
//     }
// }
// else
// {
//     Console.WriteLine("El valor ingresado no es un numero entero");

// }
// Console.ResetColor();

// 3
// Console.ForegroundColor = ConsoleColor.DarkRed;
// Console.Write("Pide numero entero positivo: ");
// string Verfinumber = Console.ReadLine();
// int number;
// if (int.TryParse(Verfinumber, out number))
// {
//     if(number > 0)
//     {
//         for(int i= 0; i <= 10; i++)
//         {
//             Console.WriteLine($"{number} x {i} = {number*i}");
//         }
//     }
//     else
//     {
//         Console.WriteLine("NO ES POSITIVO");
//     }
// }
// else
// {
//     Console.WriteLine("El valor ingresado no es un numero entero");

// }
// Console.ResetColor();

// Random alt = new Random();
// int altnumer = alt.Next(1,101);
// int number;
// do
// {
//     Console.Write("Chaval ingresa un numero: ");
//     string numberText = Console.ReadLine();
//     if (!int.TryParse(numberText,out number))
//     {
//         Console.WriteLine("Ingresa por favor un numero entero");
//         continue;
//     }
//     if (number > altnumer)
//     {
//         Console.WriteLine("tu numero esta grande");
//     }
//     else if(number < altnumer)
//     {
//         Console.WriteLine("tu numero esta chiquito");
//     }
//     else
//     {
//         Console.WriteLine("Ese es el numero");
//     }
// } while (number != altnumer);