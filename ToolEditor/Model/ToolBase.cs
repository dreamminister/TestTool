using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestTool.Model
{
    public abstract class PropertyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string caller = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
