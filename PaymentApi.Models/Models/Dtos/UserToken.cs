using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApi.Models.Models.Dtos
{
	public class UserToken
	{
		public string Token { get; set; }
		public DateTime Expiration { get; set; }
	}
}