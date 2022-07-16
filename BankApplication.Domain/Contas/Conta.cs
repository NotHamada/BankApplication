using BankApplication.Domain.Sedes;
using BankApplication.Domain.Usuarios;

namespace BankApplication.Domain.Contas
{
    public class Conta
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Codigo { get; set; }
        public string NumeroDoCartao { get; set; }
        public string SenhaDoCartao { get; set; }
        public decimal? Saldo { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual Cartao Cartao { get; set; }
    }
}