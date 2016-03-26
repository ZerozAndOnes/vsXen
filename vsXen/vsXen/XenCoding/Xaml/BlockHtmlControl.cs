﻿/*
The MIT License (MIT)

Copyright (c) 2015 Nukeation Studios.

Permission is hereby granted, free of charge, to any person obtaining a copy 
of this software and associated documentation files (the "Software"), to deal 
in the Software without restriction, including without limitation the rights 
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
copies of the Software, and to permit persons to whom the Software is 
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in 
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
IN THE SOFTWARE.

https://github.com/daxpandhi/vsXen

*/

using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace vsXen.XenCoding.Xaml
{
    class BlockXAMLControl : HtmlGenericControl
    {
        public BlockXAMLControl(string tagName)
        {
            TagName = tagName;
        }

        protected override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.Write(Environment.NewLine);
            base.RenderBeginTag(writer);

            if (Controls.Count > 0 && Controls[0].Controls.Count > 1 || Controls.Count > 1)
            {
                writer.WriteLine(Environment.NewLine);
            }
        }

        protected override void RenderEndTag(HtmlTextWriter writer)
        {
            if (Controls.Count > 0 && Controls[0].Controls.Count > 1 || Controls.Count > 1)
            {
                writer.WriteLine(Environment.NewLine);
            }
            base.RenderEndTag(writer);
            writer.Write(Environment.NewLine);
        }
    }
}
