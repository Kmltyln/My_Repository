using System;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.ComplexTypes;

namespace ShopApp.Shared.Dtos.OrderDtos
{
    public class ChangeStatusDto
    {
        public int Id { get; set; }
        public OrderState OrderState { get; set; }
    }
}
