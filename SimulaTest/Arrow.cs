
namespace SimulaTest;

public class Arrow
{
    private int _lenght;
    private ArrowheadType _arrowheadType;
    private Fletching _fletching;
    

    private ArrowheadType ArrowheadTypeIs()
    {
        string arrowHead;
        do
        {
            Console.WriteLine("What is type an arrowhead? Steel, Wood, Obsidian");
            arrowHead = Console.ReadLine();
            if (arrowHead == "steel")
            {
                return ArrowheadType.Steal;
                
            }
            else if (arrowHead == "wood")
            {
                return ArrowheadType.Wood;
               
            }
            else if (arrowHead == "obsidian")
            {
                return ArrowheadType.Obsidian;
                
            }
        } while (true);

        return ArrowheadType.Obsidian;
    }

    private Fletching FletchingIs()
    {
        string fletching;
        do
        {
            Console.WriteLine("What is type of fletching? Plastic, Turkey feathers, Goose feathers");
            fletching = Console.ReadLine();
            if (fletching == "plastic")
            {
                return SimulaTest.Fletching.Plastic;
               
            }
            else if (fletching == "turkey feathers")
            {
                return SimulaTest.Fletching.TurkeyFeathers;
               
            }
            else if (fletching == "goose feathers")
            {
                return SimulaTest.Fletching.GooseFeatsers;
                
            }
        } while (true);

        return SimulaTest.Fletching.Plastic;
    }

    private int Lenght()
    {
        int lenght;
        do
        {
            Console.WriteLine("What is lenght of arrow? It must be between 100 and 60 cm");
            lenght = Convert.ToInt32(Console.ReadLine());
            if (lenght <= 100 && lenght >= 60)
            {
                return lenght;
            }
            
        } while (true);

        return lenght;
    }
    
    public Arrow()
    {
        _arrowheadType = ArrowheadTypeIs();
        _fletching = FletchingIs();
        _lenght = Lenght();
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
