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

            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                //m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Words(id INTEGER PRIMARY KEY AUTOINCREMENT," +
                //    " word TEXT, part_of_speech TEXT);" +
                //    " INSERT INTO Words(word, part_of_speech) " + "VALUES ('apple', 'noun');";
                //  m_sqlCmd.CommandText = "INSERT INTO Words(word TEXT, part_of_speech TEXT)" + "VALUES ('apple', 'noun')";
                m_sqlCmd.ExecuteNonQuery();

                // lbStatusText.Content = "Connected";

            }
            catch (SQLiteException ex)
            {
                //lbStatusText.Content = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }


            // lbStatusText.Content = "Disconnected";
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

        private void Connetion_Click(object sender, RoutedEventArgs e)
        {
            //if (!File.Exists(dbFileName))
            //    SQLiteConnection.CreateFile(dbFileName);

            //try
            //{
            //    m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
            //    m_dbConn.Open();
            //    m_sqlCmd.Connection = m_dbConn;

            //    m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Words(id INTEGER PRIMARY KEY AUTOINCREMENT," +
            //        " word TEXT, part_of_speech TEXT);" + 
            //        " INSERT INTO Words(word, part_of_speech) " + "VALUES ('apple', 'noun');";
            //  //  m_sqlCmd.CommandText = "INSERT INTO Words(word TEXT, part_of_speech TEXT)" + "VALUES ('apple', 'noun')";
            //    m_sqlCmd.ExecuteNonQuery();

            //   // lbStatusText.Content = "Connected";

            //}
            //catch (SQLiteException ex)
            //{
            //    //lbStatusText.Content = "Disconnected";
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void AddWord_Click(object sender, RoutedEventArgs e)
        {
            m_sqlCmd.CommandText = "SELECT * FROM Words;";

        }

        private void DeleteWord_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void btCreate1_Click(object sender, RoutedEventArgs e)
        //{
        //    SQLiteCommand cmd = m_dbConn.CreateCommand();
        //    string sql_command = "DROP TABLE IF EXISTS person;"
        //      + "CREATE TABLE person("
        //      + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
        //      + "first_name TEXT, "
        //      + "last_name TEXT, "
        //      + "sex INTEGER, "
        //      + "birth_date INTEGER);"
        //      + "INSERT INTO person(first_name, last_name, sex, birth_date) "
        //      + "VALUES ('John', 'Doe', 0, strftime('%s', '1979-12-10'));"
        //      + "INSERT INTO person(first_name, last_name, sex, birth_date) "
        //      + "VALUES ('Vanessa', 'Maison', 1, strftime('%s', '1977-12-10'));"
        //      + "INSERT INTO person(first_name, last_name, sex, birth_date) "
        //      + "VALUES ('Ivan', 'Vasiliev', 0, strftime('%s', '1987-01-06'));"
        //      + "INSERT INTO person(first_name, last_name, sex, birth_date) "
        //      + "VALUES ('Kevin', 'Drago', 0, strftime('%s', '1991-06-11'));"
        //      + "INSERT INTO person(first_name, last_name, sex, birth_date) "
        //      + "VALUES ('Angel', 'Vasco', 1, strftime('%s', '1987-10-09'));";


        //}


    }
} 
