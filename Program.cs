// *************** Desafio Logica *****************

double resultado = 0;
int continuar=1;

while (continuar==1){
    Console.WriteLine("Digite a quantidade de notas a ser calculada: ");
    int qtdNotas=Convert.ToInt32(Console.ReadLine());
    if (qtdNotas>0){
        double soma = 0;
        for(int cont=1; cont<=qtdNotas; cont++){
            Console.WriteLine("Digite a " + cont+ "º nota: ");
            soma =  Convert.ToDouble(Console.ReadLine().Replace(".",",")) + soma;
        }
        resultado = soma/qtdNotas;
        string aux = resultado.ToString("N2");
        Console.WriteLine("A média das avaliações é: "+aux);
        if (resultado>=6){
            Console.WriteLine("Situação: Aprovado");
        }
        else{
            Console.WriteLine("Situação: Reprovado");
        }
    }
    else{
        Console.WriteLine("Quantidade de avaliações inválida.");
    }
    Console.WriteLine("Deseja calcular outra média?");
    Console.WriteLine("Digite 1 para SIM");
    continuar = int.Parse(Console.ReadLine());
}

Console.WriteLine("Fim do programa!");
