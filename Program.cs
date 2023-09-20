using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("------Hotel Sytem------\n");

Cadastro cadastroReserva = new Cadastro();

// Chamando o método para cadastramento de hóspedes
hospedes = cadastroReserva.CadastrandoHospede();

// Recebendo uma tupla com os valores para cadastrar a Suíte
var (tipoSuite, capacidade, valorDiario) = cadastroReserva.CadastroSuite();
Suite suite = new Suite(tipoSuite, capacidade, valorDiario);

// Informa a quantidade de dias da reserva
Console.WriteLine("Informe a quantidade de dias da reserva: ");
int diasReservados = Convert.ToInt32(Console.ReadLine());

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.Clear();

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: R$ {reserva.CalcularValorDiaria()}");