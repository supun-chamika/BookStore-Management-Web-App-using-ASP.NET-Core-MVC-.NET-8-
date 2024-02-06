using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.IRepository
{
	public interface IUnitOfWork
	{
		// have all the repository
		ICategoryRepository Category { get; }
		IProductRepository Product { get; }
		void Save();
	}
}
