using Ekvip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip.Commands
{
    /// <summary>
    /// Represents a command that reverts the most recent non-undo command.
    /// </summary>
    class UndoCommand : ICommand
    {
        private Stack<int> _history;

        /// <summary>
        /// Initializes a new instance of the <see cref="UndoCommand"/> class.
        /// </summary>
        /// <param name="history">The history stack containing previous results.</param>
        public UndoCommand(Stack<int> history)
        {
            _history = history;
        }

        /// <summary>
        /// Reverts the most recent non-undo command by restoring the previous result from the history.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after undoing the most recent command.</returns>
        public int Execute(int currentResult)
        {
            if (_history.Count > 1)
            {
                _history.Pop(); // Remove the current result
                return _history.Peek(); // Revert to the previous result
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
                return currentResult;
            }
        }

        /// <summary>
        /// This operation is not supported for the undo command.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The same result value, as undo cannot be undone.</returns>
        public int Undo(int currentResult) => currentResult;
    }
}
