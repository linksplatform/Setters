using System;
using Platform.Setters;

namespace Platform.Setters.Experiments
{
    /// <summary>
    /// Demo showing the usage of Setter with single constant as requested in issue #7.
    /// This addresses the case where "in real life usage only one constant is actually used".
    /// </summary>
    class SingleConstantSetterDemo
    {
        static void Main()
        {
            // Example usage as requested in the issue: 
            // "var setter = new Setter<uint, uint>(links.Constants.Break);"
            
            // Before: Required specifying both true/false values
            Console.WriteLine("=== Before (traditional approach) ===");
            var traditionalSetter = new Setter<uint, uint>(1, 0); // trueValue=1, falseValue=0
            Console.WriteLine($"TrueValue: {traditionalSetter.TrueValue}, FalseValue: {traditionalSetter.FalseValue}");
            
            // After: Can use single constant for both true/false cases
            Console.WriteLine("\n=== After (single constant approach) ===");
            uint constantBreak = 42; // Simulating links.Constants.Break
            var singleConstantSetter = Setter<uint, uint>.WithConstant(constantBreak);
            Console.WriteLine($"TrueValue: {singleConstantSetter.TrueValue}, FalseValue: {singleConstantSetter.FalseValue}");
            
            // Both methods return the same constant value
            Console.WriteLine("\n=== Testing functionality ===");
            Console.WriteLine($"SetAndReturnTrue result: {singleConstantSetter.SetAndReturnTrue(100)}"); // Should return 42
            Console.WriteLine($"SetAndReturnFalse result: {singleConstantSetter.SetAndReturnFalse(200)}"); // Should return 42
            Console.WriteLine($"Final result value: {singleConstantSetter.Result}"); // Should be 200
            
            // Can also specify default value
            Console.WriteLine("\n=== With default value ===");
            var setterWithDefault = Setter<uint, uint>.WithConstant(constantBreak, 999);
            Console.WriteLine($"TrueValue: {setterWithDefault.TrueValue}, FalseValue: {setterWithDefault.FalseValue}");
            Console.WriteLine($"Initial result: {setterWithDefault.Result}"); // Should be 999
        }
    }
}