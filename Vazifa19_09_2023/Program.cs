// See https://aka.ms/new-console-template for more information
using Vazifa19_09_2023.Service;

string s = " 1.Test tuzish \n 2. Testlarni bo`lish\n 3. Chiqish ";
while (true)
{
    Console.WriteLine(s);
    int k = Convert.ToInt32(Console.ReadLine());
    switch (k)
    {
        case 1:
            ConService.NewTest();
            break;
        case 2:
            ConService.Generatsiya();
            break;
        case 3:
            return 0;
            break;

        default: 
            Console.WriteLine("Xato raqam kiritdngiz");
            break;
    }
}
