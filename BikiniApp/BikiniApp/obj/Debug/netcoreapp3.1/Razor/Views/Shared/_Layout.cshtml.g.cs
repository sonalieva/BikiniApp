#pragma checksum "C:\Users\user\Downloads\PortableGit\BP202\BikiniApp\BikiniApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bee3876f317dacceb053831112c200508afa550"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bee3876f317dacceb053831112c200508afa550", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/scss/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bee3876f317dacceb053831112c200508afa5504354", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Bikin</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bee3876f317dacceb053831112c200508afa5504823", async() => {
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
                WriteLiteral(@"
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"" integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bee3876f317dacceb053831112c200508afa5507214", async() => {
                WriteLiteral(@"
    <header>
        <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
            <div class=""container-fluid py-3"">
                <div class=""col-md-3 text-center"">
                    <a class=""navbar-brand"" href=""#"">
                        BIKIN
                    </a>
                </div>
                <div class=""collapse navbar-collapse col-md-6"" id=""navbarNavDropdown"">
                    <ul class=""navbar-nav mx-auto ms-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">HOME</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">ABOUT</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">SERVICES</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""na");
                WriteLiteral(@"v-link"" href=""#"">PORTFOLIO</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">TEAM</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">PRICING</a>
                        </li>
                        <li class=""nav-item drop"">
                            <a class=""nav-link"">
                                DROPDOWN MENU
                            </a>
                            <!-- <ul class=""drop-menu"">
                                <li><a class=""drop-item"" href=""#"">Drop down 1</a></li>
                                <li><a class=""drop-item"" href=""#"">deep Drop down ></a>
                                    <ul>
                                        <li><a href="""">Deep Drop Down 1</a></li>
                                        <li><a href="""">Deep Drop Down 2</a></li>
                                        <li><a");
                WriteLiteral(@" href="""">Deep Drop Down 3</a></li>
                                        <li><a href="""">Deep Drop Down 4</a></li>
                                        <li><a href="""">Deep Drop Down 5</a></li>
                                    </ul>
                                </li>
                                <li><a class=""drop-item"" href=""#"">Drop down 2</a></li>
                                <li><a class=""drop-item"" href=""#"">Drop down 3</a></li>
                                <li><a class=""drop-item"" href=""#"">Drop down 4</a></li>
                            </ul> -->
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">CONTACT</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-md-3 app-button"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 3734, "\"", 3741, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary px-4 align-titem-center\"> Get Started</a>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    ");
#nullable restore
#line 73 "C:\Users\user\Downloads\PortableGit\BP202\BikiniApp\BikiniApp\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer>
        <div class=""container "">
            <div class=""row d-flex"">
                <div class=""col-md-3"">
                    <h3>Bikin</h3>
                    <p>
                        A108 Adam Street
                        <br>
                        New York, NY 535022
                        <br>
                        United States
                        <br>
                        <br>
                        <strong>Phone:</strong>
                        +1 5589 55488 55
                        <br>
                        <strong>Email:</strong>
                        info@example.com
                    </p>

                </div>
                <div class=""col-md-2"">
                    <h4>Useful Links</h4>
                    <ul class=""list-unstyled text-decoration-none"">
                        <li>
                            <i class=""fa-solid fa-chevron-right""></i>
                            <a");
                BeginWriteAttribute("href", " href=\"", 4883, "\"", 4890, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\" text-decoration-none\">HOME</a>\r\n\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"fa-solid fa-chevron-right\"></i>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5096, "\"", 5103, 0);
                EndWriteAttribute();
                WriteLiteral(">HOME</a>\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"fa-solid fa-chevron-right\"></i>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5277, "\"", 5284, 0);
                EndWriteAttribute();
                WriteLiteral(">HOME</a>\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"fa-solid fa-chevron-right\"></i>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5458, "\"", 5465, 0);
                EndWriteAttribute();
                WriteLiteral(">HOME</a>\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"fa-solid fa-chevron-right\"></i>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5639, "\"", 5646, 0);
                EndWriteAttribute();
                WriteLiteral(@">HOME</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-md-3"">
                    <h4>Our Services</h4>
                    <ul class=""list-unstyled text-decoration-none"">
                        <li>
                            <i class=""fa-solid fa-chevron-right""></i>
                            <a");
                BeginWriteAttribute("href", " href=\"", 6023, "\"", 6030, 0);
                EndWriteAttribute();
                WriteLiteral(">Web Design</a>\r\n\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"fa-solid fa-chevron-right\"></i>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 6212, "\"", 6219, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                Web Development\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"fa-solid fa-chevron-right\"></i>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 6468, "\"", 6475, 0);
                EndWriteAttribute();
                WriteLiteral(">Product Management</a>\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"fa-solid fa-chevron-right\"></i>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 6663, "\"", 6670, 0);
                EndWriteAttribute();
                WriteLiteral(">HOME</a>\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"fa-solid fa-chevron-right\"></i>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 6844, "\"", 6851, 0);
                EndWriteAttribute();
                WriteLiteral(@">HOME</a>
                        </li>
                    </ul>
                </div>
                <div class=""col-md-4"">
                    <h4>Our Newsletter</h4>

                    <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>

                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bee3876f317dacceb053831112c200508afa55015917", async() => {
                    WriteLiteral("\r\n                        <input type=\"text\">\r\n                        <input type=\"submit\" value=\"Subscribe\" class=\"btn-primary\">\r\n\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </footer>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
