using CapaAccesoDatos;
using Entidades;

namespace CapaNegocio;

public static class personaCN
{
    public static bool CrearPersona(personaEntidad persona){
    
        return personaCAD.Crear(persona);
    }
}
