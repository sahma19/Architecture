namespace Architecture.Database.User;

public sealed class UserConfiguration : IEntityTypeConfiguration<Domain.User>
{
    public void Configure(EntityTypeBuilder<Domain.User> builder)
    {
        builder.ToTable(nameof(Domain.User), nameof(Domain.User));

        builder.HasKey(entity => entity.Id);

        builder.Property(entity => entity.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(entity => entity.Name).HasMaxLength(250).IsRequired();

        builder.Property(entity => entity.Email).HasMaxLength(250).IsRequired();

        builder.Property(entity => entity.Status).IsRequired();

        builder.HasIndex(entity => entity.Email).IsUnique();
    }
}
