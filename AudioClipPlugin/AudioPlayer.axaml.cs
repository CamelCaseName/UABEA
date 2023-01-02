using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AudioClipPlugin
{
    public partial class AudioPlayer : Window
    {
        //todo create the ui in a standalone avalonia project
        public AudioPlayer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
