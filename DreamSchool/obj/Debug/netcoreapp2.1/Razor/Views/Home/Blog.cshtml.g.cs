#pragma checksum "D:\Pratics Projects\DreamSchool\DreamSchool\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a992ae2f36ceda783eb88095ae52fa74459c100d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Blog.cshtml", typeof(AspNetCore.Views_Home_Blog))]
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
#line 1 "D:\Pratics Projects\DreamSchool\DreamSchool\Views\_ViewImports.cshtml"
using DreamSchool;

#line default
#line hidden
#line 2 "D:\Pratics Projects\DreamSchool\DreamSchool\Views\_ViewImports.cshtml"
using DreamSchool.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a992ae2f36ceda783eb88095ae52fa74459c100d", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2595ba6fe1613c42b509338a5e4c0d13924d2550", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/ViewBlog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Pratics Projects\DreamSchool\DreamSchool\Views\Home\Blog.cshtml"
  
    ViewBag.Title = "Blog";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(85, 1669, true);
            WriteLiteral(@"
<!-- page title -->
<section class=""page-title-section overlay"" data-background=""/images/backgrounds/page-title.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <ul class=""list-inline custom-breadcrumb"">
                    <li class=""list-inline-item""><a class=""h2 text-primary font-secondary"" href=""#"">Our Blog</a></li>
                    <li class=""list-inline-item text-white h3 font-secondary""></li>
                </ul>
                <p class=""text-lighten"">Our courses offer a good compromise between the continuous assessment favoured by some universities and the emphasis placed on final exams by others.</p>
            </div>
        </div>
    </div>
</section>
<!-- /page title -->
<!-- blogs -->
<section class=""section"">
    <div class=""container"">
        <div class=""row"">
            <!-- blog post -->
            <article class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card rounded-0 border-bottom bord");
            WriteLiteral(@"er-primary border-top-0 border-left-0 border-right-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/blog/post-1.jpg"" alt=""Post thumb"">
                    <div class=""card-body"">
                        <!-- post meta -->
                        <ul class=""list-inline mb-3"">
                            <!-- post date -->
                            <li class=""list-inline-item mr-3 ml-0"">August 28, 2018</li>
                            <!-- author -->
                            <li class=""list-inline-item mr-3 ml-0"">By Somrat Sorkar</li>
                        </ul>
                        ");
            EndContext();
            BeginContext(1754, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8561818b711c4018bbe55a1888683603", async() => {
                BeginContext(1780, 120, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">Elegant Light Box Paper Cut Dioramas</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1904, 127, true);
            WriteLiteral("\r\n                        <p class=\"card-text\">Lorem ipsum dolor sit amet, consectetur adipisicin</p>\r\n                        ");
            EndContext();
            BeginContext(2031, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ebb28279e6e4949af147b7cc27c48a6", async() => {
                BeginContext(2088, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2101, 870, true);
            WriteLiteral(@"
                    </div>
                </div>
            </article>
            <!-- blog post -->
            <article class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card rounded-0 border-bottom border-primary border-top-0 border-left-0 border-right-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/blog/post-2.jpg"" alt=""Post thumb"">
                    <div class=""card-body"">
                        <!-- post meta -->
                        <ul class=""list-inline mb-3"">
                            <!-- post date -->
                            <li class=""list-inline-item mr-3 ml-0"">August 13, 2018</li>
                            <!-- author -->
                            <li class=""list-inline-item mr-3 ml-0"">By Jonathon Drew</li>
                        </ul>
                        ");
            EndContext();
            BeginContext(2971, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01946786688a4760a69974999ac0d8b8", async() => {
                BeginContext(2997, 113, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">The Expenses You Are Thinking</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3114, 127, true);
            WriteLiteral("\r\n                        <p class=\"card-text\">Lorem ipsum dolor sit amet, consectetur adipisicin</p>\r\n                        ");
            EndContext();
            BeginContext(3241, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "403364b0237847cfba6c67e1c94e7ab5", async() => {
                BeginContext(3298, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3311, 866, true);
            WriteLiteral(@"
                    </div>
                </div>
            </article>
            <!-- blog post -->
            <article class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card rounded-0 border-bottom border-primary border-top-0 border-left-0 border-right-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/blog/post-3.jpg"" alt=""Post thumb"">
                    <div class=""card-body"">
                        <!-- post meta -->
                        <ul class=""list-inline mb-3"">
                            <!-- post date -->
                            <li class=""list-inline-item mr-3 ml-0"">August 24, 2018</li>
                            <!-- author -->
                            <li class=""list-inline-item mr-3 ml-0"">By Alex Pitt</li>
                        </ul>
                        ");
            EndContext();
            BeginContext(4177, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c45a0e1e02e49af8a1979fbb597ed50", async() => {
                BeginContext(4203, 135, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">Lorem ipsum dolor amet, adipisicing eiusmod tempor.</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4342, 127, true);
            WriteLiteral("\r\n                        <p class=\"card-text\">Lorem ipsum dolor sit amet, consectetur adipisicin</p>\r\n                        ");
            EndContext();
            BeginContext(4469, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01565b1e32ea40baaf8cc4632b5d0d90", async() => {
                BeginContext(4526, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4539, 870, true);
            WriteLiteral(@"
                    </div>
                </div>
            </article>
            <!-- blog post -->
            <article class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card rounded-0 border-bottom border-primary border-top-0 border-left-0 border-right-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/blog/post-1.jpg"" alt=""Post thumb"">
                    <div class=""card-body"">
                        <!-- post meta -->
                        <ul class=""list-inline mb-3"">
                            <!-- post date -->
                            <li class=""list-inline-item mr-3 ml-0"">August 28, 2018</li>
                            <!-- author -->
                            <li class=""list-inline-item mr-3 ml-0"">By Somrat Sorkar</li>
                        </ul>
                        ");
            EndContext();
            BeginContext(5409, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96b186b876849a5a0a26bf4f8129ed8", async() => {
                BeginContext(5435, 123, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">Enrolling new members into the Libraray</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5562, 127, true);
            WriteLiteral("\r\n                        <p class=\"card-text\">Lorem ipsum dolor sit amet, consectetur adipisicin</p>\r\n                        ");
            EndContext();
            BeginContext(5689, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c435a53bd0b34174a7973af3bb619071", async() => {
                BeginContext(5746, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5759, 870, true);
            WriteLiteral(@"
                    </div>
                </div>
            </article>
            <!-- blog post -->
            <article class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card rounded-0 border-bottom border-primary border-top-0 border-left-0 border-right-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/blog/post-2.jpg"" alt=""Post thumb"">
                    <div class=""card-body"">
                        <!-- post meta -->
                        <ul class=""list-inline mb-3"">
                            <!-- post date -->
                            <li class=""list-inline-item mr-3 ml-0"">August 13, 2018</li>
                            <!-- author -->
                            <li class=""list-inline-item mr-3 ml-0"">By Jonathon Drew</li>
                        </ul>
                        ");
            EndContext();
            BeginContext(6629, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "962c4f997d684d7bbf6f1d23cced6a7a", async() => {
                BeginContext(6655, 126, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">Completion of Projects before the deadline</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6785, 127, true);
            WriteLiteral("\r\n                        <p class=\"card-text\">Lorem ipsum dolor sit amet, consectetur adipisicin</p>\r\n                        ");
            EndContext();
            BeginContext(6912, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5825bbd971874abe85f4c6596066ffbb", async() => {
                BeginContext(6969, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6982, 866, true);
            WriteLiteral(@"
                    </div>
                </div>
            </article>
            <!-- blog post -->
            <article class=""col-lg-4 col-sm-6 mb-5"">
                <div class=""card rounded-0 border-bottom border-primary border-top-0 border-left-0 border-right-0 hover-shadow"">
                    <img class=""card-img-top rounded-0"" src=""/images/blog/post-3.jpg"" alt=""Post thumb"">
                    <div class=""card-body"">
                        <!-- post meta -->
                        <ul class=""list-inline mb-3"">
                            <!-- post date -->
                            <li class=""list-inline-item mr-3 ml-0"">August 24, 2018</li>
                            <!-- author -->
                            <li class=""list-inline-item mr-3 ml-0"">By Alex Pitt</li>
                        </ul>
                        ");
            EndContext();
            BeginContext(7848, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f187053202924db88615e85264f7e82b", async() => {
                BeginContext(7874, 123, true);
                WriteLiteral("\r\n                            <h4 class=\"card-title\">The changing scenario in music industry</h4>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8001, 127, true);
            WriteLiteral("\r\n                        <p class=\"card-text\">Lorem ipsum dolor sit amet, consectetur adipisicin</p>\r\n                        ");
            EndContext();
            BeginContext(8128, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "975129cf014542bb9f191a39c466200e", async() => {
                BeginContext(8185, 9, true);
                WriteLiteral("read more");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8198, 135, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </article>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- /blogs -->\r\n");
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
