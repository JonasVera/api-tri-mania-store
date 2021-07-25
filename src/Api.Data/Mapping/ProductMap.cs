using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Api.Data.Mapping

{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(u => u.Id);

            builder.HasOne(e => e.User)
            .WithMany(c => c.Products)
            .HasForeignKey(e => e.UserID); 
             
            builder.HasOne(e => e.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(e => e.CategoryId);          
        }

        internal void configure(EntityTypeBuilder<User> obj)
        {
            throw new NotImplementedException();
        }
    }
}
