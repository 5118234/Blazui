﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.Markdown
{
    public interface IIconHandler
    {
        Task HandleAsync(BMarkdownEditorBase editor);
    }
}
