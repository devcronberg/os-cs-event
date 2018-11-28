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
            get => this.id;
            set
            {
                this.OnPropertyChangedEventHandler();
                this.id = value;
            }
        }

        private int name;

        public int Name
        {
            get => this.name;
            set
            {
                this.OnPropertyChangedEventHandler();
                this.name = value;
            }
        }

        private void OnPropertyChangedEventHandler() => PropertyChanged?.Invoke(this, new EventArgs());

    }
}
