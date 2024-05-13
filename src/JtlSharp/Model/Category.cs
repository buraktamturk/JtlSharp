namespace Jtl.Connector.Core.Model;

public record Category : AbstractIdentity
{
    /// <summary>
    /// Identity Optional reference to parent category id
    /// </summary>
    public Identity? parentCategoryId { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? isActive { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? level { get; init; }

    /// <summary>
    /// integer Optional sort order number
    /// </summary>
    public int? sort { get; init; }

    /// <summary>
    /// TranslatableAttribute
    /// </summary>
    public IReadOnlyCollection<CategoryAttribute>? attributes { get; init; }

    /// <summary>
    /// CategoryCustomerGroup
    /// </summary>
    public IReadOnlyCollection<CategoryCustomerGroup>? customerGroups { get; init; }

    /// <summary>
    /// CategoryI18n
    /// </summary>
    public IReadOnlyCollection<CategoryI18n>? i18ns { get; init; }

    /// <summary>
    /// CategoryInvisibility
    /// </summary>
    public IReadOnlyCollection<CategoryInvisibility>? invisibilities { get; init; }

}

