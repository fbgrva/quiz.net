

class Program
{
    static void Main()
    {
        string[] questions = {
            "1. C# dilinde acar sozle teyin olunur?\nA) var\nB) let\nC) const\nD) def",
            "2. C# proqramlarinda esas giris noqtesi hansi metoddur?\nA) start()\nB) run()\nC) Main()\nD) execute()",
            "3. Hansi operator beraberlik yoxlayir?\nA) =\nB) ==\nC) !=\nD) ===",
            "4. C# dilinde massiv nece yaradilir?\nA) int[] arr = new int[5];\nB) array arr = 5;\nC) list arr(5);\nD) int arr = [5];",
            "5. C# 'for' dovru ucun duzgun numunr hansidir?\nA) for(int i=0; i<5; i++)\nB) for i in range(5)\nC) foreach i in 5\nD) loop i 0 to 5"
        };

        char[] correctAnswers = { 'A', 'C', 'B', 'A', 'A' };
        int score = 0;

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine(questions[i]);
            Console.Write("Cavabiniz: ");
            string input = Console.ReadLine().ToUpper();

            if (input.Length > 0 && input[0] == correctAnswers[i])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Duzgun!\n");
                score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Yalnis! Duzgun cavab: {correctAnswers[i]}\n");
            }

            Console.ResetColor();
        }

        Console.WriteLine($"Toplam baliniz: {score} / {questions.Length}");
    }
}
