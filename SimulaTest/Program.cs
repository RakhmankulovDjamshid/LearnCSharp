 
 using SimulaTest;

 ArrowheadType arrowheadType = RequestArrowheadTypeFromUser();
 Fletching fletchingType = RequestFletchingFromUser();
 int lenght = RequestArrowLenghtFromUser();
 Arrow arrow1 = new Arrow(arrowheadType, lenght, fletchingType);
 arrow1.WriteArrowDescription();

 
 
 
 ArrowheadType RequestArrowheadTypeFromUser()
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
 Fletching RequestFletchingFromUser()
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
 int RequestArrowLenghtFromUser()
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