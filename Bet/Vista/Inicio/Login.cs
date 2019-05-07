namespace Bet.Vista.Inicio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Login
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        ///// <summary>
        ///// Notify a property change
        ///// </summary>
        ///// <param name="propertyName">Name of property to update</param>
        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        ///// <summary>
        ///// Notify a property change that uses CallerMemberName attribute
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="backingField">Backing field of property</param>
        ///// <param name="value">Value to give backing field</param>
        ///// <param name="propertyName"></param>
        ///// <returns></returns>
        //protected virtual bool OnPropertyChanged<T>(ref T backingField, T value, [CallerMemberName] string propertyName = "")
        //{
        //    if (EqualityComparer<T>.Default.Equals(backingField, value))
        //        return false;

        //    backingField = value;
        //    OnPropertyChanged(propertyName);
        //    return true;
        //}

        //private string _username;
        //public string Username
        //{
        //    get { return _username; }
        //    set
        //    {
        //        OnPropertyChanged(ref _username, value);
        //    }
        //}

        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                SetPropertyValue(ref username, value);
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                SetPropertyValue(ref password, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected bool SetPropertyValue<T>(ref T currentValue, T newValue, [CallerMemberName] String propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(currentValue, newValue))
            {
                return false;
            }

            currentValue = newValue;

            this.RaisePropertyChanged(propertyName);

            return true;
        }

        //public string Username { get; set; }

        //public string Password { get; set; }

        public string ValidacionLogin()
        {
            var username = Username;
            var password = Password;

            if (string.IsNullOrEmpty(username) && (string.IsNullOrEmpty(password)))
            {
                return "Ingrese su usuario y contraseña";
            }
            else
                if (username == "Hunter" && password == "PerroRojo")
            {
                return string.Empty;
            }
            else
            {
                //this.Username = string.Empty;
                //this.Password = string.Empty;
                return "Usuario o contraseña incorrecta";
            }
        }
    }
}
