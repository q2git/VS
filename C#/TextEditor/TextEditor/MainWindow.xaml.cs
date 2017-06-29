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
    }
}
