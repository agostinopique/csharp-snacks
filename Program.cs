// See https://aka.ms/new-console-template for more information
using System;

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

// Alternativa 
 Console.WriteLine("Input the first number:");

//int firstNumber = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("Input the second number:");

//int secondNumber = Convert.ToInt32(Console.ReadLine());

//int maggiore = firstNumber > secondNumber ? firstNumber : secondNumber;

//Console.WriteLine("Il numero maggiore é: " + maggiore);
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

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Inserisci un numero:");

//    sum = sum + Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("La somma é: " + sum);

#endregion Snack 3 

#region Snack 4
// Calcola la somma e la media dei numeri da 2 a 10
//int mediumNumb = 0;
//int sum = 0;
//for (int i = 2; i < 11; i++)
//{
//    sum = sum + Convert.ToInt32(i);
//    Console.WriteLine(sum);
//    mediumNumb++;
//}

//Console.WriteLine("La somma dei numeri é " + sum);

//float medium = (float)sum / mediumNumb;

//Console.WriteLine("La media dei numeri é: " + medium);



#endregion Snack 4

#region Snack 5
// Il software chiede di inserire un numero. Se il numero inserito é pari, stampa il numero, se é dispari, stampa il numero successivo
//Console.WriteLine("Inserisci un numero: ");

//int userValue = Convert.ToInt16(Console.ReadLine()); 

//if(userValue % 2 == 0)
//{
//   Console.WriteLine("Il numero é pari: " + userValue);
//}
//else
//{
//   Console.WriteLine("Il numero é dispari: " + (userValue + 1));
//}

#endregion Snack 5

#region Snack 6
// In un array sono contenuti gli invitati alla festa del grande gatsby. Chiedi all'utente il suo nome e digli se puó partecipare alla festa o no.

//string[] guests = { "Manuel", "Silvia", "Sebastiano", "Luca", "Stefano", "Paolo", "Davide", "Gabriele" };

//Console.WriteLine("Inserisci il tuo nome per vedere se sei nella lista");

//string userName = Console.ReadLine();


//bool present = false;

//for (int i = 0; i < guests.Length; i++)
//{
//    if (guests[i].ToLower() == userName.ToLower())
//    {
//        Console.WriteLine("Sei nella lista! Goditi la festa! :D");
//        present = true;
//        break;
//    }

//}

//if (!present)
//{
//    Console.WriteLine("Non sei presente nella lista!");
//}
#endregion Snack 6

#region Snack 7 
// Crea un array vuoto.
// Chiedi 6 volte all'utente di inserire un numero: se il numero é dispari inseriscilo nell'array.

//int[] numbers = new int[6];
//int k = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine("Insert a number: ");

//    int userNumber = Convert.ToInt32(Console.ReadLine());

//    if (userNumber % 2 == 0)
//    {ole.WriteLine(numbers);
//        //Console.WriteLine("É pari!");
//    }
//    else
//    {
//        //Console.WriteLine("É dispari!");
//        numbers[k] = userNumber;
//        k++;
//    }
//}

////Cons

//Console.WriteLine();
//Console.WriteLine("Array");

//foreach (var item in numbers)
//{
//    if (item != 0)
//    {

//        Console.WriteLine(item);

//    }
//}

//// ALTERNATIVA DI STAMPA
//for( int i = 0; i < numbers.Length; i++)
//{

//        if(numbers[i] == 0)
//        {
//            break;
//        }
//        else
//        {
//            Console.Write(numbers[i] + " ");
//        }

//}
#endregion Snack 7

#region Snack 8


#endregion Snack 8