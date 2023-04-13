using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class MainVM : ViewModelBase
    {
        private ICommand _buttonOkCommand;

        public ICommand ButtonOkCommand 
        {
            get
            {
                return _buttonOkCommand ?? (_buttonOkCommand = new CommandHandler(() => OnClick(), () => CanExecute));
            }
        }

        public bool CanExecute
        {
            get
            {
                // check if executing is allowed, i.e., validate, check if a process is running, etc. 
                return true;
            }
        }

        public void OnClick()
        {


        }
    }
}
