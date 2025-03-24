namespace Architecture.Database.Example;

public sealed class ExampleConfiguration : IEntityTypeConfiguration<Domain.Example>
{
    public void Configure(EntityTypeBuilder<Domain.Example> builder)
    {
        builder.ToTable(nameof(Domain.Example), nameof(Domain.Example));

        builder.HasKey(entity => entity.Id);

        builder.Property(entity => entity.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(entity => entity.Name).HasMaxLength(250).IsRequired();
    }
}
