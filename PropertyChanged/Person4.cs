using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    class Person4 : INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                OnPropertyChangedEventHandler("id");
                id = value;
            }
        }

        private int name;


        public int Name
        {
            get { return name; }
            set
            {
                OnPropertyChangedEventHandler("name");
                name = value;
            }
        }

        private void OnPropertyChangedEventHandler(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(name));
            }
        }
    }
}
