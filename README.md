# syncfusion-wpf-combobox-examples
This repository contains samples that demonstrate built-in functionalities of WPF ComboBoxAdv control.

* **<a href="Samples/Autocomplete">Autocomplete support</a>** - This sample shows the Autocomplete support in the WPF ComboBox control.
* **<a href="Samples/Token-support">Token support</a>** - This sample shows the token support in the WPF ComboBox control.
* **<a href="Samples/Dynamic-checked-items">Dynamic checked items</a>** - This sample shows the how to override the selected items programmatically by overriding the OnItemChecked and OnItemUnchecked methods in the WPF ComboBox control.

# Creating project
Below section provides detailed information to create new project in Visual Studio to display ComboBoxAdv.
# Adding control manually in XAML
In order to add ComboBoxAdv control manually in XAML, do the below steps,

1. Add the below required assembly references to the project,

   * Syncfusion.Shared.WPF
2. Import Syncfusion WPF schema http://schemas.syncfusion.com/wpf in XAML page or Syncfusion.Windows.Tools.Controls namespace.

3. Declare ComboBoxAdv in XAML page.
**[XAML]**

```
 <Grid>
      <syncfusion:ComboBoxAdv Height="30" Width="150"/>
 </Grid>
```

# Adding control manually in C#
In order to add ComboBoxAdv control manually in C#, do the below steps,

1. Add the below required assembly references to the project,

    * Syncfusion.Shared.WPF
2. Import ComboBoxAdv namespace Syncfusion.Windows.Tools.Controls.

3. Create ComboBoxAdv control instance and add it to the page.


**[C#]**
```
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ComboBoxAdv comboBoxAdv = new ComboBoxAdv();
        this.Content = comboBoxAdv;
        comboBoxAdv.Height = 30;
        comboBoxAdv.Width = 150;
        comboBoxAdv.DefaultText = "choose Items";
    }
}
```

#   Autocomplete support in the WPF ComboBox control
**[XAML]**

```
 <Grid x:Name="tokenGrid" VerticalAlignment="Center" HorizontalAlignment="Center">
        <TextBlock HorizontalAlignment="Left" Margin="-230,-195,-140,0" TextWrapping="Wrap" Text="This sample describes the AutoComplete support in ComboBoxAdv." VerticalAlignment="Top" Height="25" Width="480"/>
        <Grid Margin="-265,-152,-260,-205">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="Auto" MinWidth="330.667"/>
                <ColumnDefinition Width="Auto" MinWidth="10"/>
            </Grid.ColumnDefinitions>
            <Grid Margin="20,10,0.333,-10">
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="Auto"/>
                </Grid.RowDefinitions>
                <Label HorizontalAlignment="Left"
            Margin="30,81.333,0,-53.333"
            x:Name="label1"
            Content="Auto Complete combobox"
            FontWeight="Bold" Grid.Row="1"/>

            <syncfusion:ComboBoxAdv
            HorizontalAlignment="Center"
            Grid.Row="1"
            Width="250"
            Height="24"
            Margin="30,126.333,31,-95"
            x:Name="multiSelectionComboBox"
            AllowMultiSelect="{Binding ElementName=multiSelection, Path=IsChecked, Mode=OneWay}"
            EnableOKCancel="True"
            IsEditable="True"
            EnableToken="True"
            DisplayMemberPath="Name"
            ItemsSource="{Binding Collection}"
            AutoCompleteMode="{Binding ElementName=autoCompleteModes, Path=Text}"/>
            </Grid>
            <Grid Grid.Column="1" Margin="71.667,10,-283,10">
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="25"/>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="Auto"/>
                </Grid.RowDefinitions>
                <TextBlock
                    Margin="5"
                    FontWeight="Bold"
                    Text="AutoComplete Modes" />
                <ComboBox
                    x:Name="autoCompleteModes"
                    Grid.Row="1"
                    Height="24"
                    Margin="0,5,0,0"
                    SelectedIndex="0">
                    <ComboBoxItem>None</ComboBoxItem>
                    <ComboBoxItem>Suggest</ComboBoxItem>
                </ComboBox>
                <TextBlock
                    Margin="5"
                    Grid.Row="3"
                    FontWeight="Bold"
                    Text="ComboBox Modes" />
                <RadioButton
                    x:Name="singleSelection"
                    Grid.Row="4"
                    Margin="5"
                    GroupName="comboBoxModes"
                    IsChecked="True"
                    Content="Single Selection">
                </RadioButton>
                <RadioButton
                    x:Name="multiSelection"
                    Grid.Row="5"
                    Margin="5" 
                    GroupName="comboBoxModes"
                    Content="Multi Selection">
                </RadioButton>
            </Grid>
        </Grid>
    </Grid>
```

**ViewModel**

**[C#]**

```
 public class ComboBoxViewModel : NotificationObject
    {
        /// <summary>
        /// Maintains a collection for the items to be populated in combo box
        /// </summary>
        private ObservableCollection<Country> collection;

        /// <summary>
        /// Initializes the instance of <see cref="ComboBoxViewModel"/>class
        /// </summary>
        public ComboBoxViewModel()
        {
            UpdateCollection();
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
        }
    }
```
