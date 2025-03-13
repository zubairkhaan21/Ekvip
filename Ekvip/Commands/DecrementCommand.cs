using Ekvip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip.Commands
{
    /// <summary>
    /// Represents a command that decrements the result by 1.
    /// </summary>
    class DecrementCommand : ICommand
    {
        /// <summary>
        /// Decrements the current result by 1.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after decrementing.</returns>
        public int Execute(int currentResult) => currentResult - 1;

        /// <summary>
        /// Reverts the decrement operation by incrementing the result by 1.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after undoing the decrement.</returns>
        public int Undo(int currentResult) => currentResult + 1;
    }
}
