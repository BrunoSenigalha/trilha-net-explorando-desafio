namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // FEITO!!
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // FEITO!!
                throw new Exception("A quantidade de hóspedes cadastrados é maior do que a quantidade suportada pela suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // FEITO!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // FEITO!!
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // FEITO!!
            if (DiasReservados >= 10)
            {
                valor -= (valor * 0.10M);
            }

            return valor;
        }
    }
}