using System;
using YourNamespace.Models;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var gasContainer = new GasContainer(120, 240, "KON-G-001", 1500, 5000, 100.0);
                gasContainer.LoadCargo(4500); 
                gasContainer.UnloadCargo(); 
                Console.WriteLine("Operations completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}