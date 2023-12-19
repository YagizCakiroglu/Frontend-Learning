int ay = 5;

switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Mevsimi");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar Mevsimi");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz Mevsimi");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar Mevsimi");
        break;
    default:
        Console.WriteLine("Yanlış Bilgi.");
        break;
}