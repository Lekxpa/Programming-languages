// Напишите функцию, которая принимает одно число - высоту елочки и 
//рисует ее в консоли звездочками

Console.Write("Укажите высоту елочки: ");
int heigth = int.Parse(Console.ReadLine());

int sp = heigth - 1;  // пробелы
    int h = 1;          // количество звездочек
    for (int i = 0; i < heigth; i++)
    {
        for(int m=0; m <= sp; m++)
        {
            Console.Write(" ");
  
        }
        for(int n = 0; n < h; n++)
        {
            Console.Write("*");
        
        }  
    Console.WriteLine();
    sp = sp - 1;
    h = h + 2;
    }
  
  






//int StarH(int haut)
//{
    // int sp = haut - 1;  // пробелы
    //int h = 1;          // количество звездочек
    //for (int i = 0; i <= haut; i++)
   // {
       // for(int m=0; m <= sp; m++)
       // {
       //     Console.Write(" ");
      //      sp = sp - 1;
      //  }
        //return sp;
      //  for(int n = 0; n <= h; n++)
      //  {
       //     Console.Write("*");
      //      h = h + 2;
      //  }  
        //return h;
  //  Console.WriteLine();
  //  }
  
  

//}

//Console.Write("Укажите высоту елочки: ");
//int heigth = int.Parse(Console.ReadLine());
//Console.Write(StarH);
