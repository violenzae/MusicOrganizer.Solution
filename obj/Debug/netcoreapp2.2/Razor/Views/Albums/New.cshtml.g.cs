#pragma checksum "C:\Users\Kristina\desktop\Music-Organizer\Views\Albums\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c95e9bd62d404ba8cfc47b94224aa355aff67a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_New), @"mvc.1.0.view", @"/Views/Albums/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albums/New.cshtml", typeof(AspNetCore.Views_Albums_New))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c95e9bd62d404ba8cfc47b94224aa355aff67a9", @"/Views/Albums/New.cshtml")]
    public class Views_Albums_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<h1>Add a new album to ");
            EndContext();
            BeginContext(24, 10, false);
#line 1 "C:\Users\Kristina\desktop\Music-Organizer\Views\Albums\New.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(34, 14, true);
            WriteLiteral("</h1>\r\n\r\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 48, "\"", 82, 3);
            WriteAttributeValue("", 57, "/artists/", 57, 9, true);
#line 3 "C:\Users\Kristina\desktop\Music-Organizer\Views\Albums\New.cshtml"
WriteAttributeValue("", 66, Model.Id, 66, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 75, "/albums", 75, 7, true);
            EndWriteAttribute();
            BeginContext(83, 69, true);
            WriteLiteral(" method=\"post\">\r\n  <input id=\"artistId\" name=\"artistId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 152, "\"", 169, 1);
#line 4 "C:\Users\Kristina\desktop\Music-Organizer\Views\Albums\New.cshtml"
WriteAttributeValue("", 160, Model.Id, 160, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(170, 380, true);
            WriteLiteral(@">
  <label for=""albumTitle"">Album title</label>
  <input id=""albumTitle"" name=""albumTitle"" type=""text"">
  <label for=""trackTotal"">total number of tracks</label>
  <input id=""trackTotal"" name=""trackTotal"" type=""text"">
  <label for=""runTime"">total run time of album</label>
  <input id=""runTime"" name=""runTime"" type=""text"">
  <button type='submit'>Add album</button>
</form>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591