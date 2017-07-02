using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace TextEditor
{
    public partial class MainWindow : Window
    {
        private DocumentManager _documentManager;
        private readonly PrintManager _printManager;

        public MainWindow()
        {
            InitializeComponent();
            _documentManager = new DocumentManager(body);
            if (_documentManager.OpenDocument())
                status.Text = "Document loaded.";

            _printManager = new PrintManager(body);
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

        private void NewDocument(object sender, ExecutedRoutedEventArgs e)
        {
            _documentManager.NewDocument();
            status.Text = "New Document";
        }
        private void OpenDocument(object sender, ExecutedRoutedEventArgs e)
        {
            if (_documentManager.OpenDocument())
                status.Text = "Document loaded.";
        }
        private void SaveDocument(object sender, ExecutedRoutedEventArgs e)
        {
            if (_documentManager.SaveDocument())
                status.Text = "Document saved.";
        }
        private void SaveDocumentAs(object sender, ExecutedRoutedEventArgs e)
        {
            if (_documentManager.SaveDocumentAs())
                status.Text = "Document saved.";
        }
        private void PrintDocument(object sender, ExecutedRoutedEventArgs e)
        {
            //PrintDialog dlg = new PrintDialog();
            //if (dlg.ShowDialog()==true)
            //{
            //    dlg.PrintDocument((((IDocumentPaginatorSource)body.Document).DocumentPaginator),"Text Editor Printing");
            //}
            if (_printManager.Print())
                status.Text = "Document sent to printer.";
        }

        private void ApplicationClose(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void SaveDocument_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _documentManager.CanSaveDocument();
        }

        private void PrintPreview(object sender, ExecutedRoutedEventArgs e)
        {
            _printManager.PrintPreview();
        }
    }
}
