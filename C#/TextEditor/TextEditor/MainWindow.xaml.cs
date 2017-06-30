using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace TextEditor
{
    public partial class MainWindow : Window
    {
        private DocumentManager _documentManager;
        public MainWindow()
        {
            InitializeComponent();
            _documentManager = new DocumentManager(body);
            if (_documentManager.OpenDocument())
                status.Text = "Document loaded.";
        }

        private void TextEditorToolbar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (toolbar.IsSynchronizing) return;

            ComboBox source = e.OriginalSource as ComboBox;
            if (source == null) return;

            switch (source.Name)
            {
                case "fonts":
                    //change the font face
                    _documentManager.ApplyToSelection(TextBlock.
                        FontFamilyProperty, source.SelectedItem);
                    break;
                case "fontSize":
                    //change the font size
                    _documentManager.ApplyToSelection(TextBlock.
                        FontSizeProperty, source.SelectedItem);
                    break;
            }
            body.Focus();
        }

        private void body_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //update the tool bar
            toolbar.SynchronizeWith(body.Selection);
            
        }
    }
}
