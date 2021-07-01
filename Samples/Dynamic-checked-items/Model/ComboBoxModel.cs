using Syncfusion.Windows.Shared;

namespace OverrideDemo
{
    /// <summary>
    /// Represents the model class for combo box 
    /// </summary>
    public class Country : NotificationObject
    {
        /// <summary>
        /// Represents the name of the country
        /// </summary>
        private string name;

        /// <summary>
        /// Gets or sets the value for name of the country <see cref="Country"/> class.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }
    }
}
