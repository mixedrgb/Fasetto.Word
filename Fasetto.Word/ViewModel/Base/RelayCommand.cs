using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// A basic command that runs an action
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private Members
        /// <summary>
        /// The action to run
        /// </summary>
        private Action _mAction;
        #endregion

        #region Public Events
        /// <summary>
        /// The event that's fired when the <see cref="CanExecute(object)"/> value ahs changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayCommand(Action action)
        {
            _mAction = action;
        }
        #endregion

        #region Command Methods
        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _mAction();
        }
        #endregion
    }
}
