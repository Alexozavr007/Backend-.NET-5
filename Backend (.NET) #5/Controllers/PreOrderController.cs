using Backend__.NET___5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend__.NET___5.Controllers {
    [ApiController]
    [Route("guest/groups")]
    public class PreOrderController : ControllerBase {
        [HttpGet("{groupReservationId}/sessions")]
        public ActionResult<GroupPreOrderResponseDto> GetGroupSessions(string groupReservationId) {
            var mockParticipants = new List<ParticipantDto>
            {
                new ParticipantDto
                {
                    Id = "session1",
                    Type = "Guest",
                    Name = "Andrii",
                    Items = new List<ItemDto>
                    {
                        new ItemDto
                        {
                            Dish = new DishDto { Id = "dish1", Name = "Caesar Salad", Price = 180 },
                            Quantity = 2
                        }
                    },
                    Total = 360,
                    IsSubmitted = true
                },
                new ParticipantDto
                {
                    Id = "session2",
                    Type = "Guest",
                    Name = "Olena",
                    Items = new List<ItemDto>
                    {
                        new ItemDto
                        {
                            Dish = new DishDto { Id = "dish2", Name = "Tom Yum", Price = 220 },
                            Quantity = 1
                        }
                    },
                    Total = 220,
                    IsSubmitted = false
                }
            };

            var response = new GroupPreOrderResponseDto {
                Participants = mockParticipants,
                Total = 580
            };

            return Ok(response);
        }
    }
}
