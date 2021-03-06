﻿namespace Panda.Models
{
    using Panda.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Package
    {
        public Package()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string ShippingAddress { get; set; }

        public Status Status { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        public string RecipientId { get; set; }

        public User Recipient { get; set; }
    }
}
