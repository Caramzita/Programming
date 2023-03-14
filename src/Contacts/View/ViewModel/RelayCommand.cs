using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация интерфейса <see cref="ICommand"/>.
    /// </summary>
    internal class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат, выполняющийся при вызове метода <see cref="Execute(object)"/>.
        /// </summary>
        private Action<object> _execute;

        /// <summary>
        /// Делегат, выполняющийся проверку может ли команда выполнится в текущий момент.
        /// </summary>
        private Predicate<object> _canExecute;

        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged
        {
            add 
            { 
                CommandManager.RequerySuggested += value; 
            }
            remove 
            { 
                CommandManager.RequerySuggested -= value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Команда для выполнение.</param>
        /// <param name="canExecute">Делегат проверки возможности выполнения команды. </param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет логику команды.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
