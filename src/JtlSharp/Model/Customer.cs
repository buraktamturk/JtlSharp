namespace Jtl.Connector.Core.Model;

public record Customer : AbstractI18n
{
    /// <summary>
    /// Identity References a customer group
    /// </summary>
    public Identity? customerGroupId { get; init; }

    /// <summary>
    /// Identity Unique customer id
    /// </summary>
    public Identity? id { get; init; }

    /// <summary>
    /// double
    /// </summary>
    public decimal? accountCredit { get; init; }

    /// <summary>
    /// \DateTimeInterface|null Date of birth
    /// </summary>
    public DateTimeOffset? birthday { get; init; }

    /// <summary>
    /// string City
    /// </summary>
    public string? city { get; init; }

    /// <summary>
    /// string Company name
    /// </summary>
    public string? company { get; init; }

    /// <summary>
    /// string Country ISO 3166-2 (2 letter Uppercase
    /// </summary>
    public string? countryIso { get; init; }

    /// <summary>
    /// \DateTimeInterface|null
    /// </summary>
    public DateTimeOffset? creationDate { get; init; }

    /// <summary>
    /// string Optional customer number set by JTL-Wawi ERP software
    /// </summary>
    public string? customerNumber { get; init; }

    /// <summary>
    /// string Delivery instruction e.g. "c/o John Doe
    /// </summary>
    public string? deliveryInstruction { get; init; }

    /// <summary>
    /// double Percentage discount for customer on all prices
    /// </summary>
    public decimal? discount { get; init; }

    /// <summary>
    /// string E-Mail address
    /// </summary>
    public string? eMail { get; init; }

    /// <summary>
    /// string Extra address line e.g. "Apartment 2.5
    /// </summary>
    public string? extraAddressLine { get; init; }

    /// <summary>
    /// string Fax number
    /// </summary>
    public string? fax { get; init; }

    /// <summary>
    /// string First name
    /// </summary>
    public string? firstName { get; init; }

    /// <summary>
    /// boolean
    /// </summary>
    public bool? hasCustomerAccount { get; init; }

    /// <summary>
    /// boolean Optional flag if customer receives newsletter. If true, customer wants to receive newsletter
    /// </summary>
    public bool? hasNewsletterSubscription { get; init; }

    /// <summary>
    /// boolean Flag if customer is active (login allowed).
     ///              True, if customer is allowed to login with his E-Mail address and password
    /// </summary>
    public bool? isActive { get; init; }

    /// <summary>
    /// string Last name
    /// </summary>
    public string? lastName { get; init; }

    /// <summary>
    /// string Mobile phone number
    /// </summary>
    public string? mobile { get; init; }

    /// <summary>
    /// string customer note
    /// </summary>
    public string? note { get; init; }

    /// <summary>
    /// string Customer origin
    /// </summary>
    public string? origin { get; init; }

    /// <summary>
    /// string Phone number
    /// </summary>
    public string? phone { get; init; }

    /// <summary>
    /// string Salutation (german: "Anrede
    /// </summary>
    public string? salutation { get; init; }

    /// <summary>
    /// string State
    /// </summary>
    public string? state { get; init; }

    /// <summary>
    /// string Street name
    /// </summary>
    public string? street { get; init; }

    /// <summary>
    /// string Title, e.g. "Prof. Dr
    /// </summary>
    public string? title { get; init; }

    /// <summary>
    /// string VAT number (german "USt-ID
    /// </summary>
    public string? vatNumber { get; init; }

    /// <summary>
    /// string WWW address
    /// </summary>
    public string? websiteUrl { get; init; }

    /// <summary>
    /// string ZIP / postal code
    /// </summary>
    public string? zipCode { get; init; }

    /// <summary>
    /// KeyValueAttribute
    /// </summary>
    public IReadOnlyCollection<KeyValueAttribute>? attributes { get; init; }

}

