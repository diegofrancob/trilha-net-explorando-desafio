using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new();

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

try
{
    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva = new(diasReservados: 5);
    reserva.CadastrarSuite(suite);
    reserva.CadastrarHospedes(hospedes);

    Console.WriteLine(" - HOTEL DIO - ");
    Console.WriteLine();

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Suíte: [Tipo - {suite.TipoSuite} | Capacidade - {suite.Capacidade} | Valor Diária - {suite.ValorDiaria:C2}]");
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Dias reservados: {reserva.DiasReservados}");
    Console.WriteLine($"Valor total das diárias: {reserva.CalcularValorDiaria():C2}");
}
catch (ArgumentOutOfRangeException exA)
{
    Console.WriteLine(exA.Message);
}
catch (Exception ex){
    Console.WriteLine("Exceção não mapeada: " + ex.Message);
}