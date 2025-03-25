using System;

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; } = default!;
    public string TaxNumber { get; set; } = default!;
    public string TaxOffice { get; set; } = default!;
    public string CompanyRegistrationNumber { get; set; } = default!; // Ticaret Sicil No
    public string AuthorizedPersonName { get; set; } = default!;
    public DateTime CompanyFoundationDate { get; set; }
} 