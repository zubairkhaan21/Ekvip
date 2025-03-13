using Ekvip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip.Commands
{
    /// <summary>
    /// Represents a command that doubles the result.
    /// </summary>
    class DoubleCommand : ICommand
    {
        /// <summary>
        /// Doubles the current result.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after doubling.</returns>
        public int Execute(int currentResult) => currentResult * 2;

        /// <summary>
        /// Reverts the doubling operation by halving the result.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after undoing the doubling.</returns>
        public int Undo(int currentResult) => currentResult / 2;
    }
}
