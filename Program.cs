// Дан массив Q натуральных чисел, содержащий 20 элементов. 
// Найти и вывести те элементы, которые при делении на 7 дают остаток 1,2 или 5

int[] arrQ = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

Console.WriteLine("Zadan 1");

foreach (int q in arrQ)
{
    if (q % 7 == 1 || q % 7 == 2 || q % 7 == 5) {
        Console.WriteLine(q);
    }
    
}

// Написать метод, который вычисляет значения x = sin2(a) и y = cos2(a). 
// Напечатать таблицу значений от –π до π с шагом π/4.

double toDegrees(double degrees){
        return Math.PI * degrees / 180.0;
}  
double toRadians(double angle) {
        return angle * (Math.PI / 180);
}

Console.WriteLine("Zadan 2");

for (int i = 1; i < 180; i = i + 45) {

    double x = Math.Pow(Math.Sin(i), 2);
    double y = Math.Pow(Math.Cos(i), 2);
    Console.WriteLine("{0} \t {1}",x,y);

}


// Дан массив, содержащий 12 элементов. 
// Все четные элементы сложить, вывести массив и результат

Console.WriteLine("Zadan 3");

int[] arrA = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
int[] arrB = new int[] {};

for (int i=0; i < arrA.Length; i+=1)
{
    if (arrA[i] % 2 == 0) {
        arrA[i]*=2;
    }
    
}

Console.WriteLine(String.Join(" ",arrA));
