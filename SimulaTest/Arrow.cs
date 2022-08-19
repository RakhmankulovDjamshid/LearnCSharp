
using System.Security.Cryptography.X509Certificates;

namespace SimulaTest;

public class Arrow
{
    private int _lenght;
    private ArrowheadType _arrowheadType;
    private Fletching _fletching;

    public Arrow(string arrowHead, int lenght, string fletching)
    {
        do
        {
            if (arrowHead == "steel")
            {
                _arrowheadType = ArrowheadType.Steal;
                break;
            }
            else if (arrowHead == "wood")
            {
                _arrowheadType = ArrowheadType.Wood;
                break;
            }
            else if (arrowHead == "obsidian")
            {
                _arrowheadType = ArrowheadType.Obsidian;
                break;
            }
        } while (true);

        do
        {
            if (lenght <= 100 || lenght >= 60)
            {
                _lenght = lenght;
                break;
            }
        } while (true);

        do
        {
            if (fletching == "plastic")
            {
                _fletching = Fletching.Plastic;
                break;
            }
            else if (fletching == "turkey feathers")
            {
                _fletching = Fletching.TurkeyFeathers;
                break;
            }
            else if (fletching == "goose feathers")
            {
                _fletching = Fletching.GooseFeatsers;
                break;
            }
        } while (true);
        
        
        
    }


    public void WriteArrowDescription()
    {
        Console.WriteLine($"{_arrowheadType} {_lenght} {_fletching}");
    }

}

enum ArrowheadType
{
    Steal,
    Wood,
    Obsidian
}

enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeatsers
}
