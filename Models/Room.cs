﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservio.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; } = null!;

        public bool isReserved = false;

        public Room(string code )
        {
            Code = code;
        }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
