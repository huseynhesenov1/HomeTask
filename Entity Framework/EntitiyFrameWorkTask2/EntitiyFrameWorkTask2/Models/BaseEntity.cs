using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameWorkTask2.Models
{
	public class BaseEntity
	{
		public int Id { get; set; }

		public DateTime? DeletedDate { get; set; }
		public DateTime? LastModifiateDate { get; set; }
		public DateTime? CreateDate { get; set; }
		public bool IsDeleted { get; set; }
	}
}
