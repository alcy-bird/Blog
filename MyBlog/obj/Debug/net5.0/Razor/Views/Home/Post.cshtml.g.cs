#pragma checksum "C:\Users\aleyn\source\repos\MyBlog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3acc96a52108d56a7ea77b4c452afb324c5c24f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#nullable restore
#line 1 "C:\Users\aleyn\source\repos\MyBlog\Views\_ViewImports.cshtml"
using MyBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleyn\source\repos\MyBlog\Views\_ViewImports.cshtml"
using MyBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3acc96a52108d56a7ea77b4c452afb324c5c24f7", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b889b3f4308041dc292b61010b9c4781c7386c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyBlog.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!-- Page Header -->\n\n    <header class=\"masthead mt-2 pt-1\"");
            BeginWriteAttribute("style", " style=\"", 87, "\"", 136, 4);
            WriteAttributeValue("", 95, "background-image:", 95, 17, true);
            WriteAttributeValue(" ", 112, "url(\'", 113, 6, true);
#nullable restore
#line 5 "C:\Users\aleyn\source\repos\MyBlog\Views\Home\Post.cshtml"
WriteAttributeValue("", 118, Model.ImagePath, 118, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 134, "\')", 134, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"overlay\"></div>\n        <div class=\"container\">\n            <div class=\"row\">\n                <div class=\"col-lg-8 col-md-10 mx-auto\">\n                    <div class=\"post-heading\">\n                        <h1>");
#nullable restore
#line 11 "C:\Users\aleyn\source\repos\MyBlog\Views\Home\Post.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <h2 class=\"subheading\">");
#nullable restore
#line 12 "C:\Users\aleyn\source\repos\MyBlog\Views\Home\Post.cshtml"
                                          Write(Model.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <span class=\"meta\">\n                            ");
#nullable restore
#line 14 "C:\Users\aleyn\source\repos\MyBlog\Views\Home\Post.cshtml"
                       Write(Model.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" tarafından\n                            ");
#nullable restore
#line 15 "C:\Users\aleyn\source\repos\MyBlog\Views\Home\Post.cshtml"
                       Write(Model.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 'da yayınlandı.
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Post Content -->
    <article>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 col-md-10 mx-auto"">
                    ");
#nullable restore
#line 28 "C:\Users\aleyn\source\repos\MyBlog\Views\Home\Post.cshtml"
               Write(Html.Raw(Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </article>\n    <hr>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBlog.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
