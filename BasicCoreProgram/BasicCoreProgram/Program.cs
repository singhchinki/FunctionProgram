// See https://aka.ms/new-console-template for more information
Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.PowerOf2\n4.HarmonicNum\n5.Factor\n6.QuotientRemander\n7.SwapTwoNum\n8.EvenOdd\n9.VowelConsonant\n10.AmongThreeNumber");
Console.WriteLine("Enter your Choice:");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        BasicCoreProgram.FlipCoin function = new BasicCoreProgram.FlipCoin();
        function.flipCoin();
        break;
    case 2:
        BasicCoreProgram.LeapYear year = new BasicCoreProgram.LeapYear();
        year.leapYear();
        break;
    case 3:
        BasicCoreProgram.PowerOf2 power = new BasicCoreProgram.PowerOf2();
        power.PowerOf();
        break;
    case 4:
        BasicCoreProgram.HarmonicNum harmonic = new BasicCoreProgram.HarmonicNum();
        harmonic.harmonic();
        break;
    case 5:
        BasicCoreProgram.Factor prime = new BasicCoreProgram.Factor();
        prime.factor();
        break;
    case 6:
        BasicCoreProgram.QuotientRemander cal = new BasicCoreProgram.QuotientRemander();
        cal.divide();
        break;
    case 7:
        BasicCoreProgram.SwapTwoNum swap = new BasicCoreProgram.SwapTwoNum();
        swap.change();
        break;
    case 8:
        BasicCoreProgram.EvenOdd eo = new BasicCoreProgram.EvenOdd();
        eo.computation();
        break;
    case 9:
        BasicCoreProgram.VowelConsonant alphabet = new BasicCoreProgram.VowelConsonant();
        alphabet.Vowel();
        break;
    case 10:
        BasicCoreProgram.AmongThreeNumber largest = new BasicCoreProgram.AmongThreeNumber();
        largest.large();
        break;
    default:
        Console.WriteLine("Enter valid option");
        break;
}

