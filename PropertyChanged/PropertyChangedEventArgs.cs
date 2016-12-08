using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    class PropertyChangedEventArgs : EventArgs
    {
        public string PropertyName { get; set; }

        public PropertyChangedEventArgs(string propertyName)
        {
            this.PropertyName = propertyName;
        }
    }
}
