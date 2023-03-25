int [] arrayi1 = new int [20];
int [] arrayj1 = new int [20];
int [] arrayi2 = new int [20];
int [] arrayj2 = new int [20];
//int k = 0;
var rng = new Random();
for (int m = 0; m < 3; m++)
{
    var validValues_i1 = Enumerable.Range(3, 3).Except(arrayi1).ToArray();
    int i1 = validValues_i1[rng.Next(0, validValues_i1.Length)];
    arrayi1[m] = i1;
    var validValues_j2 = Enumerable.Range(0,4).Except(arrayj2).ToArray();
    int j2 = (validValues_j2[rng.Next(0, (validValues_j2.Length))]);
    j2--;
    Console.WriteLine(" j2: " + j2);
    arrayj2[m] = j2;
    for (int n = 0; n < 3; n++)
        {
        Console.Write(" m: " + m);
        Console.Write(" n: " + n);
        //k++;
        var validValues_j1 = Enumerable.Range(3, 3).Except(arrayj1).ToArray();

            int j1 = validValues_j1[rng.Next(0, validValues_j1.Length)];

            Console.Write("  ///   i1: " + i1);
            Console.Write("   j1: " + j1);
            Console.Write("   j2: " + j2);
            Console.WriteLine();
            arrayj1[n] = j1;
        }
    Array.Clear(arrayj1, 0, arrayj1.Length);
}



/*
int [] arrayi = new int [5];
int k = 0;
var rng = new Random();

for (int n = 0; n < 4; n++) // проверка последовательного исключения элементов
    {
    arrayi[n] = k;
    Console.Write("k: " + k);   // исключенный элемент
    k++;
    Console.WriteLine();
    var validValues = Enumerable.Range(0, 5).Except(arrayi).ToArray();
    for (int i = 0; i < 10; i++)
        {
        Console.Write(validValues[rng.Next(0, validValues.Length)]);
        Console.Write(" ");
        }
    Console.WriteLine();
    }
*/