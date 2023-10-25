using System;
using System.Collections.Generic;



class Program
{
    public class Empleado
    {

        public String apellido;
        public DateTime fechanac;
        private String telefono;
        private DateTime fechaalta;
        private int legajo;

        public Empleado(string apellido, DateTime fechanac, string telefono, DateTime fechaalta, int legajo)
        {

            this.apellido = apellido;
            this.fechanac = fechanac;
            this.telefono = telefono;
            this.fechaalta = fechaalta;
            this.legajo = legajo;
        }

        public void ObtenerSueldo()
        {
            Console.WriteLine("Estoy obteniendo sueldo empleado");

        }

       
        public Empleado()
        {
            Console.WriteLine("Sou metodo por defecto");
        }




        public void SolicitarVacaciones()
    {

        Console.WriteLine("Estoy solicitando vacaciones");
    }
        public void SetLegajo(int legajo)
        {
            this.legajo=legajo;
        }


}

    

    public static void Main(string[] args)
    {


        Empleado priscila;

        priscila = new Empleado("Ewens", new DateTime(1980, 02, 18), "2216149339", new DateTime(2020, 02, 18), 899);


     
        priscila.ObtenerSueldo();

        //List<Empleado> empleados = new System.Collections.Generic.List<Empleado>();



    }
}



