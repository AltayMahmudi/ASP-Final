#pragma checksum "C:\Users\User\source\repos\Jotex\Jotex\Views\CaseStudies\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "782ef2a8cb138637b8ff2c52d42b84a7c2499fbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CaseStudies_index), @"mvc.1.0.view", @"/Views/CaseStudies/index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Jotex\Jotex\Views\_ViewImports.cshtml"
using Jotex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Jotex\Jotex\Views\_ViewImports.cshtml"
using Jotex.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"782ef2a8cb138637b8ff2c52d42b84a7c2499fbd", @"/Views/CaseStudies/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"177e4f8cec1a8afbc03ccb6b40fe9fe55a12721e", @"/Views/_ViewImports.cshtml")]
    public class Views_CaseStudies_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Page/_Loader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Page/_Title", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\source\repos\Jotex\Jotex\Views\CaseStudies\index.cshtml"
  
    ViewData["Title"] = "Case Studies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "782ef2a8cb138637b8ff2c52d42b84a7c2499fbd3874", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "782ef2a8cb138637b8ff2c52d42b84a7c2499fbd4990", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



    <section class=""page-title"">
        <div class=""page-title-container"">
            <div class=""page-title-wrapper"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col col-xs-12"">
                            <h2>Case studies</h2>
                            <ol class=""breadcrumb"">
                                <li><a href=""index.html"">Home</a></li>
                                <li>Case studies</li>
                            </ol>
                        </div>
                    </div> <!-- end row -->
                </div> <!-- end container -->
            </div>
        </div>
    </section>
    <!-- end page-title -->
    <!-- start case-studies-section -->
    <section class=""case-studies-section case-studies-pg-section section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col col-md-8 col-md-offset-2 col-sm-10 col-sm-offset-1"">
             ");
            WriteLiteral(@"       <div class=""section-title-s4"">
                        <span>Here Our Best Work</span>
                        <h2>Recent Case Studies</h2>
                        <p>Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nuncIt showed a lady fitted out</p>
                    </div>
                </div>
            </div>
        </div> <!-- end container -->
        <div class=""content-area"">
            <div class=""case-studies-grids case-studies-slider"">
                <div class=""grid"">
                    <div class=""img-holder"">
                        <img src=""assets/images/case-studies/img-1.jpg"" alt>
                    </div>
                    <div class=""overlay"">
                        <div class=""content"">
                            <p class=""cat"">Insurance</p>
                            <h3><a href=""#"">Life insurance</a></h3>
                        </div>
                    </div>
        ");
            WriteLiteral(@"        </div>
                <div class=""grid"">
                    <div class=""img-holder"">
                        <img src=""assets/images/case-studies/img-2.jpg"" alt>
                    </div>
                    <div class=""overlay"">
                        <div class=""content"">
                            <p class=""cat"">Insurance</p>
                            <h3><a href=""#"">Life insurance</a></h3>
                        </div>
                    </div>
                </div>
                <div class=""grid"">
                    <div class=""img-holder"">
                        <img src=""assets/images/case-studies/img-3.jpg"" alt>
                    </div>
                    <div class=""overlay"">
                        <div class=""content"">
                            <p class=""cat"">Insurance</p>
                            <h3><a href=""#"">Life insurance</a></h3>
                        </div>
                    </div>
                </div>
                <div class=""gr");
            WriteLiteral(@"id"">
                    <div class=""img-holder"">
                        <img src=""assets/images/case-studies/img-4.jpg"" alt>
                    </div>
                    <div class=""overlay"">
                        <div class=""content"">
                            <p class=""cat"">Insurance</p>
                            <h3><a href=""#"">Life insurance</a></h3>
                        </div>
                    </div>
                </div>
                <div class=""grid"">
                    <div class=""img-holder"">
                        <img src=""assets/images/case-studies/img-5.jpg"" alt>
                    </div>
                    <div class=""overlay"">
                        <div class=""content"">
                            <p class=""cat"">Insurance</p>
                            <h3><a href=""#"">Life insurance</a></h3>
                        </div>
                    </div>
                </div>
                <div class=""grid"">
                    <div class=""img-hold");
            WriteLiteral(@"er"">
                        <img src=""assets/images/case-studies/img-6.jpg"" alt>
                    </div>
                    <div class=""overlay"">
                        <div class=""content"">
                            <p class=""cat"">Insurance</p>
                            <h3><a href=""#"">Life insurance</a></h3>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- end case-studies-section -->

");
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