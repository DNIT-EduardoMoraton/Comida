using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {

        private ObservableCollection<Plato> dishes;     

        public ObservableCollection<Plato> Dishes
        {
            get { return dishes; }
            set { dishes = value; NotifyPropertyChanged("Dishes"); }
        }


        private Plato currDish;

        public Plato CurrDish
        {
            get { return currDish; }
            set { currDish = value; NotifyPropertyChanged("CurrDish"); }
        }


        public MainWindowVM()
        {
            this.dishes = Plato.GetSamples(Path.Combine(@"C:\Users\alumno\source\repos\Comida\img\foods"));
            currDish = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
