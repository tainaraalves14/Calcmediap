char resp = ' ';
while (resp != 'N')
{
    Console.Clear();
    Console.WriteLine("Entre em com a nota da Prova 1 (P1): ");
    float notap1=float.Parse(Console.ReadLine());

    Console.WriteLine("Entre em com a o peso da Prova 1 (P1):");
    float pesop1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Entre em com a nota da Prova 2 (PROJETO): ");
    float notap2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Entre em com o peso da Prova 2 (PROJETO): ");
    float pesop2 = float.Parse(Console.ReadLine());

    Console.WriteLine("Entre em com a nota de Quiz: ");
    float notaquiz = float.Parse(Console.ReadLine());

    Console.WriteLine("Entre em com o peso do quiz:");
    float pesoquiz = float.Parse(Console.ReadLine());


    float media = ((notap1 * pesop1) + (notap2 * pesop2) + (notaquiz * pesoquiz)) / (pesop1 + pesop2 + pesoquiz);

    Console.WriteLine(String.Format("A média final é {0:f2}"));



}