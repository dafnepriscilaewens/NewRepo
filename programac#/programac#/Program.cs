using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace programac_

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condicional2();
            //condiconal6();
            // Condicional3();
            // Condicional1();
            // Condicional4();
            //Ciclos2();
            //Seuencial6();
            //Ciclos(4);
            //Ciclos10;
            //Ciclos12;
            //secuenciales7();
            //Secuencial10();
            //Secuencial4();
            //Secuencial5();
            Ejmaxminn3();







        }


        private static void Condicional2()

        //Ingresar un valor indicar e imprmir si es positivo, negativo o cero
        {
            int num;


            Console.WriteLine("Por favor ingrese un numero");

            num = int.Parse(Console.ReadLine());



            if (num > 0)
            {
                Console.WriteLine("el numero es positivo");
            }
            else if (num < 0)
            {
                Console.WriteLine("el numero es negativo");

            }
            else
            {
                Console.WriteLine("el numero es cero");
            }
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();
        }

        private static void condiconal6()
        //Ingresar tres valores, sumarlos, calcular el promedio e indicar e imprimir cúal de estosvalores es mayor al promedio
        {
            int num1;
            int num2;
            int num3;
            int promedio;

            Console.WriteLine("Por favor ingrese un numero");

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese otro numero");

            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor un ultimo numero");
            num3 = int.Parse(Console.ReadLine());

            promedio = num1 + num2 + num3;
            if (num1 > promedio)
            {

                Console.WriteLine("El numero" + num1 + "es mayor al promedio");
            }
            else if (num2 > promedio)
            {
                Console.WriteLine("El numero" + num2 + "es mayor al promedio");

            }
            else
            {
                Console.WriteLine("El numero" + num3 + "es mayor al promedio");
            }


            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();

        }


        private static void Ejmaxmin3()

        {
            //Ingresar los sueldos y nombres de 30 empleados, indicar e imprimir el sueldomayor y a quién pertenece
            int cantidad = 0; // Cantidad de empleados
            int n = 0; // Variable de control de ciclo

            decimal sueldo = 0;
            decimal maximo = 0;
            string nomempl = "";
            string nomempmax = "";


            // Pedimos la cantidad de empleados
            Console.WriteLine("Dane la cantidad de empleados");
            cantidad = int.Parse(Console.ReadLine());
            // Creamos el arreglo
            decimal[] sueldos = new decimal[cantidad];
            string[] empleados = new string[cantidad];
            // Capturamos la información
            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Ingrese nombre de empleado");
                nomempl = Console.ReadLine();
                empleados[n] = nomempl;
                Console.WriteLine("Ingrese sueldo de empleado");
                sueldo = decimal.Parse(Console.ReadLine());
                sueldos[n] = sueldo;

            }


            // Encontramos la calificación maxima
            for (n = 0; n < cantidad; n++)
            {
                if (sueldos[n] > maximo)
                    maximo = sueldos[n];
                nomempmax = empleados[n];
            }

            // Desplegamos los resultados
            Console.WriteLine($"El empleado:{nomempmax} tiene el sueldo maximo:{maximo}");
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();



        }

        private static void Condicional3()
        {
            // Ingresar dos valores y realizar e imprmir el producto si el 1ro es mayor al 2do, si soniguales solo indicarlo
            int num1;
            int num2;
            int producto;

            Console.WriteLine("Por favor ingrese un numero");

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese otro numero");

            num2 = int.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                producto = num1 * num2;
                Console.WriteLine("el producto es" + producto);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");

            }
            else
            {
                Console.WriteLine("NO se puede realizar el producto");
            }


            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();

        }

        private static void Condicional1()

        {
            int num1;
            int num2;

            Console.WriteLine("Por favor ingrese un numero");

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese otro numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("los numeros son iguales");
            }
            else
            {
                Console.WriteLine("los numeros son distintos");


            }

            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();

        }

        private static void Condicional4()
        {
            // Ingresar dos valores y realizar e imprimir la resta del mayor menos el menor

            int num1;
            int num2;
            int resta;

            Console.WriteLine("Por favor ingrese un numero");

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese otro numero");

            num2 = int.Parse(Console.ReadLine());


            if (num1 > num2)
            {
                resta = num1 - num2;
                Console.WriteLine("la resta es" + resta);
            }
            else if (num1 < num2)
            {
                resta = num2 - num1;
                Console.WriteLine("la resta es" + resta);

            }
            else
            {
                Console.WriteLine("LOs numeros son iguakes");
            }
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();
        }

        private static void Ciclos2()
        {
            //  2. Ingresar 20 notas y nombres de alumnos, indicar e imprimir los aplazados ( menosde 4) y el nombre a quien pertenece esa nota
            string nomalum;
            decimal nota = 0;
            int cantidad = 0;
            decimal suma = 0;
            decimal promedio = 0;

            for (int contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine("Por favor ingrese un alumno");
                nomalum = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su nota");
                nota = Decimal.Parse(Console.ReadLine());
                suma += nota;
                cantidad++;
            }

            promedio = suma / cantidad;
            Console.WriteLine("El promedio es" + promedio);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();


        }



        private static void Ciclos1()
        // Ingresar 25 números, calcular su promedio e imprimirlo
        {

            decimal numero = 0;
            decimal suma = 0;
            decimal promedio = 0;
            int cantidad = 0;

            for (int contador = 1; contador <= 25; contador++)
            {
                Console.WriteLine("Por favor ingrese un numero");
                numero = decimal.Parse(Console.ReadLine());

                suma += numero;
                cantidad++;

            }
            promedio = suma / cantidad;
            Console.WriteLine("El promedio es:" + promedio);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();

        }

        private static void Secuencial6()
        {

            //Ingresar los lados de un rectángulo y calcular su diagonal principal, superficie y perímetro.imprima los resultados solicitados
            double basee;
            double altura;
            double diagonal;
            double superficie;
            double perimetro;

            Console.WriteLine("Por favor ingrese la base del rectangulo");

            basee = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese la altura del rectangulo");
            altura = double.Parse(Console.ReadLine());

            diagonal = Math.Sqrt(Math.Pow(basee, 2) + Math.Pow(altura, 2));


            Console.WriteLine("La diagonal es:" + diagonal);

            superficie = basee * altura;
            Console.WriteLine("La superficie es:" + superficie);
            perimetro = 2 * basee + 2 * altura;
            Console.WriteLine("El perimetro es:" + perimetro);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();
        }

        private static void Ciclos4()
        // ingresar facturas hasta nro de factura = 0, sumar sus importes y cúales y cuantassuperan los $1000.imprimir los resultados
        {

            decimal total = 0;
            decimal monto;
            int nrofact;
            int contmayor1000 = 0;
            int conttotal = 0;
            int contmayor10000 = 0;
            decimal montomayor10000 = 0;
            decimal contentre400y700 = 0;
            decimal montoentre400y700 = 0;
            decimal montomayor1000 = 0;

            Console.WriteLine("Ingrese nro de factura");
            nrofact = int.Parse(Console.ReadLine());
            while (nrofact != 0)
            {

                Console.WriteLine("Ingrese monto de factura");
                monto = decimal.Parse(Console.ReadLine());
                total += monto;
                if ((monto > 1000 && monto < 10000))
                {

                    contmayor1000++;
                    montomayor1000 = +monto;
                    Console.WriteLine("Ingrese nro de factura");
                    nrofact = int.Parse(Console.ReadLine());

                }
                else if (monto > 10000)
                {
                    contmayor10000++;
                    montomayor10000 = +monto;
                    Console.WriteLine("Ingrese nro de factura");
                    nrofact = int.Parse(Console.ReadLine());
                }

                else if ((monto > 400 && monto < 700))
                {
                    contentre400y700++;
                    montoentre400y700 = +monto;
                    Console.WriteLine("Ingrese nro de factura");
                    nrofact = int.Parse(Console.ReadLine());
                }

                else
                {
                    conttotal++;
                    Console.WriteLine("Ingrese nro de factura");
                    nrofact = int.Parse(Console.ReadLine());

                }


                // acumuladorcont=acumuladorcont+contmayor1000+1;
                //acumuladormonto=acumuladormonto+montomayor1000;
            }

            Console.WriteLine("Las facturas que superan los $1000 son:" + contmayor1000);
            Console.WriteLine("el monto total de las mayores a $1000 es:" + montomayor1000);
            Console.WriteLine("Las facturas que superan los $10000 son:" + contmayor10000);
            Console.WriteLine("el monto total de las mayores a $10000 es:" + montomayor10000);
            Console.WriteLine("Las facturas entre $400 y $700 son:" + contentre400y700);
            Console.WriteLine("el monto total entre $400 y $700  es:" + montoentre400y700);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();

        }

        private static void Ciclos10()
        //Ingresar la patente y monto de la multa de 50 autos, indicar e imprimir cuántosmontos superan los $ 40 y del total cobrado que porcentaje representa la suma de losque superan los $40
        {
            //Ingresar la patente y monto de la multa de 5 autos, 
            //indicar e imprimir cuántos montos superan los $ 40 y del total 
            //cobrado que porcentaje representa la suma de los que superan los $40


            //VARIABLES

            decimal monto;
            decimal total = 0;
            decimal contadorMontosSuperior40 = 0;
            decimal acumuladorMontosSuperior40 = 0;
            decimal porcentajeSuperiores40 = 0;



            //DATOS ENTRADA
            for (int contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine($"Por favor ingrese el monto de la multa para el vehículo {contador}");
                monto = decimal.Parse(Console.ReadLine());

                if (monto > 40)
                {
                    contadorMontosSuperior40++; //VARIABLE CONTADOR
                    acumuladorMontosSuperior40 += monto; //VARIABLE ACUMULADOR PARCIAL DE LOS > 40
                }

                total += monto; //VARIABLE ACUMULADOR TOTAL
            }

            //PROCESO
            porcentajeSuperiores40 = (acumuladorMontosSuperior40 * 100) / total;

            //DATOS SALIDA

            Console.WriteLine($"El total de los montos superiores a $40 es {contadorMontosSuperior40}");
            Console.WriteLine($"El total en % de los montos superior a $40 es de {porcentajeSuperiores40.ToString("0.00")} %");
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();
        }





        private static void Ciclos12()
        {
            // Ingresar los datos de facturación de una empresa.Número de facturaNúmero de artículoCantidad vendidaPrecio unitarioLos datos finalizan con numero de factura = 0, cada factura sólo tiene un númerode artículo, existen tres artículosSe desea saber :Valor de cada facturaFacturación totalCuánto se vendio del artículo 1 en cantidadCuántas facturas mayores de $ 3000 se hicieronQué porcentaje representa el monto vendido por cada artículosobre el total
            int nrofact = 0;
            int cantidad = 0;
            int nroart = 0;
            decimal precio = 0;
            decimal totalfactura = 0;
            decimal acumuladortotal = 0;
            decimal totalart1 = 0;
            decimal totalart2 = 0;
            decimal totalart3 = 0;
            int contart1 = 0;
            int mayora3000 = 0;
            int menora3000 = 0;
            decimal porcentajeart1 = 0;
            decimal porcentajeart2 = 0;
            decimal porcentajeart3 = 0;


            Console.WriteLine("Ingrese nro de factura");
            nrofact = int.Parse(Console.ReadLine());

            while (nrofact != 0)
            {
                Console.WriteLine("Ingrese nro de articulo");
                nroart = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad vendida");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio unitario");
                precio = decimal.Parse(Console.ReadLine());


                totalfactura = cantidad * precio;
                Console.WriteLine($"El total de factura nro {nrofact} es {totalfactura}");
                Console.WriteLine("Ingrese nro de factura");
                nrofact = int.Parse(Console.ReadLine());



                if (nroart == 1)
                {
                    contart1 += cantidad;
                    totalart1 += totalfactura;
                }
                else if (nroart == 2)
                {
                    totalart2 += totalfactura;
                }
                else
                {
                    totalart3 += totalfactura;

                }

                if (totalfactura > 3000)
                {
                    mayora3000++;
                }
                else
                {
                    menora3000++;
                }

                acumuladortotal = +totalfactura;

                porcentajeart1 = (totalart1 / acumuladortotal) * 100;

                porcentajeart2 = (totalart2 / acumuladortotal) * 100;

                porcentajeart3 = (totalart3 / acumuladortotal) * 100;
            }
            Console.WriteLine($"El total facturado es: {acumuladortotal}");
            Console.WriteLine($"La cantidad vendida de articulo1 es: {contart1}");
            Console.WriteLine($"La cantidad de facturas mayores a 3000 es: {mayora3000}");
            Console.WriteLine($"Porcentaje vendido de articulo1{porcentajeart1}");
            Console.WriteLine($"Porcentaje vendido de articulo2{porcentajeart2}");
            Console.WriteLine($"Porcentaje vendido de articulo3{porcentajeart3}");
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();

        }
        private static void secuenciales7()
        // Ingresar dos valores, calcular su suma, su producto y la resta del 1ro menos el 2do valor ingresado, imprimir los resultados
        {
            {
                decimal num1;
                decimal num2;
                decimal suma;
                decimal resta;
                decimal producto;

                Console.WriteLine("Por favor ingrese un numwero");

                num1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Por favor ingrese otro numero");
                num2 = decimal.Parse(Console.ReadLine());

                suma = num1 + num2;
                producto = num1 * num2;
                resta = num1 - num2;


                Console.WriteLine("Ls suma es:" + suma);
                Console.WriteLine("El producto es:" + producto);
                Console.WriteLine("LLa resta es:" + resta);
                Console.WriteLine("Presione una tecla para finalizar");
                Console.Read();
            }



        }
        private static void secuenciales8()
        //Ingresar el valor de la hora y el tiempo trabajado por un operario, calcular su sueldoe imprimirlo
        {
            int cantidad;
            decimal valorhora;
            decimal sueldo;


            Console.WriteLine("Por favor ingrese cantidad de horas");

            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese valor hora ");
            valorhora = decimal.Parse(Console.ReadLine());

            sueldo = cantidad * valorhora;


            Console.WriteLine("El sueldo es:" + sueldo);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();




        }

        //Ingresar el tiempo trabajado por un operario y considerando que el valor de la hora es de 10 pesos, calcular su sueld e imprimirlo

        private static void Secuencial9()
        {
            int cantidad;
            decimal sueldo;


            Console.WriteLine("Por favor ingrese cantidad de horas");
            cantidad = int.Parse(Console.ReadLine());


            sueldo = cantidad * 10;


            Console.WriteLine("El sueldo es:" + sueldo);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();




        }


        private static void Secuencial10()

        //Una concesionaria de autos desea liquidar el sueldo a cada vendedor pagando $ 500por mes más un plus del 10 % del precio sobre cada vehículo vendido y un valorconstante de 50 pesos por cada uno de ellos, se ingresa el valor del vehiculo y cuantosvehiculos dee ese tipo vendio, calcular su sueldo e imprimirlo
        {
            int cantidad;
            decimal valor_vehiculo;
            decimal plus;
            decimal sueldo;


            Console.WriteLine("Por favor ingrese precio de vehiculo");
            valor_vehiculo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            plus = (((valor_vehiculo * cantidad) * 10) / 100) + 50;
            sueldo = 500 + plus;



            Console.WriteLine("El sueldo es:" + sueldo);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();




        }


