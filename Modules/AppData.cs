using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewIT.Modules
{
    public static class AppData
    {
        public static ObservableCollection<Questions> ListOfQnA {  get; set; } = new ObservableCollection<Questions>();
    }
}
