using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ap1_josueosorio_20180938.BLL
{
    public class  Utilidades
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);

            return retorno;
        }
    }
}
