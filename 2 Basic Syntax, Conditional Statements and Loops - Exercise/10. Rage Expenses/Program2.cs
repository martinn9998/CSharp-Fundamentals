namespace RageExpenses
{
    class Program
    {
        public static void Main()
        {
            var lostGamesCount = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());
            var crashedHeadsetCount = 0;
            var crashedMouseCount = 0; var crashedKeyboardCount = 0;
            var crashedDisplayCount = 0;
            for (var i = 1; i <= lostGamesCount; i++)
            {

                int crashedTheSame = 0;
                if (i%2==0)
                {
                    crashedHeadsetCount++;
                }
                if (i%3==0)
                {
                    crashedMouseCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    crashedTheSame++;
                }
                if (crashedTheSame == 1)
                {
                    crashedKeyboardCount++;
                    if (crashedKeyboardCount > 0 && crashedKeyboardCount % 2 == 0)
                    {
                        crashedDisplayCount++;
                    }
                }
            }
            var calcHeadset = headsetPrice * crashedHeadsetCount;
            var calcMouse = mousePrice * crashedMouseCount;
            var calcKeyboard = keyboardPrice * crashedKeyboardCount;
            var calcDisplay = displayPrice * crashedDisplayCount;
            var rageExpenses = calcHeadset + calcMouse + calcKeyboard + calcDisplay;
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}