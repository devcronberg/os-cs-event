using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    class Person2
    {
        public event EventHandler PropertyChanged;

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                OnPropertyChangedEventHandler("Id");
                id = value;
            }
        }

        private int name;

        public int Name
        {
            get { return name; }
            set
            {
                OnPropertyChangedEventHandler("Name");
                name = value;
            }
        }

        private void OnPropertyChangedEventHandler(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
