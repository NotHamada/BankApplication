using BankApplication.Domain.Usuarios;

namespace BankApplication.Domain.Contas
{
    public class Cartao { 
        public string NumeroDoCartao { get; set; }
        public string SenhaDoCartao { get; set; }
        public decimal? LimiteDeCredito { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}