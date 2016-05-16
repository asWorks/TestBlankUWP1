using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankUWP.ViewModels
{
    public class Page2ViewModel :INotifyPropertyChanged
    {
        //Testkommentar
        private ObservableCollection<string> _list;

        public ObservableCollection<string> list
        {
            get { return _list; }
            set { _list = value; }
        }

        public Page2ViewModel()
        {
            list = new ObservableCollection<string>();
            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test3");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        } 

    }
}
