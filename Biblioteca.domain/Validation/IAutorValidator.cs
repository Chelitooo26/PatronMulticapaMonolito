
using System.Data.Common;
using Biblioteca.domain.entities;

namespace Biblioteca.Domain.Validation
{
    public interface IAutorValidator
    {
        public int Id { get; set; }

        string? Validar (Autor autor);
    }
}