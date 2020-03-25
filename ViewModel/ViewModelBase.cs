using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace MVVM.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Implementation of the INotifyPropertyChanged interface.
        /// It provides the PropertyChanged event which is fired when user controls are activated.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fires the PropertyChanged.
        /// </summary>
        /// <param name="expression">Takes the lambda expression without parameters and returns the property.</param>
        public void RaisePropertyChanged(Expression<Func<object>> expression)
        {
            string propertyName = ((MemberExpression)expression.Body).Member.Name;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}