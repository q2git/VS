using System;
using System.Windows;
using System.Windows.Controls;


namespace TextEditor
{
    /// <summary>
    /// Interaction logic for TextEditorMenu.xaml
    /// </summary>
    public partial class TextEditorMenu : UserControl
    {
        private DocumentManager _documentManager;

        public TextEditorMenu()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Teach Yourself WPF in 24 Hours - Text Editor",
            "About");
        }

        private void Exception_Click(object sender, RoutedEventArgs e)
        {
            throw new Exception();
        }
    }
}
