using Ekvip.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekvip.Commands
{
    /// <summary>
    /// Represents a command that adds a random number to the result.
    /// </summary>
    class RandAddCommand : ICommand
    {
        private int _randomValue;

        /// <summary>
        /// Adds a random number between 1 and 100 to the current result.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after adding the random number.</returns>
        public int Execute(int currentResult)
        {
            _randomValue = new Random().Next(1, 101);
            return currentResult + _randomValue;
        }

        /// <summary>
        /// Reverts the random addition by subtracting the previously added random number.
        /// </summary>
        /// <param name="currentResult">The current result value.</param>
        /// <returns>The result value after undoing the random addition.</returns>
        public int Undo(int currentResult) => currentResult - _randomValue;
    }
}
