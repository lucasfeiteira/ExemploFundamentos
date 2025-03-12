
using ExemploFundamentos.Common.Models;

































// int[] arrayInteiros = new int[4];

//       arrayInteiros[0] = 72;
//       arrayInteiros[1] = 64;
//       arrayInteiros[2] = 50;
//       arrayInteiros[3] = 50;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);



// //Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);

// System.Console.WriteLine("Percorrendo o Array com FOR");

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//       System.Console.WriteLine($"Posicao N {contador} - {arrayInteiros[contador]}");
// }















// System.Console.WriteLine("Percorrendo o Array com FOREACH");

// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//       System.Console.WriteLine($"Posicao N {contadorForeach} - {valor}");
//       contadorForeach++;
// }








// ----------------------------------------------------
//

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Buta";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();






















//------------------------------------------------------
/*
string? opcao;
bool exibirMenu=true;

while (exibirMenu)
{
   Console.Clear();
   Console.WriteLine("Digite a sua opção:");
   Console.WriteLine("1 - Cadastro clinte");
   Console.WriteLine("2 - Buscar cliente");
   Console.WriteLine("3 - Apagar cliente");
   Console.WriteLine("4 - Encerrar ");

   opcao = Console.ReadLine();

   switch (opcao)
   {
      case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
      case "2":
            Console.WriteLine("Buscar de cliente");
            break;
      case "3":
            Console.WriteLine("Apagar cliente");
            break;
      case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;      
      default:
            Console.WriteLine("Opção inválida");
            break;
   }
}


System.Console.WriteLine("O programa se encerrou");


*/


 
//-----------------------------------------
// int soma = 0, numero = 0;

// do
// {
//    System.Console.WriteLine("Digite um número (0 para parar)");
//    numero = Convert.ToInt32(Console.ReadLine());

//    soma += numero;

// } while (numero != 0);

// System.Console.WriteLine($"Total da soma dos números digitados é: {soma}");

















//------------------------------------------------
// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//    System.Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//    contador++;

//    if (contador == 6)
//    {
//       break;
//    }
// }

//--------------------------------------------------------
//  int numero = 5;

//  for (int contador = 0; contador <= 10000; contador++)
//  {
//     System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//  }


//----------------------------------------------------------

//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

//calc.Potencia(3, 3);

// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(9);

// int numeroIncremento = 10;
// System.Console.WriteLine("Incrementando o " + numeroIncremento);
// numeroIncremento++;
// System.Console.WriteLine(numeroIncremento);


// int numeroDecremento = 20;
// System.Console.WriteLine("Decremento o " + numeroDecremento);
// numeroDecremento--;
// System.Console.WriteLine(numeroDecremento);

//--------------------------------------------------------------------

// bool choveu = true;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     System.Console.WriteLine("Vou pedalar um outra dia");
// }


//---------------------------------------------


// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     System.Console.WriteLine("Aprovado!");
// }
// else
// {
//     System.Console.WriteLine("Reprovado!");
// }












//-----------------------------------------------
//  bool ehMaiorDeIdade = false;
//  bool possuiAutorizacaoDoResponsavel = false;

//  if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
//  {
//     System.Console.WriteLine("Entrada liberada!");
//  }
// else 
// {
//     System.Console.WriteLine("Entrada não liberada");
// }



//------------------------------------------------

// System.Console.WriteLine("Digite uma letra:");
// string? letra = System.Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         System.Console.WriteLine("Vogal");
//         break;
//     default:
//         System.Console.WriteLine("Não é uma vogal");
//         break;
// }

//------------------------------------------------
// if (letra == "a" || 
//     letra == "e" ||
//     letra == "i" || 
//     letra == "o" ||
//     letra == "u")
// {
//      System.Console.WriteLine("Vogal");
// }
// else 
// {
//     System.Console.WriteLine("Não é uma vogal");
// }


//--


// if (letra == "a")
// {
//     System.Console.WriteLine("vogal");
// }
// else if (letra == "e")
// {
//     System.Console.WriteLine("vogal");
// }
// else if (letra == "i")
// {
//     System.Console.WriteLine("vogal");   
// }
// else if (letra == "o")
// {
//     System.Console.WriteLine("vogal");   
// }
// else if (letra == "u")
// {
//     System.Console.WriteLine("vogal");   
// }
// else 
// {
//     System.Console.WriteLine("Não é uma vogal");
// }


//---------------------------------------------------------------------------------
// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// System.Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// System.Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// System.Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     System.Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }else
// {
//     Console.WriteLine("Desculpa. Não temos a quantidade desejada em estoque.");
// }

 
//-------------------------------------------------------------------------------------


// string a = "15-";

// //int b = 0;

// int.TryParse(a, out int b);

// System.Console.WriteLine(b);
// System.Console.WriteLine("Consersao realizada com sucesso!");


//----------------------------------------------------------------------------------

// double a = 4 / (2 + 2);

// System.Console.WriteLine(a);

//--------------------------------------------------------
// int a = 5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;


// Console.WriteLine(b);

//---------------------------------------------------


// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// cast - casting
//int a = Convert.ToInt32("5");
//int a = int.Parse("5");


// Console.WriteLine(a);

//------------------------------------------------

// int a = 10;
// int b = 20;

// int c = a + b;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);

//-----------------------------------------------------

// string apresentacao = "ola, seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80m;

// bool condicao = true;


//  Console.WriteLine(apresentacao);
//  Console.WriteLine("Valor da variável quantidade: " + quantidade);
//  Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//  Console.WriteLine("Valor da variável preco: " + preco);
//  Console.WriteLine("Valor da variável condicao: " + condicao);

/* 
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "LucasF";
pessoa1.Idade = 30;
pessoa1.Apresentar(); 

*/