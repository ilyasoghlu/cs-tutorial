//// if else operator 
//Console.WriteLine("Please enter your age");
//int age = int.Parse(Console.ReadLine());//integer string kimi qeyd etmək üçün Parse etməyi unutma 

//Console.WriteLine("Please enter your height");
//double height = double.Parse(Console.ReadLine());

//Console.WriteLine("Please enter your weight");
//double weight = double.Parse(Console.ReadLine());

//double bodyMassIndex = weight / (height * height);
//Console.WriteLine($"Your Body Mass Index is {bodyMassIndex}");


//bool isLow = bodyMassIndex <= 18.5;
//bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
//bool isAboveNormal = bodyMassIndex > 25 && bodyMassIndex <= 30;
//bool isFat = bodyMassIndex > 30;

//if (isLow)
//{
//    Console.WriteLine("You'd better get some weight");
//}
//else if (isNormal)
//{
//    Console.WriteLine("Oh, you are in a good shape");
//}
//else if (isAboveNormal)
//{
//    Console.WriteLine("You got a few more");
//}
//else
//{
//    Console.WriteLine("Bro you must lose some kilograms");
//}

//Console.ReadLine();


//Console.WriteLine("Please enter 2 number");
//double a = double.Parse(Console.ReadLine());
//double b = double.Parse(Console.ReadLine());

//if (a == b)
//{
//    Console.WriteLine("Your numbers are equal");
//}
//else if (a > b)
//{
//    Console.WriteLine($"{a} bigger than {b}");
//}
//else
//{
//    Console.WriteLine($"{b} bigger than {a}");

//}

// loops - for 

/* Loop yaradarkən dəyərin default ifadə edilməsi üçün i yazılır və başlanğıc qəbul edilir, məlumat artan sıra ilə davam etdikdə j, k... ardıcıllıq belə təmin edilir 
 * increment, discrement, reversed increment və s əməliyyatlar etmək də mümkündür  
*/
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//for (int i = 0; i < numbers.Length; i++) 
//{
//    Console.WriteLine(numbers[i] + " ");
//}

//Matroshka
int[] numbers = { 1, -2, 4, -7, 5, 3, 2, 7, -1, -3, 1, 7 };
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        int atI = numbers[i];
        int atJ = numbers[j];
        {
            if (atI + atJ == 0)
            {
                Console.WriteLine($"Pair ({atI};{atJ}). Indexes({i};{j})");
            }
        }
    }
}


// Result for matroshka 

//Pair(1; -1). Indexes(0; 8)
//Pair(-2; 2). Indexes(1; 6)
//Pair(-7; 7). Indexes(3; 7)
//Pair(-7; 7). Indexes(3; 11)
//Pair(3; -3). Indexes(5; 9)
//Pair(-1; 1). Indexes(8; 10)


// loops - foreach
/* Qeyd: foreach reverse etmək olmaz 
 * bizə hər zaman iterator lazım deyil (iterator -- i) və əgər bizə index-li müraciət lazım deyilsə o zaman foreach ilə işləmək daha məsləhətlidir,
 * aşağıdakə misalda iterator əvəzinə qeyd edilmiş val sadəcə adlandırmadır başqa sözlə də ifadə etmək mümkündür 
*/

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//foreach (int val in numbers)
//{
//    Console.WriteLine(val + " ");
//}



/*
 * Loops - While 
 * Bu tip looplar tam olaraq lazım olan cavadı alana kimi davam edir, məsələn deyək ki, bizə lazımdır şəxsin 18 yaşı varsa ancaq o zaman doğru cavab verilsin o zaman,
 * loop 18 yaş-da aşağı cavabların hamısında prosesi yenidən başladacaq 
 */

//int age = 0;
//while (age < 18)
//{
//    Console.WriteLine("What is your age");
//    age = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("good!");


/*
 * loops - do while 4 dərs 45 dəq 
 * yehuiuuu
 */

Console.WriteLine();

Console.WriteLine("Please click enter to exit...");
Console.ReadLine();

