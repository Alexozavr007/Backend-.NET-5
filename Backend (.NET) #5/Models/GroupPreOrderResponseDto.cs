using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend__.NET___5.Models {
    public class GroupPreOrderResponseDto {
        public List<ParticipantSessionDto> ParticipantSessions { get; set; } = new();
        public decimal TotalGroupAmount { get; set; }
    }

    public class ParticipantSessionDto {
        public Guid SessionId { get; set; }
        public string ParticipantName { get; set; }
        public List<DishDto> Dishes { get; set; } = new();
        public decimal TotalParticipantAmount { get; set; }
    }

    public class DishDto {
        public int DishId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
