using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Context;
using WebApiExample.Models;

namespace WebApiExample.Services
{
    public class AuthService
    {
        private readonly TestApiContext _context;

        public AuthService(TestApiContext context)
        {
            _context = context;
        }

        public bool AddUser(UserModel user)
        {
            var result = _context.TblUsers.Add(user);
            _context.SaveChanges();

            return true;
        }

    }
}
