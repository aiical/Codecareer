using System;
using System.Data;
using System.Windows;

namespace P15_2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        GeoDataSet geoDataSet = new GeoDataSet();
        GeoDataSetTableAdapters.ProvinceTableAdapter pAdapter = new GeoDataSetTableAdapters.ProvinceTableAdapter();
        GeoDataSetTableAdapters.CityTableAdapter cAdapter = new GeoDataSetTableAdapters.CityTableAdapter();
        GeoDataSetTableAdapters.SceneTableAdapter sAdapter = new GeoDataSetTableAdapters.SceneTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (DataTable dt in geoDataSet.Tables)
                comboBox1.Items.Add(dt.TableName);
            pAdapter.Fill(geoDataSet.Province);
            cAdapter.Fill(geoDataSet.City);
            sAdapter.Fill(geoDataSet.Scene);
        }

        private void comboBox1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            dataGrid1.ItemsSource = geoDataSet.Tables[comboBox1.SelectedIndex].DefaultView;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            pAdapter.Update(geoDataSet.Province);
            cAdapter.Update(geoDataSet.City);
            sAdapter.Update(geoDataSet.Scene);
        }
    }
}
