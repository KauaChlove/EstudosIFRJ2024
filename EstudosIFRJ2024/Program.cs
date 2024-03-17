int menu = 0;
Console.WriteLine("Bem - Vindo ao menu!\n");

do {
    Console.WriteLine("O que deseja fazer?\n(0)Encerrar\n(1) Calculadora de IMC\n(2) Calculadora de Peso Ideal\n(3) Jogo da Advinhação\n");
    Console.Write("Digite aqui: ");
    menu = Convert.ToInt32(Console.ReadLine());
    
    if (menu == 1) {
        CalculadoraIMC();
    }
    else if (menu == 2) {
        CalculadoraPesoIdeal();
    }
    else if (menu == 3) {
        JogoAdvinhacao();
    }

} while (menu != 0);

static void CalculadoraIMC() {
    Console.WriteLine("\nOk... Iniciando a calculadora de IMC!\n");
    Console.Write("Digite o seu peso (em kg): ");
    double peso = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite sua altura (em metros): ");
    double altura = Convert.ToDouble(Console.ReadLine());
    double imc = peso / (altura * altura);
    Console.WriteLine($"Seu IMC é: {imc:f1}");

    if (imc < 18.5) {
        Console.WriteLine("Você está abaixo do peso!\n");
    }
    else if (imc >= 18.5 && imc < 25) {
        Console.WriteLine("Você está no ideal!\n");
    }
    else if (imc >= 25 && imc < 30) {
        Console.WriteLine("Você está sobrepeso!\n");
    }
    else if (imc >= 30) {
        Console.WriteLine("Você está obeso!\n");
    }
    Console.WriteLine("Fim!\n");
}

static void CalculadoraPesoIdeal() {
    Console.WriteLine("\nOk... Iniciando a calculadora de peso ideal!\n");
    Console.Write("Digite a sua altura (em metros): ");
    double altura = Convert.ToDouble(Console.ReadLine());
    double minimoIMC = 18.5 * altura * altura;
    double maximoIMC = 24.9 * altura * altura;
    Console.WriteLine($"Segundo sua altura de {altura}, seu peso mínimo será {minimoIMC:f1} e o máximo será {maximoIMC:f1}!\n");

    Console.WriteLine("Fim!\n");
}

static void JogoAdvinhacao() {
    Console.WriteLine("\nOk... Iniciando o jogo da advinhação!\n");

    Random random = new Random();
    int sorteado = random.Next(1, 100);
    int tentativas = 10;
    int numero = 0;

    for (int i = tentativas; i > 0; i--) {
        Console.WriteLine($"Você tem mais {i} tentativas de tentar advinhar o número sorteado de 1 a 100!");
        Console.Write("Digite aqui:");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero == sorteado) {
            Console.WriteLine($"Parabéns, você acertou o número {sorteado} em {11 - i} tentativas!\n");
            i = 0;
        }
        else if (numero > sorteado) {
            Console.WriteLine("Hum... Parece que o número que você digitou é maior do que o que eu pensei. Tente novamente!\n");
        }
        else if (numero < sorteado) {
            Console.WriteLine("Hum... Parece que o número que você digitou é menor do que o que eu pensei. Tente novamente!\n");
        }
    }
    if (numero != sorteado) {
        Console.WriteLine($"Desculpe, mas suas tentativas acabaram! O número sorteado era {sorteado}!");
    }
    Console.WriteLine("Fim!\n");
}