using System;
using System.Collections.Generic;
using System.Text.RegularExpressions; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion_datos_U2
{
    class Validadores
    {
        static public Boolean validaEmail(String email)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }



    }
}
