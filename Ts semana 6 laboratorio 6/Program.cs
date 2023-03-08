// See https://aka.ms/new-console-template for more information
Console.WriteLine("Eduardo Hernández 1156823");
int opcion = 0;
bool continuar = true;

while (continuar)
{
    //Ingreso de opcion
    bool opcionCorrecta = false;
    while (!opcionCorrecta)
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine("Supervisado - Hernández Eduardo - 123345676");
        Console.WriteLine("---------------------------");
        Console.WriteLine("MENU");
        Console.WriteLine("1. Meses del año");
        Console.WriteLine("2. Encontrar el numero mayor");
        Console.WriteLine("Salir");
        Console.WriteLine("Ingrese una opción del menu: ");

        try
        {
            opcion = int.Parse(Console.ReadLine());
            if (opcion > 0 && opcion <= 4)
            {
                opcionCorrecta = true;
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Debe ingresar numero...");
            Console.ReadLine();
        }
    }
    //Fin ingreso de opción

    //Ejecución de ejercicio según la opoción
    switch (opcion)
    {
        case 1:
            
            Console.WriteLine("Ejercicio 1");

           
            Console.Write("Ingrese un número de mes (1-12): ");
            int mes = int.Parse(Console.ReadLine());

           
            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 12");
            }
            else
            {
              
                string nombreMes = "";
                switch (mes)
                {
                    case 1:
                        nombreMes = "enero";
                        break;
                    case 2:
                        nombreMes = "febrero";
                        break;
                    case 3:
                        nombreMes = "marzo";
                        break;
                    case 4:
                        nombreMes = "abril";
                        break;
                    case 5:
                        nombreMes = "mayo";
                        break;
                    case 6:
                        nombreMes = "junio";
                        break;
                    case 7:
                        nombreMes = "julio";
                        break;
                    case 8:
                        nombreMes = "agosto";
                        break;
                    case 9:
                        nombreMes = "septiembre";
                        break;
                    case 10:
                        nombreMes = "octubre";
                        break;
                    case 11:
                        nombreMes = "noviembre";
                        break;
                    case 12:
                        nombreMes = "diciembre";
                        break;
                }

                Console.WriteLine("MES: " + nombreMes);
            }

            
            Console.ReadKey();
    

    break;
        case 2:
            Console.WriteLine("Ejercicio 2");

            int num1, num2, num3;

            Console.Write("Número 1: ");
            if (!int.TryParse(Console.ReadLine(), out num1) || num1 <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero mayor a cero.");
                return;
            }

            Console.Write("Número 2: ");
            if (!int.TryParse(Console.ReadLine(), out num2) || num2 <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero mayor a cero.");
                return;
            }

            Console.Write("Número 3: ");
            if (!int.TryParse(Console.ReadLine(), out num3) || num3 <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número entero mayor a cero.");
                return;
            }

            int mayor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }

            if (num3 > mayor)
            {
                mayor = num3;
            }

            Console.WriteLine($"El número mayor es: {mayor}");
   
break;
        
        case 3:
            continuar = false;
            break;
    }
    Console.Clear();
    Console.ReadKey();
}
            
    
