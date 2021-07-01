using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;

namespace OverrideDemo
{
    /// <summary>
    /// Represents the combo box viewmodel class
    /// </summary>
    public class ComboBoxViewModel : NotificationObject
    {
        /// <summary>
        /// Maintains the collection of countries and continents.
        /// </summary>
        private ObservableCollection<object> continentCollection;

        /// <summary>
        /// Initializes the instance of <see cref="ComboBoxViewModel"/>class
        /// </summary>
        public ComboBoxViewModel()
        {
            UpdateCollection();
        }

        /// <summary>
        /// Gets or sets the name of the countries and continents <see cref="ComboBoxViewModel"/> class.
        /// </summary>
        public ObservableCollection<object> Continent
        {
            get { return continentCollection; }
            set
            {
                continentCollection = value;
                RaisePropertyChanged("Continent");
            }
        }

        /// <summary>
        /// Method for populating items in combo box
        /// </summary>
        public void UpdateCollection()
        {
            continentCollection = new ObservableCollection<object>()
            {
                new Country(){ Name = "Asia" },
                new Country(){ Name = "India" },
                new Country(){ Name = "China" },
                new Country(){ Name = "Africa" },
                new Country(){ Name = "Europe" },
                new Country(){ Name = "France" },
                new Country(){ Name = "Spain" },
                new Country(){ Name = "North America" },
                new Country(){ Name = "Canada" },
                new Country(){ Name = "Cuba" },
                new Country(){ Name = "Australia" }
            };
        }
    }
}
