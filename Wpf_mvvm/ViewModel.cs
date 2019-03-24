using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_mvvm
{
    public class ViewModel : ViewModelBase
    {
        private double z;
        public string znak { get; set;}
        public int X { get; set; }
        public int Y { get; set; }
        public double Z
        {
            get { return z; }
            set
            {
                z = value;
                RaisePropertyChanged(() => Z);
            }
        }

        private ICommand calk;

        public ICommand Calk
        {
            get
            {
                return calk ?? (calk=new RelayCommand(() => 
                {
                    try
                    {
                        if (znak == "+") Z = X + Y;
                        else if (znak == "-") Z = X - Y;
                        else if (znak == "*") Z = X * Y;
                        else if (znak == "/") Z = X / Y;
                        else { Z = 0; }
                    }
                    catch { }

                }));
            }
        }
            
    }
}
