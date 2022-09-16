// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Dream Theater!");

#region Snack 1
// L'utente inserisce due numeri in successione. Il software stampa sempre il maggiore.

//Console.WriteLine("Input the first number:");

//string firstNumber = Console.ReadLine();


//Console.WriteLine("Input the second number:");

//string secondNumber = Console.ReadLine();

//if(Convert.ToInt32(firstNumber) > Convert.ToInt32(secondNumber))
//{
//  Console.WriteLine("Il numero maggiore é il primo: " + firstNumber);
//}
//else
//{
//  Console.WriteLine("Il numero maggiore é il secondo: " + secondNumber);
//}

#endregion

//Console.WriteLine();

#region Snack 2
// L'utente inserisce due parole in successione. Il software stampa prima la parola piú corta e poi la parola piú lunga.

//Console.WriteLine("Insert the first word: ");

//string firstWord = Console.ReadLine();

//Console.WriteLine("Insert the second word: ");

//string secondWord = Console.ReadLine();

//if(firstWord.Length > secondWord.Length)
//{
//   Console.WriteLine(secondWord + " " + firstWord);
//}
//else
//{
//  Console.WriteLine(firstWord + " " + secondWord);
//}


#endregion Snack 2

#region Snack 3
// Il software chiede 10 volte all'utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti

//int sum = 0;

//for(int i = 0; i < 10; i++)
//{
//  Console.WriteLine("Inserisci un numero:");

//sum = sum + Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("La somma é: " + sum);

#endregion Snack 3 

#region Snack 4
// Calcola la somma e la media dei numeri da 2 a 10
int mediumNumb = 0;
int sum = 0;
for(int i = 2; i < 10; i++)
{
    sum = sum + Convert.ToInt32(i);
    Console.WriteLine(sum);
    mediumNumb++;
}

Console.WriteLine("La somma dei numeri é " + sum);

float medium = sum / mediumNumb;

Console.WriteLine("La media dei numeri é: " + medium);



#endregion Snack 4