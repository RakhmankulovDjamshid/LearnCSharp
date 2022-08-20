
using System.Runtime.CompilerServices;

namespace SimulaTest;

public class Arrow
{
    private int _lenght;
    private ArrowheadType _arrowheadType;
    private Fletching _fletching;

    public int Lenght
    {
        get => _lenght;
        set
        {
            if (value >= 60 && value <= 100)
            {
                _lenght = value;
            }

        }
    }

    public ArrowheadType ArrowheadType
    {
        get => _arrowheadType;
        set => _arrowheadType = value;
    }

    public Fletching Fletching
    {
        get => _fletching;
        set => _fletching = value;
    }
   
    
    
    public Arrow(ArrowheadType arrowheadType, int lenght , Fletching fletching)
    {
        _arrowheadType = arrowheadType;
        _lenght = lenght;
        _fletching = fletching;
    }

// Метод для вывода в консоль всех значений стрелы
    public void WriteArrowDescription()
    {
        double arrowCost = ArrowCost();
        Console.WriteLine($" The arrow has {_arrowheadType} arrowhead. Arrow is {_lenght} cm lenght and has a {_fletching} fletching. " +
                          $"Such arrow costs about {arrowCost} golds");
    }

    private double ArrowCost()
    {
        double arrowheadCost = 10.0;
        double fletchingCost = 10.0;
        double arrowLenghtCost = _lenght * 0.05;

        if (_arrowheadType == ArrowheadType.Steal)
        {
            arrowheadCost = 10.0;
        }
        else if (_arrowheadType == ArrowheadType.Wood)
        {
            arrowheadCost = 3.0;
        }
        else if(_arrowheadType == ArrowheadType.Obsidian)
        {
            arrowheadCost = 5.0;
        }

        if (_fletching == Fletching.Plastic)
        {
            fletchingCost = 10.0;
        }
        else if (_fletching == Fletching.TurkeyFeathers)
        {
            fletchingCost = 5.0;
        }
        else if (_fletching == Fletching.GooseFeatsers)
        {
            fletchingCost = 3.0;
        }

        return arrowheadCost + fletchingCost + arrowLenghtCost;

    }
    
}

public enum ArrowheadType
{
    Steal,
    Wood,
    Obsidian
}

public enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeatsers
}
