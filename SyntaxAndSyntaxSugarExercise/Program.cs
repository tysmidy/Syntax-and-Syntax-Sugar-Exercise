namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Given the following code, change the code to implement
            //inferred typing
            Console.WriteLine("Enter a number between 1-10");
            var answer = 4;
            var response =(Console.ReadLine());
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }


            //string interpolation
            Console.WriteLine("Enter a number between 1-10");
            var answerTwo = 4;
            var responseTwo = (Console.ReadLine());
            if (answerTwo < 9)
            {
                Console.WriteLine($"{answerTwo} is less than nine");
            }
            else
            {
                Console.WriteLine($"{answerTwo}is greater than or equal to nine");
            }



            //and the ternary operator
            Console.WriteLine("Enter a number between 1-10");
            var responseThree = (Console.ReadLine());
            var answerThree = 4;
            var message = (answerThree < 9) ? $"{answerThree} is less than nine" : $"{answerThree} is greater than or equal to nine";
            Console.WriteLine (message);

        }
    }
}
