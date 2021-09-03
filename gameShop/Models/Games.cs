using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameRock.Models
{
    public record Games
    {
        public Guid Id { get; init; }
        public string Title { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset ReleaseDate { get; init; }
            
    }
}
