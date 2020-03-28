using System;
using System.ComponentModel.DataAnnotations;

namespace Modrx.Models
{
    public class SubaruDealer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        [Range(0, 5)]
        public int ModFriendlyRating { get; set; }
    }
}