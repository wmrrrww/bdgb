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
using System.Diagnostics;

namespace pr_12_badin_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Данный метод открывает окно с руководством оператора
        /// </summary>
        /// <exception> 
        /// Для корректной работы нужно указать путь к папке где находится 
        /// само окно руководства, а также html файлы
        /// </exception>
        /// <remarks>
        /// Данный метод требует использования библиотеки System.Diagnostics
        /// </remarks>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Users\\HONOR\\Desktop\\htmls\\help.chm");
        }
    }
}