private static void Secuencial4()

//4. Ingresar los lados de un triángulo calcular su perímetro e imprimirlo
{
           decimal lado1;
        decimal lado2;
        decimal lado3;
        decimal perimetro;

        Console.WriteLine("Por favor ingrese un lado del triangulo");

          lado1= decimal.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingrese otro lado del triangulo");
         lado2= decimal.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingrese otro lado del triangulo");
          lado3= decimal.Parse(Console.ReadLine());

        perimetro= lado1+lado2+lado3;

          Console.WriteLine("El perimetro del triangulo es:"+ perimetro);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();




        }
        private static void Secuencial5()
           // Ingresar dos lados de un triángulo rectángulo y calcular, la hipotenusa, el perímetro,la superficie.imprima los resultados solicitados
  {
         double lado1;
        double lado2;
        double hipotenusa;
        double perimetro;
        double superficie;

        Console.WriteLine("Por favor ingrese un lado del triangulo");

          lado1= double.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingrese otro lado del triangulo");
         lado2= double.Parse(Console.ReadLine());

        hipotenusa=Math.Sqrt(Math.Pow(lado1,2)+Math.Pow(lado2,2));
       

          Console.WriteLine("La hipotenusa es:"+ hipotenusa);
          
          perimetro= hipotenusa+lado1+lado2;
      Console.WriteLine("El perimetro es:"+ perimetro);
      superficie=(lado1* lado2)/2;
      
             Console.WriteLine("La superficie es:"+ superficie);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();



        }
        private static void Ejmaxminn3()

        {
            //Ingresar los sueldos y nombres de 30 empleados, indicar e imprimir el sueldomayor y a quién pertenece

            int n = 0; // Variable de control de ciclo

            decimal sueldo = 0;
            decimal maximo = 0;
            string nomempl;
            string nomempmax = "";
            int cantidad;


            // Pedimos la cantidad de empleados
            Console.WriteLine("Dane la cantidad de empleados");
            cantidad = int.Parse(Console.ReadLine());
            // Creamos el arreglo
            decimal[] sueldos = new decimal[cantidad];
            string[] empleados = new string[cantidad];
            // Capturamos la información
            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Ingrese nombre de empleado");
                nomempl = Console.ReadLine();
                empleados[n] = nomempl;
                Console.WriteLine("Ingrese sueldo de empleado");
                sueldo = decimal.Parse(Console.ReadLine());
                sueldos[n] = sueldo;

            }


            // Encontramos la calificación maxima
            for (n = 0; n < cantidad; n++)
            {
                if (sueldos[n] > maximo)
                    maximo = sueldos[n];
                nomempmax = empleados[n];
            }
            Console.WriteLine("El empleado" + nomempmax + "tiene maximo sueldo de:" + maximo);
            Console.WriteLine("Presione una tecla para finalizar");
            Console.Read();
        }






        }






}







    



















