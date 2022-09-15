using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
var hospedes = new List<Pessoa>();

var p1 = new Pessoa(nome: "Hóspede 1");
var p2 = new Pessoa(nome: "Hóspede 2");
var p3 = new Pessoa(nome: "Corrêa");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
var suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 50);

// Cria uma nova reserva, passando a suíte e os hóspedes
var reserva = new Reserva(diasReservados: 20);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");