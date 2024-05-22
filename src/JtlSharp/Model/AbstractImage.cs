namespace Jtl.Connector.Core.Model;

public record AbstractImage : AbstractIdentity
{
    /// <summary>
    /// string
    /// </summary>
    public string? filename { get; init; }

    /// <summary>
    /// Identity
    /// </summary>
    public Identity? foreignKey { get; init; }

    /// <summary>
    /// ImageI18n
    /// </summary>
    public IReadOnlyCollection<ImageI18n>? i18ns { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? name { get; init; }

    /// <summary>
    /// string
    /// </summary>
    public string? remoteUrl { get; init; }

    /// <summary>
    /// integer
    /// </summary>
    public int? sort { get; init; }
    
    public string relationType { get; init; }

    public virtual bool CanOpen()
        => false;
    
    public virtual Stream OpenStream(out long length, out string? mimeType)
        => throw new NotImplementedException();
}

