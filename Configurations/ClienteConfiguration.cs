using Curso.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curso.Configurations
{
    public class ClienteConfiguration
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.OwnsOne(x=>x.Endereco, end =>
                end.Property(p=>p.Bairro).HasColumnName("Bairro");
                end.ToTable("Endereco");
            });
        }
    }
}