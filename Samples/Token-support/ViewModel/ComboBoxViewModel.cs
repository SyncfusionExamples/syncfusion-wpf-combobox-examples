using System.Collections.ObjectModel;
using Syncfusion.Windows.Shared;

namespace TokenDemo
{
    /// <summary>
    /// Represents the combo box viewmodel class
    /// </summary>
    public class ComboBoxViewModel : NotificationObject
    {
        /// <summary>
        /// Maintains a collection for the items to be populated in combo box
        /// </summary>
        private ObservableCollection<Country> collection;

        /// <summary>
        /// Represents the collection for default selected item in combo box
        /// </summary>        
        private ObservableCollection<Country> defaultSelectedItemCollection = new ObservableCollection<Country>();

        /// <summary>
        /// Initializes the instance of <see cref="ComboBoxViewModel"/>class
        /// </summary>
        public ComboBoxViewModel()
        {
            UpdateCollection();
        }

        /// <summary>
        /// Gets or sets a collection for default selected item
        /// </summary>
        public ObservableCollection<Country> DefaultSelectedItemCollection
        {
            get
            {
                return defaultSelectedItemCollection;
            }
            set
            {
                defaultSelectedItemCollection = value;
                RaisePropertyChanged("defaultSelectedItemCollection");
            }
        } 
        /// <summary>
        /// Gets or sets a collection for storing the items to be populated in combo box
        /// </summary>
        public ObservableCollection<Country> Collection
        {
            get
            {
                return collection;
            }
            set
            {
                collection = value;
                RaisePropertyChanged("Collection");
            }
        }

        /// <summary>
        /// Method for populating items in combo box
        /// </summary>
        public void UpdateCollection()
        {
            Collection = new ObservableCollection<Country>();
            Collection.Add(new Country()
            {
                Name = "United Kindom",
                Code = "UK"
            });
            Collection.Add(new Country()
            {
                Name = "Canada",
                Code = "CA"
            });
            Collection.Add(new Country()
            {
                Name = "Germany",
                Code = "DE"
            });
            Collection.Add(new Country()
            {
                Name = "India",
                Code = "IN"
            });
            Collection.Add(new Country()
            {
                Name = "United States of America",
                Code = "USA"
            });

            defaultSelectedItemCollection.Add(Collection[1]);
            defaultSelectedItemCollection.Add(Collection[2]);
        }
    }
}
