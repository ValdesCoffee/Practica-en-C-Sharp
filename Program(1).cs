<//  1
// Console.WriteLine("Hola coloca un numero: ");
// double num = double.Parse(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine("El numero es par");
// }
// else
// {
//     Console.WriteLine("El numero no es par");
// }
// 2
// Console.WriteLine("HOLA coloca un usuario aca: ");
//  string nombre = Console.ReadLine() ?? "";
//  if (nombre == "")
// {
//     Console.WriteLine("No es valido");
// }
// else
// {
//     Console.WriteLine("Es valido :D");
// }

// 3 
// Console.WriteLine("Hola escribe tu edad por favor");
// int num = int.Parse(Console.ReadLine());

// if (num > 18)
// {
//     Console.WriteLine("ERES MAYOR DE EDAD");
// }
// else
// {
//     Console.WriteLine("NO ERES MAYOR DE EDAD");
// }
//4



// Console.WriteLine("Hola, escribe un numero del 1 al 10");
// int week = int.Parse(Console.ReadLine());
// switch (week)
// {
//   case 1:
//   Console.WriteLine("Lunes");
//   break;
//   case 2:
//   Console.WriteLine("Martes");
//   break;
//   case 3:
//   Console.WriteLine("Miercoles");
//   break;
//   case 4:
//   Console.WriteLine("Jueves");
//   break;
//   case 5:
//   Console.WriteLine("Viernes");
//   break;
//   case 6:
//   Console.WriteLine("Sabado");
//   break;
//   case 7:
//   Console.WriteLine("Domingo");
//   break;
// }

// 5 
Console.WriteLine("Escribe tu nacionalidad");
string message = Console.ReadLine();
string messageNa = "Colombian";
string confirm = (message == "Colombia") ? "Eres nativo" : "No eres nativo";

Console.WriteLine(confirm); 
