using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankUWP.ViewModels
{
    public class Page2ViewModel //:INotifyPropertyChanged
    {
        private ObservableCollection<string> _list;

        public ObservableCollection<string> list
        {
            get { return _list; }
            set { _list = value; }
        }


        

    }
}
