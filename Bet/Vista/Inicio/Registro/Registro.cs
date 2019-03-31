namespace Bet.Vista.Inicio.Registro
{
    using Bet.Utils;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class Registro
    {
        public string Usuario { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public string RespuestaPreguntaSeguridad { get; set; }

        public Opciones PreguntaSeguridadSeleccionada { get; set; }


        private readonly ObservableCollection<Opciones> opcionesPreguntaSeguridad = new ObservableCollection<Opciones>();
        public IEnumerable<Opciones> OpcionesPreguntaSeguridad => opcionesPreguntaSeguridad;

        public void Inicial()
        {
            CargarOpcionesSeguridad();
        }

        private void CargarOpcionesSeguridad()
        {
            opcionesPreguntaSeguridad.Clear();
            opcionesPreguntaSeguridad.Add(new Opciones
            {
                Valor = 1,
                Cadena = "Nombre de tu mascota"
            });
            opcionesPreguntaSeguridad.Add(new Opciones
            {
                Valor = 2,
                Cadena = "Lugar de nacimiento"
            });
            opcionesPreguntaSeguridad.Add(new Opciones
            {
                Valor = 3,
                Cadena = "Canción favorita"
            });
            opcionesPreguntaSeguridad.Add(new Opciones
            {
                Valor = 4,
                Cadena = "Película favorita"
            });
        }

        public string ValidacionDatos()
        {
            if (string.IsNullOrEmpty(Usuario))
                return "Ingrese Usuario";

            if (string.IsNullOrEmpty(Password))
                return "Ingrese su Contraseña";

            if (string.IsNullOrEmpty(PasswordConfirm))
                return "Confirme su Contraseña";

            if (Password != PasswordConfirm)
                return "La contraseña que ha ingresado no coincide";

            if (PreguntaSeguridadSeleccionada == null)
                return "Seleccione una Pregunta de Seguridad";

            if (string.IsNullOrEmpty(RespuestaPreguntaSeguridad))
                return "Ingrese su respuesta de Seguridad";

            return string.Empty;
        }
    }
}
