using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Models.ViewModels
{
	public class ProductVM
	{
		public Product Product { get; set; }
		[ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
