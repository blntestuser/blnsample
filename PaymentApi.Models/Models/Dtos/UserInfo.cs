using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApi.Models.Models.Dtos
{
	public class UserInfo
	{
		[EmailAddress]
		[Required]
		public string EmailAddress { get; set; }

		[Required]
		public string Password { get; set; }
	}
}