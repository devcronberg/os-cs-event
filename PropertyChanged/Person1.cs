using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    class Person1
    {
        public event EventHandler PropertyChanged;

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                OnPropertyChangedEventHandler();
                id = value;
            }
        }

        private int name;

        public int Name
        {
            get { return name; }
            set
            {
                OnPropertyChangedEventHandler();
                name = value;
            }
        }

        private void OnPropertyChangedEventHandler()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new EventArgs());
            }
        }

    }
}
