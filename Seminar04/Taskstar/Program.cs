// Напишите функцию, которая принимает одно число - высоту елочки и 
//рисует ее в консоли звездочками


// Семён, посмотрите, пожалуйста, оставила 2 варианта, оба елочку рисуют:)
// но, если я правильно поняла, по усовиям задачи нужен первый вариант
// второй закоммментировала, иначе ничего не работает


int StarH(int haut)
{
    int sp = haut;  // пробелы
    int h = 1;          // количество звездочек
    for(int i = 0; i < haut; i++)
    {
        for(int m=0; m < sp; m++)
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
    return h;
}

Console.Write("Укажите высоту елочки: ");
int heigth = int.Parse(Console.ReadLine());

int star = StarH(heigth);


//Console.Write("Укажите высоту елочки: ");
//int heigth = int.Parse(Console.ReadLine());

//int sp = heigth;  // пробелы
//int h = 1;          // количество звездочек
    //for (int i = 0; i < heigth; i++)
    //{
        //for(int m=0; m < sp; m++)
        //{
            //Console.Write(" ");
  
        //}
        //for(int n = 0; n < h; n++)
        //{
            //Console.Write("*");
       // }  
    //Console.WriteLine();
    //sp = sp - 1;
    //h = h + 2;
    //}
  