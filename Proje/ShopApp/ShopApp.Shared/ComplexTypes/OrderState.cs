using System.ComponentModel.DataAnnotations;

namespace ShopApp.Entity.Concrete;

public enum OrderState
{
    [Display(Name="Sipariş Alındı")]
Received=0,
Preparing=1,
Sent=2,
Delivered=3
}
