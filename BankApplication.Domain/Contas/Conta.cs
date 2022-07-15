using BankApplication.Domain.Usuarios;

namespace BankApplication.Domain.Contas
{
    public class Conta
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Codigo { get; set; }
        public decimal? Saldo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}