using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Endereco> Enderecos{ get; set; }
        public int EnderecoId { get; set; }
        public List<Dependente> Dependentes { get; set; }
        public int DependenteId { get; set; }
        public DateTime DtNascimento { get; set; }

    }
}
