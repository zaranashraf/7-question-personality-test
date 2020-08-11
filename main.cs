using System;

class MainClass {
  public static void Main (string[] args) 
  {
    string ops;
    do


   { Console.WriteLine ("******************************");
    Console.WriteLine ("Welcome to your personality game");
    Console.WriteLine ("*******************************");
    Console.WriteLine ("count your points its important");
    Console.WriteLine ("********************************");

   Console.WriteLine("Q1:if someone slap you what you do");
   Console.WriteLine("__________________________________");
   Console.WriteLine(" A : ignore him ");
   Console.WriteLine(" B : slap him  ");
   Console.WriteLine(" C : fight with him");
   Console.WriteLine("-------------------");
   Console.WriteLine("write the option in capital form :");
   ops = Console.ReadLine();

   if ( ops == "A" )
   {
     Console.WriteLine("you really a humble person");
     Console.WriteLine(" POINTS :- you get 50 point");
   }
   else if ( ops == "B")
   {
     Console.WriteLine("ooh good revenge is revenge");
     Console.WriteLine(" POINTS :- you get 20 point");
   }
   else if (ops == "C")
   {
     Console.WriteLine("you really an a angry person");
     Console.WriteLine (" POINTS :- you get -5 points");
   }

   Console.WriteLine("___________________________");
   Console.WriteLine("Q2:who is your role model ?");
   Console.WriteLine("___________________________");
   Console.WriteLine(" A : your parents");
   Console.WriteLine(" B : your favourite celebrity");
   Console.WriteLine(" C : or someone else ");
   Console.WriteLine("------------------------------");
   Console.WriteLine("write the option in capital form :");
   ops = Console.ReadLine();

   if (ops == "A")
   {
     Console.WriteLine("thats soo sweet of you very good");
     Console.WriteLine(" POINTS :-  you get 50 points");
   }
   else if ( ops == "B")
   {
     Console.WriteLine("nice make yourself a star");
     Console.WriteLine(" POINTS :- you get 20 points");
   }
   else if ( ops == "C")
   {
     Console.WriteLine(" ohh! you can tell me dont worry");
     Console.WriteLine(" POINTS :- you get 25 points ");
   }

   Console.WriteLine("__________________________________");
   Console.WriteLine("Q3:if you have a power what you do");
   Console.WriteLine("__________________________________");
   Console.WriteLine(" A : give food to poor people ");
   Console.WriteLine(" B : take free gaming pc everyday");
   Console.WriteLine(" C : buy every mansion and cars");
   Console.WriteLine("--------------------------------");
   Console.WriteLine("write the option in capital form :");
   ops = Console.ReadLine();

   if ( ops == "A" )
   {
     Console.WriteLine("your future is so bright ");
     Console.WriteLine("POINTS :- you get 50 points");
   }
   else if ( ops == "B")
   {
     Console.WriteLine("invite me also i like gaming ");
     Console.WriteLine(" POINTS :- you get 15 points");
   }
   else if (  ops == "C")
   {
     Console.WriteLine("can you give me any one car plz");
     Console.WriteLine("POINTS :- you get 10 points " );
   }

   Console.WriteLine("________________________________");
   Console.WriteLine("Q4:what you do in your free time");
   Console.WriteLine("________________________________");
   Console.WriteLine(" A : reading books");
   Console.WriteLine(" B : playing games");
   Console.WriteLine(" C : sleeping ");
   Console.WriteLine("--------------------");
   Console.WriteLine("write the option in capital form :");
   ops = Console.ReadLine();

   if ( ops == "A")
   {
     Console.WriteLine("well well good keep going");
     Console.WriteLine("POINTS :- you get 40 points");
   }
   else if ( ops == "B")
   {
     Console.WriteLine("what games do you play gtav ?");
     Console.WriteLine("POINTS :- you get 50 points");
   }
   else if ( ops == "C")
   {
     Console.WriteLine("zzzzzzzzzzzz sweet dreams ");
     Console.WriteLine("POINTS :- you get 30 points");
   }

   Console.WriteLine("_________________________________");
   Console.WriteLine("Q5:how you deal with your enemies");
   Console.WriteLine("_________________________________");
   Console.WriteLine(" A : very rude ");
   Console.WriteLine(" B : dont talk");
   Console.WriteLine(" C : polite " );
   Console.WriteLine("----------------");
   Console.WriteLine("write the option in capital form :");
   ops = Console.ReadLine();

   if (ops == "A")
   {
     Console.WriteLine("they deserve it");
     Console.WriteLine("POINTS :- you get 30 points");
   }
   else if ( ops == "B")
   {
     Console.WriteLine("yeah best way to ignore");
     Console.WriteLine("POINTS :- you get 50 points");
   }
   else if ( ops == "C")
   {
     Console.WriteLine("you heart is very clean");
     Console.WriteLine("POINTS :- you get 40 points");
   }

   Console.WriteLine("______________________________");
   Console.WriteLine("Q6: what is your aim in life ?");
   Console.WriteLine("______________________________");
   Console.WriteLine(" A : become a doctor  ");
   Console.WriteLine(" B : not planned yet  ");
   Console.WriteLine(" C : other profession ");
   Console.WriteLine("-----------------------");
   Console.WriteLine("write the option in capital form :");
   ops = Console.ReadLine();
    
   if ( ops == "A")
   {
     Console.WriteLine("treat me first for free :-)");
     Console.WriteLine("POINTS :- you get 40 points ");
   }
   else if ( ops == "B")
   {
     Console.WriteLine("planned right now cmon!");
     Console.WriteLine("POINTS :- you get -10 points");
   }
   else if ( ops == "C")
   {
     Console.WriteLine(" secrets hard work and achieve ");
     Console.WriteLine("POINTS :- you get 30 points ");
   }
   Console.WriteLine("------------------------------");
   Console.WriteLine("Q7: what would important to you");
   Console.WriteLine("-------------------------------");
   Console.WriteLine(" A : money ");
   Console.WriteLine(" B : respect");
   Console.WriteLine(" C : family ");
   Console.WriteLine("write the answer in capital form :");
   ops = Console.ReadLine();

   if (ops == "A")
   {
     Console.WriteLine("modern world require modern sol");
     Console.WriteLine(" POINTS :- you get 10 points ");
   }
   else if ( ops == "B")
   {
     Console.WriteLine("yeah thats important");
     Console.WriteLine(" POINTS :- you get 30 points");
   }
   else if (ops == "C") 
   {
     Console.WriteLine("you really a nice person");
     Console.WriteLine(" POINTS :- you get 50 points");
   }

   Console.WriteLine(".........................");
   Console.Write("how much number did you get = ");
   double num1 = Convert.ToDouble(Console.ReadLine());
  
   if ( num1 < 50)
   {
     Console.WriteLine("****************************");
     Console.WriteLine("your personality is very bad ");
     Console.WriteLine("****************************");
   }
   else if ( num1 < 100 )
   {
     Console.WriteLine("********************************");
     Console.WriteLine("your personality is not soo good");
     Console.WriteLine("********************************");
   }
   else if ( num1 < 210 )
   {
     Console.WriteLine("****************************");
     Console.WriteLine("your personality is average ");
     Console.WriteLine("****************************");
   }
   else if ( num1 < 250 )
   {
     Console.WriteLine("****************************");
     Console.WriteLine(" your personality is good ");
     Console.WriteLine("**************************");
   }
   else if (num1 < 300 )
   {
     Console.WriteLine("****************************");
     Console.WriteLine("your personality is very well");
     Console.WriteLine("*****************************");
   }
   else if ( num1 < 350 )
   {
     Console.WriteLine("********************************");
     Console.WriteLine("your personality is mind blowing");
     Console.WriteLine("********************************");
   }
   else if ( num1 < 360 )
   {
     Console.WriteLine("*******************************");
     Console.WriteLine("wait what try again no cheating");
     Console.WriteLine("*******************************");
   }

   Console.WriteLine("Do you want to restart the test ?");
   ops = Console.ReadLine();
   }
   while ( ops == "yes");
   Console.WriteLine(" ok thank you see ya :-)");
   Console.WriteLine("////////////////////////");
   Console.WriteLine("develop by zaran ashraf ");
   Console.WriteLine("////////////////////////");
  
  
    
   

   


   
   

  }
}