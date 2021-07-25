using System;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Api.Data.Mapping

{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address"); 
            builder.HasOne(e => e.user)
            .WithMany(c => c.Addresses)
            .HasForeignKey(e => e.UserID);

        }
 

        internal void configure(EntityTypeBuilder<User> obj)
        {
            throw new NotImplementedException();
        }
    }
}
