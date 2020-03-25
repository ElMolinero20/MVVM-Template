using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace MVVM.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public void RaisePropertyChanged(Expression<Func<object>> expression)
        {
            string propertyName = ((MemberExpression)expression.Body).Member.Name;
            RaisePropertyChanged(propertyName);
        }
    }
}