#pragma checksum "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b5c57ee8de95eee3647c620b08889e14f5450d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\_ViewImports.cshtml"
using BLOGSITE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\_ViewImports.cshtml"
using BLOGSITE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b5c57ee8de95eee3647c620b08889e14f5450d", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18294972f8d5aafbd02d773d352654214fadd447", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<section class=\"main-content-w3layouts-agileits\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<h3 class=\"tittle\">Bloglar</h3>\r\n\t\t\t<div class=\"inner-sec\">\r\n\t\t\t\t<!--left-->\r\n\t\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\t\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 15 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
                         foreach (var item in Model)
					   { 

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"col-lg-4 card\">\r\n\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 515, "\"", 536, 1);
#nullable restore
#line 19 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
WriteAttributeValue("", 521, item.BlogImage, 521, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 568, "\"", 574, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 25 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
                                                                            Write(((DateTime)
											item.BlogCreateDate).ToString("dd-mm-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
											</a> 
									</li>
									<li class=""mx-2"">
										<a href=""#"">
											<i class=""far fa-comment""></i> 
											0
										</a>
									</li>
									<li>
										<a href=""#"">
											<i class=""fas fa-eye""></i> 
											");
#nullable restore
#line 38 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
                                       Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1208, "\"", 1245, 2);
            WriteAttributeValue("", 1215, "/Blog/BlogReadAll/", 1215, 18, true);
#nullable restore
#line 44 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1233, item.BlogId, 1233, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 45 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">");
#nullable restore
#line 48 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
                                                     Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("....</p>\r\n\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1442, "\"", 1480, 3);
            WriteAttributeValue("", 1449, "/Blog/BlogReadAll/", 1449, 18, true);
#nullable restore
#line 49 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1467, item.BlogId, 1467, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1479, "/", 1479, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<br />\r\n");
#nullable restore
#line 53 "E:\ECOMMERCE\BLOGSITE\BLOGSITE\Views\Blog\Index.cshtml"
						  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<!--//left-->\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n </section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
