using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDataBindingExample
{
    class Person : INotifyPropertyChanged
    {
        int _id;
        string _name;
        string _img;
        
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Img {
            get
            {
                return _img;
            }
            set
            {
                _img = value;
                propertyChanged("img");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void propertyChanged(string prop)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
