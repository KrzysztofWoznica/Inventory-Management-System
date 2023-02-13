using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;

namespace WPFInventoryManagementSystem.UI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;

             

        public string UserName
        {
            get { return _userName; }
            set { 
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get { return _password; }
            set {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn => UserName?.Length > 0 && Password?.Length> 0;
   

        public void LogIn()
        {

        }

     

    }
}
