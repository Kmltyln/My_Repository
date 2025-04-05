using System.ComponentModel.DataAnnotations;

namespace ShopApp.Shared.ComplexTypes;

public enum PaymentType
{
    [Display(Name="Kredi Kartı")]
CreditCard=0,
[Display(Name="Eft/Havale")]
Eft=1    
}
