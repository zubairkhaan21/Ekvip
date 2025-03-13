using Ekvip.Commands;
using Ekvip.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        int result;
        Console.Write("Enter the initial value: ");
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the initial value: ");
        }

        // Stack to keep track of previous results for undo functionality
        Stack<int> history = new Stack<int>();
        history.Push(result); // Initialize with the initial value

        // Dictionary to map command names to command objects
        Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>
        {
            { "increment", new IncrementCommand() },
            { "decrement", new DecrementCommand() },
            { "double", new DoubleCommand() },
            { "randadd", new RandAddCommand() },
            { "undo", new UndoCommand(history) }
        };

        while (true)
        {
            Console.WriteLine($"Current result: {result}");
            Console.Write("Enter command (increment, decrement, double, randadd, undo): ");
            string command = Console.ReadLine()!.ToLower().Trim();

            if (commands.TryGetValue(command, out var cmd))
            {
                try
                {
                    // Execute the command and update the result
                    int newResult = cmd.Execute(result);
                    if (command != "undo") // Don't add undo to history
                    {
                        history.Push(newResult);
                    }
                    result = newResult;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Try again.");
            }
        }
    }
}