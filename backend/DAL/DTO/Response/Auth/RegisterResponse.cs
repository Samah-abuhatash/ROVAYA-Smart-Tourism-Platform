using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovaya.DAL.DTO.Response.Auth
{
    public class RegisterResponse : BaseResponse
    {
       
        public string? UserId { get; set; }
        public string? Email { get; set; }


    }
}
