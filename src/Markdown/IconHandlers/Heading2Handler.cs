﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazui.Markdown.IconHandlers
{
    public class Heading2Handler : IIconHandler
    {
        private readonly IJSRuntime jSRuntime;

        public Heading2Handler(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public async Task HandleAsync(BMarkdownEditorBase editor)
        {
            await jSRuntime.InvokeVoidAsync("wrapSelection", editor.Textarea, "## ", "");
        }
    }
}
