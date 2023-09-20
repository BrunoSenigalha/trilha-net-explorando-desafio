using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("------Hotel Sytem------\n");

// Cadastro de Hóspedes
Console.Write("Informe o nome do hóspede: ");
string nomeHospede = Console.ReadLine();

// Adicionando o primeiro Hóspede
Pessoa pessoa = new Pessoa(nome: nomeHospede);
hospedes.Add(pessoa);

// Laço para receber mais hóspedes
while (true)
{
    // Escolhe a oção de adicionar um novo hóspede ou não
    Console.WriteLine("Gostaria de cadastrar um novo hóspede? (s/n) ");
    string opcao = Console.ReadLine().ToLower();

    if (opcao == "s")
    {
        Console.Clear();
        Console.Write("Informe o nome do hóspede: ");
        nomeHospede = Console.ReadLine();

        pessoa = new Pessoa(nome: nomeHospede);
        hospedes.Add(pessoa);
    }
    else
    {
        break;
    }
}

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 30);

// Informa a quantidade de dias da reserva
Console.WriteLine("Informe a quantidade de dias da reserva");
int diasReservados = Convert.ToInt32(Console.ReadLine());

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: R$ {reserva.CalcularValorDiaria()}");