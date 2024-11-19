using EntitiyFrameWorkTask2.Helpers;
using EntitiyFrameWorkTask2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameWorkTask2.Contexts
{
	public class StudentServiceDBContext:DbContext
	{
		
		public DbSet<Student> Students { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(sqlHelper.GetConnection());
			base.OnConfiguring(optionsBuilder);
		}
	}
}
