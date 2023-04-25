using FluentValidation;
using FluentValidation.Results;
using Magma3_Back.DTO;
using Magma3_Back.Entities;
using Magma3_Back.Validators;

namespace Magma3_Back.Services
{
    public class NotaService
    {
        private readonly AbstractValidator<NotaDTO> _validator;

        public NotaService()
        {
            _validator = new NotaValidator();
        }

        private readonly List<Nota> _notas = new List<Nota>
        {
            new Nota { Id = 1, Nome = "Geraldo Carlos", Email = "geraldo@gmail.com", Preco = 10.50m, Data = DateTime.Now },
            new Nota { Id = 2, Nome = "Paulo Ricardo", Email = "paulo@gmail.com", Preco = 55.25m, Data = DateTime.Now },
            new Nota { Id = 3, Nome = "Jorge Fonseca", Email = "jorge@gmail.com", Preco = 135.35m, Data = DateTime.Now },
        };

        public ValidationResult Validate(NotaDTO notaDto)
        {
            return _validator.Validate(notaDto);
        }

        public List<Nota> GetAllNotas()
        {
            return _notas;
        }

        public Nota GetNotaById(int id)
        {
            return _notas.FirstOrDefault(p => p.Id == id);
        }

        public void CreateNota(Nota nota)
        {
            nota.Id = _notas.Max(p => p.Id) + 1;
            _notas.Add(nota);
        }

        public void UpdateNota(int id, Nota notaAtualizada)
        {
            // Lógica para atualizar um produto
            var nota = _notas.FirstOrDefault(n => n.Id == id);
            if (nota != null)
            {
                nota.Nome = notaAtualizada.Nome;
                nota.Email = notaAtualizada.Email;
                nota.Preco = notaAtualizada.Preco;
                nota.Data = notaAtualizada.Data;
            }
        }

        public void DeleteNota(int id)
        {
            var nota = _notas.FirstOrDefault(n => n.Id == id);
            if (nota != null)
            {
                _notas.Remove(nota);
            }
        }

    }
}
