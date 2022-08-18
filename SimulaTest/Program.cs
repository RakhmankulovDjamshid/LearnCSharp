
(VarOfFood, MainIngredient, Seasoning) dish = (VarOfFood.Soup, MainIngredient.Carrots, Seasoning.Salty);


AskUserForADish();
Console.WriteLine(dish.Item3+" "+dish.Item2+" "+dish.Item1+" ");

void AskUserForADish()
{
 string answer;
 Console.WriteLine("Hello my dear friend. What dish do you want today?Soup? Stew? Or Gumbo?");
 
 do
 {
  answer = Console.ReadLine();
  if (answer == "Soup" || answer == "soup")
  {
   dish.Item1 = VarOfFood.Soup;
   break;
  }
  else if (answer == "Stew" || answer == "stew")
  {
   dish.Item1 = VarOfFood.Stew;
   break;
   
  }
  else if (answer == "Gumbo" || answer == "gumbo")
  {
   dish.Item1 = VarOfFood.Gumbo;
   break;
  }

   Console.WriteLine("Sorry, But You must pick from these three types of dishes. So, what dish do you want today? Soup? Stew? Or Gumbo? ");
  
 } while (true);

 Console.WriteLine($"Good! It is a {answer}. But what main ingredient do you want?  Mushrooms? Chicken? Carrots? or Potatoes?");
 
 
 do {
  answer = Console.ReadLine();
   
   if (answer == "Mushrooms" || answer == "mushrooms")
   {
    dish.Item2 = MainIngredient.Mushrooms;
    break;
   }
   else if (answer == "Chicken" || answer == "chicken")
   {
    dish.Item2 = MainIngredient.Chicken;
    break;
   }
   else if (answer == "Carrots" || answer == "carrots")
   {
    dish.Item2 = MainIngredient.Carrots;
    break;
   }
   else if (answer == "Potatoes" || answer == "potatoes")
   {
    dish.Item2 = MainIngredient.Potatoes;
    break;
   }

    Console.WriteLine("Sorry, But You must pick from these four main ingredients. So what main ingredient do you want? Mushrooms? Chicken? Carrots? or Potatoes?");
   
   
 } while (true) ;

 Console.WriteLine($"What seasoning do you prefer ?  spicy food? salty or sweet?");
 do
 {
  answer = Console.ReadLine();

  if (answer == "Spicy" || answer == "spicy")
  {
   dish.Item3 = Seasoning.Spicy;
   break;
  }
  else if (answer == "Salty" || answer == "salty")
  {
   dish.Item3 = Seasoning.Salty;
   break;
  }
  else if (answer == "Sweet" || answer == "sweet")
  {
   dish.Item3 = Seasoning.Sweet;
   break;
  }

   Console.WriteLine("Pick from these three options : spicy, salty and sweet");
   
 } while (true);
 
 return;
}

enum VarOfFood
{
 Soup,
 Stew,
 Gumbo
}

enum MainIngredient
{
 Mushrooms,
 Chicken,
 Carrots,
 Potatoes
}

enum Seasoning
{
 Spicy,
 Salty,
 Sweet
}