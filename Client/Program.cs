using Grpc.Net.Client;
using System;
using System.Threading.Tasks;
using Server;
using System.Globalization;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ZodiacSign.ZodiacSignClient(channel);
            Console.WriteLine("Please enter your date of birth:");

            while (true) {
                var input = Console.ReadLine();
                if (ValidateInput(input))
                {
                    var reply = await client.GetSignAsync(
                        new ZodiacRequest { DateOfBirth = input });

                    Console.WriteLine(reply.ZodiacSign);
                    break;
                }
                Console.WriteLine("Incorrect format \t Correct format is MM/dd/yyyy");
            }
            Console.ReadKey();

        }

        static bool ValidateInput(string userInput) {
            DateTime dt = new DateTime();
            string format = "MM/dd/yyyy";

            if (DateTime.TryParseExact(userInput, format, 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, out dt)) {

                return true;
            }

            return false;
        } 
    }
}
