namespace Architecture.Database.Auth;

public sealed class AuthConfiguration : IEntityTypeConfiguration<Domain.Auth>
{
    public void Configure(EntityTypeBuilder<Domain.Auth> builder)
    {
        builder.ToTable(nameof(Domain.Auth), nameof(Domain.Auth));

        builder.HasKey(entity => entity.Id);

        builder.Property(entity => entity.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(entity => entity.Login).HasMaxLength(100).IsRequired();

        builder.Property(entity => entity.Password).HasMaxLength(1000).IsRequired();

        builder.Property(entity => entity.Salt).HasMaxLength(1000).IsRequired();

        builder.Property(entity => entity.Roles).IsRequired();

        builder.HasOne(entity => entity.User).WithOne().HasForeignKey<Domain.Auth>("UserId").IsRequired();

        builder.HasIndex(entity => entity.Login).IsUnique();

        builder.HasIndex(entity => entity.Salt).IsUnique();

        builder.HasIndex("UserId").IsUnique();
    }
}
