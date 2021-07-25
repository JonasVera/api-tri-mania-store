using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Api.Data.Mapping

{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category"); 
            builder.HasKey(u => u.Id);
        }
  
        internal void configure(EntityTypeBuilder<Category> obj)
        {
            throw new NotImplementedException();
        }
    }
}
