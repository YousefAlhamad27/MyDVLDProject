using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course19
{
    public class clsLogin
    {
       public enum ESignMode {Terminate=1,Signout=2, SignIn =3};
    static  public  ESignMode _mode;
     
        bool _toLogin;
   static public  bool _toTerminate=true;
        public clsLogin(ESignMode mode,bool toLogin = false, Main main = null)
        {
             _mode = mode;
            if (mode == ESignMode.Terminate)
                _toTerminate = true;
                 _toLogin= toLogin;

                login();

        }
       

        public void login()
        {
           
           
            UserLoginForm form = new UserLoginForm();
            
            form.ShowDialog();
            if (_toTerminate == true)
                _mode = ESignMode.Terminate;
                if (form.returnIsAuthorized()) {

                Main main = new Main();
                main.ShowDialog();
                _mode = main._mode;
                
            }   
            else if (_mode==ESignMode.Signout)
            {
                new Main().ShowDialog();


            }
            else
            {
                _toLogin = false;
                return;
            }

        }
     
      public bool returnToTerminate()
        {
            return _toTerminate;
        }
       static public void setToTerminate(bool toTerminate)
        {
            _toTerminate = toTerminate;
        }
        public bool returnToLogin()
        {
            
            return _toLogin;
        }
    
    }
}
