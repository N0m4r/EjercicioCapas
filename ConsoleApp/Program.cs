using CapaNegocio;
using Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        personaEntidad persona=new personaEntidad();

        Console.WriteLine("Registro de persona");
        Console.WriteLine("--------------------");
        Console.WriteLine("Ingrese su Nro. de Identidad:");
        persona.Identificacion=Console.ReadLine();
        Console.WriteLine("Ingrese su nombre:");
        persona.Nombres=Console.ReadLine();
        Console.WriteLine("Ingrese su Apellido:");
        persona.Apellidos=Console.ReadLine();
        Console.WriteLine("Ingrese su Fecha de Nacimiento:");
        persona.FNacimiento=Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Ingres su genero (1) masculino, (2) femenino:");
        persona.Idgenero=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese su Sueldo:");
        persona.Sueldo=Convert.ToDecimal(Console.ReadLine());

        if (personaCN.CrearPersona(persona))
            Console.WriteLine("Registro Satisfactorio");
        else
            Console.WriteLine("Error en el registro");
        
        Console.ReadKey();
    }
}