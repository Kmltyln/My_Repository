using System;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.ComplexTypes;

namespace ShopApp.Shared.Dtos.OrderDtos
{
    public class InOrderItemOrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public PaymentType PaymentType { get; set; }
        public OrderState OrderState { get; set; }
    }
}
