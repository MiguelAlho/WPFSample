using Caliburn.Micro;
using System.Windows;

namespace SampleApp {
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        string name;

        public string Name {
            get { return name; }
            set {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(Name);  }
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello {0}!", Name));   //don't do this in real life....
        }
    }
}