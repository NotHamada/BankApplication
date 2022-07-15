using BankApplication.Domain.Contas;
using BankApplication.Domain.Usuarios;

namespace BankApplication.Domain.Sedes
{
    public class Sede
    {
        public int Id { get; set; }
        public string Cidade { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; } = new HashSet<Usuario>();
        public virtual ICollection<Conta> Contas { get; set; } = new HashSet<Conta>();
    }
}