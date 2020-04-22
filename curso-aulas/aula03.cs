using System;

class aula03{
    static void Main(){
        byte n1 = 10; // entre 0 e 255
        int num1, num2, res;
        char letra = 'c'; // somente com apostrofo ' ' e só armazena 1 caractere
        float valor = 5.3f;
        string nome = "Gustavo"; // usar aspas duplas " "
        var aux = nome; // não determina o tipo, o tipo é definido de acordo com o valor atribuido a ela

        num1 = 10;
        num2 = 2;
        res = num1 * num2;
        Console.WriteLine("Nome: " + aux);
        Console.WriteLine("A multiplicação entre " + num1 + " e " + num2 + " é igual a: " + res);
    }
}