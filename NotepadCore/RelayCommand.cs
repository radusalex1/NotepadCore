using System;
using System.Windows;
using System.Windows.Input;

namespace NotepadCore
{
    public class RelayCommand : ICommand
    {

        readonly Action _execute;
        readonly Func<bool> _canExecute;
        private Action<object, RoutedEventArgs> btnDelete_Click;

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if(execute == null)
            {
                throw new NullReferenceException("execute");
            }
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action execute):this(execute,null)
        {

        }

        public RelayCommand(Action<object, RoutedEventArgs> btnDelete_Click)
        {
            this.btnDelete_Click = btnDelete_Click;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
