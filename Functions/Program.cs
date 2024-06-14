/* Addition */

/* 
Ecris une fonction qui retourne l’addition de deux nombres entiers.

La fonction s’appelle Add
Elle prend deux arguments de type int
Elle retourne un int
*/

using System.Reflection.Metadata.Ecma335;

int Add (int numberA, int numberB) 
{
    int sum = numberA + numberB;
    return sum;
}

Console.WriteLine("3 + 5 = " + Add(3, 5));


/* Composition */
/*
Plusieurs fonctionnalités

Ecris deux fonctions:
Une qui fait la somme d’un tableau d’entier:
Prend un int[] en paramètre
A un nom correct (est une action et non un état)
Renvoie un int
Une qui affiche les valeurs contenues dans le tableau:
Prend un int[] en paramètre
Ne renvoie aucune donnée (void)
A un nom correct
*/

//List<int> numbers = new List<int>() { 1, 4, 18, 8, -3, 12, 7, 9 };
int[] numbers ={ 1, 4, 18, 8, -3, 12, 7, 9 };

static void Sum(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
        Console.Write(number + " + ");
    }
    Console.WriteLine(" = " + sum);
}

Sum(numbers);


/* Moyenne d’un tableau */
/*
Ecris une fonction qui renvoie la moyenne des nombres décimaux d’un tableau. 
*/
float[] decimalNumbers = {1.34f, 2.45f, 6.345f, 3.456f};

static void Average (float[] decimalNumbers) 
{
    float sum = 0;
    foreach (float decimalNumber in decimalNumbers)
    {
        sum += decimalNumber;
        Console.Write(decimalNumber + " + ");
    }

    float average = sum / (float)(decimalNumbers.Length);
    Console.WriteLine(" = " + average);
}

Average(decimalNumbers);


/* Refactorisation */
/*
Imaginez une fonction DisplayArrayOperations qui est trop complexe. Elle réalise trois choses :
Afficher chaque nombre entier du tableau
Affiche la somme des nombres entiers du tableau
Affiche la moyenne des nombres entiers du tableau

Sépare les fonctionnalités de cette fonction (une par fonction). Le but est de réduire la complexité apparente du code en petites fonctions.

Il faut que le code fasse exactement la même chose que dans sa version originelle.

(Fais bien précéder tes signatures de fonctions du mot-clé static)
*/


static void DisplayArrayElements (int[] numbers) 
{
    Console.WriteLine("Array: ");
    foreach (int number in numbers) 
    {
        Console.Write(number + " ");
    }
    Console.WriteLine("");
}

static void AverageIntegers (int[] numbers) 
{
    int sum = 0;

    Console.WriteLine("Average: ");
    
    foreach (int number in numbers)
    {
        sum += number; // add a number to the sum
        Console.Write(number + " + ");
    }

    int average = sum / numbers.Length; // calculate the average, divising by the length
    Console.WriteLine(" / " + numbers.Length + " = " + average);
}

static void DisplayArrayOperations (int[] numbers) 
{
    DisplayArrayElements(numbers);
    Sum(numbers);
    AverageIntegers(numbers);

}

Console.WriteLine("DisplayArrayOperations");
DisplayArrayOperations(numbers);