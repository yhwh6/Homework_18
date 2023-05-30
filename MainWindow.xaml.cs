using Homework_18.Models;
using Homework_18.Services;
using System.Windows;


namespace Homework_18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataBase db = new DataBase();
        public MainWindow()
        {
            InitializeComponent();

            IDbLoad dataLoader = new DataBaseTest();

            dataLoader.Load(db, "");

            dataGrid.ItemsSource = db.Animals;

        }

        private void SaveDB_Button(object sender, RoutedEventArgs e)
        {
            IDbSave dataSaver = new JsonDbSave();
            db.SaveData(dataSaver, "animals.json");
        }

        private void LoadDB_Button(object sender, RoutedEventArgs e)
        {
            IDbLoad dataLoader = new JsonDbLoad();
            db.LoadData(dataLoader, "animals.json");
        }

        private void RefreshDataGrid()
        {
            dataGrid.Items.Refresh();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            IAnimalCreator animalCreator = new Creator();

            var newAnimal = animalCreator.Create<NullClass>("Empty", "Empty");
            db.Animals.Add(newAnimal);

            RefreshDataGrid();

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem is IClass selectedAnimal)
            {
                db.Animals.Remove(selectedAnimal);
                RefreshDataGrid();
            }
        }
    }
}
