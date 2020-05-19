﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.Component
{
    public interface IValidationRule
    {
        string ErrorMessage { get; set; }
        bool Validate(object value);
    }
}
