﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Services
{
    public interface ISharedIdentityService
    {
        public string GetUserId { get; }
    }
}
