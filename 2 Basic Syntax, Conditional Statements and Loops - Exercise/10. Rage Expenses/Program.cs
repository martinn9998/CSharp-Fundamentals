using System;

int lostGamesCount = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());
int secondGHedaset = 1, thirdGMouse = 1, trashedHeadset = 0,
    trashedMouse = 0, trashedKeyboard = 0, trashedDisplay = 0,
    countTrashedKeyboard = 0;


for (int i = 1; i <= lostGamesCount; i++, secondGHedaset++, thirdGMouse++)
{
    if (secondGHedaset == 2 && thirdGMouse == 3)
    {
        trashedKeyboard++;
        countTrashedKeyboard++;
        if (trashedKeyboard == 2)
        {
            trashedDisplay++;
            countTrashedKeyboard = 0;
        }
    }
    if (secondGHedaset == 2)
    {
        trashedHeadset++;
        secondGHedaset = 0;

    }

    if (thirdGMouse == 3)
    {
        trashedMouse++;
        thirdGMouse = 0;
    }


}

double headsetCalc = (headsetPrice * trashedHeadset);
double mouseCalc = (mousePrice * trashedMouse);
double keyboardCalc = (keyboardPrice * trashedKeyboard);
double displayCalc = (displayPrice * trashedDisplay);
double priceSum = Math.Floor(headsetCalc + mouseCalc + keyboardCalc + displayCalc);

Console.WriteLine($"Rage expenses: {priceSum:f2} lv.");