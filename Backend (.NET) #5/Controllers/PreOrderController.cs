using Backend__.NET___5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend__.NET___5.Controllers {
    [ApiController]
    [Route("api/pre-orders")]
    public class PreOrderController : ControllerBase {
        [HttpGet("{groupId}/sessions")]
        public ActionResult<GroupPreOrderResponseDto> GetGroupSessions(Guid groupId) {
            var mockSessions = new List<ParticipantSessionDto>
            {
                new ParticipantSessionDto
                {
                    SessionId = Guid.NewGuid(),
                    ParticipantName = "Олександр",
                    Dishes = new List<DishDto>
                    {
                        new DishDto { DishId = 1, Name = "Хінкалі класичні", Price = 150, Quantity = 2 },
                        new DishDto { DishId = 2, Name = "Хачапурі по-аджарськи", Price = 220, Quantity = 1 }
                    }
                },
                new ParticipantSessionDto
                {
                    SessionId = Guid.NewGuid(),
                    ParticipantName = "Артем",
                    Dishes = new List<DishDto>
                    {
                        new DishDto { DishId = 1, Name = "Хінкалі класичні", Price = 150, Quantity = 3 },
                        new DishDto { DishId = 3, Name = "Узвар", Price = 60, Quantity = 2 }
                    }
                }
            };

            foreach (var session in mockSessions) {
                session.TotalParticipantAmount = session.Dishes.Sum(d => d.Price * d.Quantity);
            }

            var response = new GroupPreOrderResponseDto {
                ParticipantSessions = mockSessions,
                TotalGroupAmount = mockSessions.Sum(s => s.TotalParticipantAmount)
            };

            return Ok(response);
        }
    }
}
