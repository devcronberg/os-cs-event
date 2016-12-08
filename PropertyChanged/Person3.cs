using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    //delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);
    class Person3
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<PropertyChangedEventArgs> PropertyChanged;
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
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
