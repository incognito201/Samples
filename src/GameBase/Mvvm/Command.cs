/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 30/04/2022
 * Time: 00:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Input;

namespace GameBase.Mvvm
{
	/// <summary>
	/// Description of Command.
	/// </summary>
    public class Command : ICommand
    {
        readonly Action commandAction;
        bool canExecute;

        public Command(Action commandAction, bool canExecute = true)
        {
            this.commandAction = commandAction;
            this.canExecute = canExecute;
        }

        bool ICommand.CanExecute(object parameter)
        {
            return canExecute;
        }

        public bool CanExecute
        {
            get { return canExecute; }
            set
            {
                if (canExecute != value)
                {
                    canExecute = value;

                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        public event EventHandler CanExecuteChanged;

        void ICommand.Execute(object parameter)
        {
            if (commandAction != null)
            {
                commandAction();
            }
        }
    }
}
