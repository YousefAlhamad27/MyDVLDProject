using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Course19
{
    internal static class MainProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool loginAgain = false;
            do
            {

                clsLogin clslogin = new clsLogin(clsLogin.ESignMode.SignIn, true);
                if (clsLogin._mode == clsLogin.ESignMode.Terminate) { 
               
                loginAgain = false;
            }
                else if(clsLogin._toTerminate == false)
                    loginAgain = true;
                //clsLogin clsLogin = new clsLogin(clsLogin.ESignMode.SignIn,true);
                //if (clsLogin._mode == clsLogin.ESignMode.Signout)
                //{
                //    loginAgain = true;

                    //}
                    //else if (clsLogin._mode == clsLogin.ESignMode.SignIn)
                    //    loginAgain = true;

                

            } while (loginAgain == true);

        }
    } 
}
