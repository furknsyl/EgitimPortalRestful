﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Auth.Command.RefreshToken
{
    public class RefreshTokenCommandResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
