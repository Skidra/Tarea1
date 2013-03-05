using System;
 
namespace Application
{
	public class Persona
	{
		public string Nombre;
		public string Telefono;
		public string Domicilio;
		public string Correo_elec;

		public static void Main (string[] args)
		{
			Persona guardar = new Persona();
			Console.WriteLine("Introduce tu Nombre: ");
			guardar.Nombre=Console.ReadLine();
			Console.WriteLine ("Introduce tu Telefono: ");
			guardar.Telefono=Console.ReadLine();
			Console.WriteLine ("Introduce tu Domicilio: ");
			guardar.Domicilio=Console.ReadLine();
			Console.WriteLine ("Introduce tu Correo Electronico: ");
			guardar.Correo_elec=Console.ReadLine();

			Console.WriteLine ("Tu Nombre es: "+guardar.Nombre);
			Console.WriteLine ("Tu Domicilio es: "+guardar.Domicilio);
			Console.WriteLine ("Tu Telefono es: "+guardar.Telefono);
			Console.WriteLine ("Tu Correo Electronico es: "+guardar.Correo_elec);
		}
	}
}
