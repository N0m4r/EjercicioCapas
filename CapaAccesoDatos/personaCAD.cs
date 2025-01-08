using System.ComponentModel;
using Entidades;

namespace CapaAccesoDatos;

public static class personaCAD
{
    public static Boolean Crear(personaEntidad persona){

        Datos.DataPersona.Add(persona);
        
        return true;
    }
}

public static class Datos
{
    public static List<personaEntidad> DataPersona=new List<personaEntidad>();
}
