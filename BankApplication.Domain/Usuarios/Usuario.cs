using BankApplication.Domain.Contas;
using BankApplication.Domain.Sedes;
using BankApplication.Domain.Usuarios.Enums;

namespace BankApplication.Domain.Usuarios
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Perfil Perfil { get; set; }

        public virtual Conta Conta { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual Cartao Cartao { get; set; }
    }
}
