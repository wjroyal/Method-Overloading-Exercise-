namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

           var answer =  Methods.Add(2, 2, true);
            Console.WriteLine(answer);

            var answer2 = Methods.Add(0, 1, false);
            Console.WriteLine(answer2);

            var answer3 = Methods.Add(10, 10, true);
            Console.WriteLine(answer3);

            var answer4 = Methods.Add(1, 0, true);
            Console.WriteLine(answer4);

            var answer5 = Methods.Add(5.00, 1.00);
            Console.WriteLine(answer5);

            var answer6 = Methods.Add(6.543m, 5.247m);
            Console.WriteLine(answer6);


        }


    }
}
