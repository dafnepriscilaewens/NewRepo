using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MiPrimerPrograma
{
    class Program
    {
        //1) Método que no recibe argumentos y retorna void

        /// <summary>
        /// Método que no recibe argumentos y retorna void
        /// </summary>
        
        static void Main(string[] args)
        {
            
            
            static void Ejercicio3()
            {
            
            decimal sueldo=0;
            decimal promedio=0;
            decimal total=0;
            int contador=0;
            int n=0;
        
             Console.WriteLine("Ingrese cantidad de empleados");
            n = int.Parse(Console.ReadLine());
          

            while (contador<n)
            {
               Console.WriteLine("Ingrese el sueldo");
               sueldo=decimal.Parse(Console.ReadLine());
               total=total+sueldo;
               contador=contador+1;
               }
               promedio=total/contador;
           Console.WriteLine("El sueldo promedio es:"+promedio);  
           Console.WriteLine("la suma es:"+total);  
           
           
                  }
                  
                  
                  
                  
                  
                  
                  
        
          static void Ejercicio4()
         // ingresar facturas hasta nro de factura = 0, sumar sus importes y cúales y cuantassuperan los $1000.imprimir los resultados
                      {
                  
            decimal total=0;
            decimal monto=0;
            int nrofact=1;
            int  contmayor1000=0;  
            int conttotal=0;
           int contmayor10000=0;
           decimal montomayor10000=0;
            decimal contentre400y700=0;
            decimal montoentre400y700=0;
            decimal montomayor1000=0;
            
         Console.WriteLine("Ingrese nro de factura");
          nrofact = int.Parse(Console.ReadLine());
           while (nrofact != 0)
            {
         
            Console.WriteLine("Ingrese monto de factura");
           monto = decimal.Parse(Console.ReadLine());
             total=total+monto;
            if ((monto >1000 && monto<10000)) {
            
            contmayor1000=contmayor1000+1;
            montomayor1000=montomayor1000+monto;
             Console.WriteLine("Ingrese nro de factura");
            nrofact = int.Parse(Console.ReadLine());
            
            }
            else if(monto > 10000)    {
            contmayor10000=contmayor10000+1;
            montomayor10000=montomayor10000+monto;
             Console.WriteLine("Ingrese nro de factura");
             nrofact = int.Parse(Console.ReadLine());
                }
                
            else if ((monto >400 && monto<700)){
                contentre400y700=contentre400y700+1;
                montoentre400y700=montoentre400y700+monto;
                Console.WriteLine("Ingrese nro de factura");
                nrofact = int.Parse(Console.ReadLine());
            }
                
            else
            {
            conttotal=conttotal+1;
             Console.WriteLine("Ingrese nro de factura");
          nrofact = int.Parse(Console.ReadLine());
            
                 }
            
            
           // acumuladorcont=acumuladorcont+contmayor1000+1;
            //acumuladormonto=acumuladormonto+montomayor1000;
            }
            
            Console.WriteLine("Las facturas que superan los $1000 son:"+contmayor1000);
            Console.WriteLine("el monto total de las mayores a $1000 es:"+montomayor1000);
             Console.WriteLine("Las facturas que superan los $10000 son:"+contmayor10000);
            Console.WriteLine("el monto total de las mayores a $10000 es:"+montomayor10000);
             Console.WriteLine("Las facturas entre $400 y $700 son:"+contentre400y700);
            Console.WriteLine("el monto total entre $400 y $700  es:"+montoentre400y700);
            
                      }
                   
          static void Ejerciciovalores3()
          
          {
         //Ingresar los sueldos y nombres de 30 empleados, indicar e imprimir el sueldomayor y a quién pertenece
             int cantidad = 0; // Cantidad de empleados
                int n = 0; // Variable de control de ciclo
                
                    decimal sueldo=0;
                    decimal maximo=0;
                    string nomempl="";
                    string nomempmax="";
                    

// Pedimos la cantidad de empleados
          Console.WriteLine("Dane la cantidad de empleados");
          cantidad = int.Parse(Console.ReadLine());
          // Creamos el arreglo
            decimal[] sueldos = new decimal[cantidad];
            string[] empleados= new string[cantidad];
            // Capturamos la información
            for (n = 0; n < cantidad; n++)
            {
          Console.WriteLine("Ingrese nombre de empleado");
          nomempl=Console.ReadLine();
          empleados[n] =nomempl;
          Console.WriteLine("Ingrese sueldo de empleado"); 
          sueldo=decimal.Parse(Console.ReadLine());
          sueldos[n] = sueldo;
          
                }
            

// Encontramos la calificación maxima
for (n = 0; n < cantidad; n++)
{
if (sueldos[n] > maximo)
maximo=sueldos[n];
nomempmax=empleados[n];
}

// Desplegamos los resultados
Console.WriteLine($"El empleado:{nomempmax} tiene el sueldo maximo:{maximo}");


             
          }             
                      
                      
                      
                      
              
          static void Ejercicio12()     
          {
        // Ingresar los datos de facturación de una empresa.Número de facturaNúmero de artículoCantidad vendidaPrecio unitarioLos datos finalizan con numero de factura = 0, cada factura sólo tiene un númerode artículo, existen tres artículosSe desea saber :Valor de cada facturaFacturación totalCuánto se vendio del artículo 1 en cantidadCuántas facturas mayores de $ 3000 se hicieronQué porcentaje representa el monto vendido por cada artículosobre el total
        int nrofact=0;
        int cantidad=0;
        int nroart=0;
        decimal precio=0;
        decimal totalfactura=0;
        decimal acumuladortotal=0;
        decimal totalart1=0;
        decimal totalart2=0;
        decimal totalart3=0;
        int contart1=0;
        int mayora3000=0;
        int menora3000=0;
       decimal porcentajeart1=0;
      decimal porcentajeart2=0;
      decimal porcentajeart3=0;
       
        
          Console.WriteLine("Ingrese nro de factura");
          nrofact = int.Parse(Console.ReadLine());
        
        while (nrofact!=0)
        {
           Console.WriteLine("Ingrese nro de articulo");
           nroart=int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese cantidad vendida");
           cantidad= int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese precio unitario");
           precio= decimal.Parse(Console.ReadLine());
           
           
           totalfactura=cantidad*precio;
           Console.WriteLine($"El total de factura nro {nrofact} es {totalfactura}");
           Console.WriteLine("Ingrese nro de factura");
           nrofact = int.Parse(Console.ReadLine());
          
           
           
           if (nroart==1){
               contart1=contart1+cantidad;
               totalart1=totalart1+totalfactura;
           }
               else if(nroart==2){
                totalart2=totalart2+totalfactura;   
           }
           else{
               totalart3=totalart3+totalfactura;
             
           }
           
           if (totalfactura >3000){           
           mayora3000=mayora3000+1;
                  }
           else{
               menora3000=menora3000+1;
           }
           
          acumuladortotal=acumuladortotal+totalfactura;
         
        porcentajeart1=(totalart1/acumuladortotal)*100;
         
        porcentajeart2=(totalart2/acumuladortotal)*100; 
           
        porcentajeart3=(totalart3/acumuladortotal)*100;
                }
            Console.WriteLine($"El total facturado es: {acumuladortotal}");
            Console.WriteLine($"La cantidad vendida de articulo1 es: {contart1}");
            Console.WriteLine($"La cantidad de facturas mayores a 3000 es: {mayora3000}");
        Console.WriteLine($"Porcentaje vendido de articulo1{porcentajeart1}");
        Console.WriteLine($"Porcentaje vendido de articulo2{porcentajeart2}");
        Console.WriteLine($"Porcentaje vendido de articulo3{porcentajeart3}");
            
          }
          
          
          static void Ejerciciovalores1(){
             // Ingresar N temperaturas , indicar e imprimir la máxima y mínima
             int cantidad = 0; // Cantidad de temperaturas
                int n = 0; // Variable de control de ciclo
                    decimal temp=0;
                    decimal minima=0;
                    decimal maxima=0;
                    

// Pedimos la cantidad detemperaturas
       Console.WriteLine("Dane la cantidad de temperaturas");
          cantidad = int.Parse(Console.ReadLine());
          // Creamos el arreglo
            decimal[] temperatura = new decimal[cantidad];
            // Capturamos la información
            for (n = 0; n < cantidad; n++)
            {
           Console.WriteLine("Dane la  temperatura");
           temp=decimal.Parse(Console.ReadLine());
            temperatura[n] = temp;
                }
            // Encontramos la calificación mínima
for (n = 0; n < cantidad; n++)
{
if (temperatura[n] < minima)
minima = temperatura[n];
}

// Encontramos la calificación maxima
for (n = 0; n < cantidad; n++)
{
if (temperatura[n] > maxima)
maxima =temperatura[n];
}

// Desplegamos los resultados
Console.WriteLine($"La temperatura minima es:{minima}");
Console.WriteLine($"La temperatura maxima es:{maxima}");

             
          }
          
          
          
          
          
            
          static void Ejercicio10Bucles()
        {
            //Ingresar la patente y monto de la multa de 5 autos, 
            //indicar e imprimir cuántos montos superan los $ 40 y del total 
            //cobrado que porcentaje representa la suma de los que superan los $40


            //VARIABLES
           
            decimal monto = 0;
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
        }
        // Ejercicio10Bucles();
          //Ejercicio3();
         // Ejercicio4();
         //Ejercicio12();
        // Ejerciciovalores1();
         Ejerciciovalores3();
          
    }
    }
}


    
  