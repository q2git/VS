using System.Windows.Input;
namespace PreviewEvents
{
    public partial class Window1
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Handler(object sender, KeyEventArgs e)
        {
            bool isPreview = e.RoutedEvent.Name.StartsWith("Preview");
            string direction = isPreview ? "v" : "^";
            Output.Items.Add(string.Format("{1} --> {0}", direction, sender.GetType().Name));
            if (sender == e.OriginalSource && isPreview)
                Output.Items.Add("-{ bounce} -");
            if (sender == this && !isPreview)
                Output.Items.Add(" -end - ");
        }
    }
}