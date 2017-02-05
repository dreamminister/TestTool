using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestTool.Model
{
    public class ToolBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged<T>([CallerMemberName]string caller = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }
    }
}
