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

namespace MatrixOperations.Views
{
    /// <summary>
    /// Логика взаимодействия для MatrixView.xaml
    /// </summary>
    public partial class MatrixView : UserControl
    {
        public MatrixView()
        {
            InitializeComponent();
            EventManager.RegisterClassHandler(typeof(System.Windows.Controls.TextBox), TextBox.GotKeyboardFocusEvent, new KeyboardFocusChangedEventHandler(OnGotKeyboardFocus));
        }
        
        void OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            var textBox = sender as TextBox;

            if (textBox != null && !textBox.IsReadOnly && e.KeyboardDevice.IsKeyDown(Key.Tab))
                textBox.SelectAll();            
        }
    }
}
