using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bet.Auxiliares.Inicio.Registro
{
    public class Registro
    {
        public string Usuario { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public string OpcionPreguntaSeguridad { get; set; }

        public string RespuestaPreguntaSeguridad { get; set; }
    }
}
