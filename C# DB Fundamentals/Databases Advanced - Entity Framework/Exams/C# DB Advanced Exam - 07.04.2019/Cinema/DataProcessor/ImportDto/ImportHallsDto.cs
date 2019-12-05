﻿namespace Cinema.DataProcessor.ImportDto
{
    using System.ComponentModel.DataAnnotations;

    public class ImportHallsDto
    {
        [Required]
        [MaxLength(20), MinLength(3)]
        public string Name { get; set; }

        public bool Is4Dx { get; set; }

        public bool Is3D { get; set; }

        [Range(1,int.MaxValue)]
        public int Seats { get; set; }
    }
}
