﻿using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Service
{
	public class ContactService : IContactService
	{
		public ContactDTO GetContactById(int Id)
		{
			var contact = new ContactDTO()
			{
				Id = Id,
				FirstName = "ufuk",
				LastName = "kurekci"
			};
			return contact;
		}
	}
}
