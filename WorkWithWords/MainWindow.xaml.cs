using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace WorkWithWords
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        public MainWindow()
        {
            InitializeComponent();


        }



        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            dbFileName = "sample.sqlite";
            lbStatusText.Content = "Disconnected";
            /*List < Words > result = new List<Words>();

            result.Add(new Words(1,"яблоко", "Существительное"));

            WordsGrid.ItemsSource = result;
            */
        }

        private void grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Words path = WordsGrid.SelectedItem as Words;

            MessageBox.Show(path.ID + "\n" + path.Word);

        }

        private void btCreate_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT, author TEXT, book TEXT)";
                m_sqlCmd.ExecuteNonQuery();

                lbStatusText.Content = "Connected";
            }
            catch (SQLiteException ex)
            {
                lbStatusText.Content = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
