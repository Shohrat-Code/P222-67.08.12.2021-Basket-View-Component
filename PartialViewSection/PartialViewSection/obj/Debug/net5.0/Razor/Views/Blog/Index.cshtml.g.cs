#pragma checksum "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "767a088aa46707b8fd3aaa7abdf5e30773b58729"
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
#line 1 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\_ViewImports.cshtml"
using PartialViewSection.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767a088aa46707b8fd3aaa7abdf5e30773b58729", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3367806709322771f0ed7b312494991c57be9e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmBlog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BannerPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "767a088aa46707b8fd3aaa7abdf5e30773b587295211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 6 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Banner;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<section class=\"ftco-section ftco-degree-bg\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 ftco-animate\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 13 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
                     foreach (var item in Model.Blogs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-12 d-flex ftco-animate\">\r\n                            <div class=\"blog-entry align-self-stretch d-md-flex\">\r\n                                <a href=\"blog-single.html\" class=\"block-20\"");
            BeginWriteAttribute("style", " style=\"", 614, "\"", 670, 4);
            WriteAttributeValue("", 622, "background-image:", 622, 17, true);
            WriteAttributeValue(" ", 639, "url(\'images/", 640, 13, true);
#nullable restore
#line 17 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
WriteAttributeValue("", 652, item.MainImage, 652, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 667, "\');", 667, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                                <div class=""text d-block pl-md-4"">
                                    <div class=""meta mb-3"">
                                        <div><a href=""#"" style=""text-transform: capitalize;"">");
#nullable restore
#line 21 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
                                                                                        Write(item.CreatedDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                        <div><a href=\"#\">");
#nullable restore
#line 22 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
                                                    Write(item.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                        <div><a href=\"#\" class=\"meta-chat\"><span class=\"icon-chat\"></span> ");
#nullable restore
#line 23 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
                                                                                                      Write(item.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n                                    </div>\r\n                                    <h3 class=\"heading\"><a href=\"#\">");
#nullable restore
#line 25 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <p>");
#nullable restore
#line 26 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
                                   Write(item.Content!=null && item.Content.Length>150? item.Content.Substring(0,150) + "..." : item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p><a href=\"blog-single.html\" class=\"btn btn-primary py-2 px-3\">Read more</a></p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 31 "D:\Code Academy\Teaching\Groupes\P222\Lessons\67.08.12.2021\PartialViewSection\PartialViewSection\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n            <div class=\"col-lg-4 sidebar ftco-animate\">\r\n                <div class=\"sidebar-box\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "767a088aa46707b8fd3aaa7abdf5e30773b5872911299", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <span class=""icon ion-ios-search""></span>
                            <input type=""text"" class=""form-control"" placeholder=""Search..."">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading"">Categories</h3>
                    <ul class=""categories"">
                        <li><a href=""#"">Vegetables <span>(12)</span></a></li>
                        <li><a href=""#"">Fruits <span>(22)</span></a></li>
                        <li><a href=""#"">Juice <span>(37)</span></a></li>
                        <li><a href=""#"">Dries <span>(42)</span></a></li>
                    </ul>
                </div>
                <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading"">Recent Blog</h3>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_1.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading-1""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                           ");
            WriteLiteral(@" <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> April 09, 2019</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_2.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading-1""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> April 09, 2019</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></di");
            WriteLiteral(@"v>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""block-21 mb-4 d-flex"">
                        <a class=""blog-img mr-4"" style=""background-image: url(images/image_3.jpg);""></a>
                        <div class=""text"">
                            <h3 class=""heading-1""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                            <div class=""meta"">
                                <div><a href=""#""><span class=""icon-calendar""></span> April 09, 2019</a></div>
                                <div><a href=""#""><span class=""icon-person""></span> Admin</a></div>
                                <div><a href=""#""><span class=""icon-chat""></span> 19</a></div>
                            </div>
                        </div>
                    </div>
                </div>
         ");
            WriteLiteral(@"       <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading"">Tag Cloud</h3>
                    <div class=""tagcloud"">
                        <a href=""#"" class=""tag-cloud-link"">fruits</a>
                        <a href=""#"" class=""tag-cloud-link"">tomatoe</a>
                        <a href=""#"" class=""tag-cloud-link"">mango</a>
                        <a href=""#"" class=""tag-cloud-link"">apple</a>
                        <a href=""#"" class=""tag-cloud-link"">carrots</a>
                        <a href=""#"" class=""tag-cloud-link"">orange</a>
                        <a href=""#"" class=""tag-cloud-link"">pepper</a>
                        <a href=""#"" class=""tag-cloud-link"">eggplant</a>
                    </div>
                </div>
                <div class=""sidebar-box ftco-animate"">
                    <h3 class=""heading"">Paragraph</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia d");
            WriteLiteral("electus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmBlog> Html { get; private set; }
    }
}
#pragma warning restore 1591
