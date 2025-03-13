using Ekvip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip.Commands
{
    /// <summary>
    /// Represents a command that increments the result by 1.
    /// </summary>
    class IncrementCommand : ICommand
    {
        /// <summary>
        /// Increments the current result by 1.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after incrementing.</returns>
        public int Execute(int currentResult) => currentResult + 1;

        /// <summary>
        /// Reverts the increment operation by decrementing the result by 1.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after undoing the increment.</returns>
        public int Undo(int currentResult) => currentResult - 1;
    }
}
