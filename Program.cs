namespace AVeryOddString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProcessNumber(Console.ReadLine()));
        }
        public static string ProcessNumber(string input)
        {
        string[] numbers = {"zero","one","two","three","four",
        "five","six","seven","eight","nine","ten",
        "eleven","twelve","thirteen","fourteen","fifteen",
        "sixteen","seventeen","eighteen","nineteen"};
            string[] OddOrEven = {"even","odd","even","odd","even",
        "odd","even","odd","even","odd","even",
        "odd","even","odd","even","odd",
        "even","odd","even","odd"};
            int correct = 0;
            int i = 0;
            while (i < 30)
            {
                if (input.ToLower().Contains(numbers[i]))
                {
                    correct = i; 
                }
                i++;
                
            }
            return OddOrEven[correct];

            
        }
    }
}
