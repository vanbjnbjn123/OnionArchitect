using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Onion.Domain.Models
{
	public class EntityBase
	{
		public EntityBase()
		{
            this.Id = Guid.NewGuid().ToString();
		}
        [Key]
        public string Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

