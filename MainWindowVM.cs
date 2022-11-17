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

        private List<string> countries;

        public List<string> Countries
        {
            get { return countries; }
            set { countries = value; NotifyPropertyChanged("Countries");  }
        }


        public MainWindowVM()
        {
            this.dishes = Plato.GetSamples(Path.Combine(Environment.CurrentDirectory, @"\img\foods"));
            Countries = new List<string>();
            Countries.Add("Americana");
            Countries.Add("China");
            Countries.Add("Mexicana");
            currDish = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void clearSelecction()
        {
            CurrDish = null;
        }


    }
}
