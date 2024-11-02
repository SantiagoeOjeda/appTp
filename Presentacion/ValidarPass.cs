using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Presentacion
{
    public class ValidarPass
    {
        private string contrasena;

        public string Contrasena
        {
            set
            {
                contrasena = value;
            }
        }

        public bool Valid()
        {
            // Expresión regular para una contraseña segura: 
            // Mínimo 8 caracteres, al menos una letra mayúscula y un número
            string validacion = @"^(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$";

            // Comprobar si la contraseña cumple con el patrón
            return Regex.IsMatch(contrasena, validacion);
        }
    }
}
