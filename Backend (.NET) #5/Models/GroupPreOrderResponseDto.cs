using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend__.NET___5.Models {
    public class GroupPreOrderResponseDto {
        public List<ParticipantDto> Participants { get; set; } = new();
        public decimal Total { get; set; }
    }

    public class ParticipantDto {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public List<ItemDto> Items { get; set; } = new();
        public decimal Total { get; set; }
        public bool IsSubmitted { get; set; }
    }

    public class ItemDto {
        public DishDto Dish { get; set; }
        public int Quantity { get; set; }
    }

    public class DishDto {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
