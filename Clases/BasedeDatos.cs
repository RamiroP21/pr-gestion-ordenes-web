using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P_R_OBLIGATORIO.Clases
{
    public abstract class Basededatos
    {
        public static List<Cliente> misClientes = new List<Cliente>()
        {
            new Cliente{ Nombre="Sofía", Apellido="Pérez", Cedula="56483282", Direccion="Maldonado", Email="silviagonzalez0725@icloud.com", Telefono=092466434},
            new Cliente{ Nombre="Martín", Apellido="Álvarez", Cedula="46724033", Direccion="Maldonado", Email="alvarez.martin@gmail.com", Telefono=098234771},
            new Cliente{ Nombre="Uriel", Apellido="Chami", Cedula="46469373", Direccion="Montevideo", Email="chami.uriel@gmail.com", Telefono=095235664}

        };

        public static List<Tecnico> misTecnicos = new List<Tecnico>()
        {
            new Tecnico{Nombre="Pedro", Apellido="Betbeder", Cedula="56710229", Especialidad="Informática" },
            new Tecnico{Nombre="Ramiro", Apellido="Pereira", Cedula="56404511", Especialidad="Electrodomésticos" }
        };

        public static bool ValidarTecnico(string cedula)
        {
            return misTecnicos.Any(tecnico => tecnico.Cedula == cedula);
        }

        public static bool CedulaExiste(string cedula)
        {
            return misClientes.Any(cliente => cliente.Cedula == cedula) || misTecnicos.Any(tecnico => tecnico.Cedula == cedula);
        }

    }
}