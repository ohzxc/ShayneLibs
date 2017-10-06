using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Shayne.Common
{
    /// <summary>
    /// 通知对象
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
