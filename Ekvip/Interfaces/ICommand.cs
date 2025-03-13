using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip.Interfaces
{
    /// <summary>
    /// Represents a command that can be executed and undone.
    /// </summary>
    interface ICommand
    {
        /// <summary>
        /// Executes the command and returns the new result.
        /// </summary>
        /// <param name="currentResult">The current result value before executing the command.</param>
        /// <returns>The new result value after executing the command.</returns>
        int Execute(int currentResult);

        /// <summary>
        /// Reverts the effect of the command and returns the previous result.
        /// </summary>
        /// <param name="currentResult">The current result value before undoing the command.</param>
        /// <returns>The result value after undoing the command.</returns>
        int Undo(int currentResult);
    }
}
