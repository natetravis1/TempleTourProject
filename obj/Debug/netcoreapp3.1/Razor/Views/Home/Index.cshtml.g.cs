#pragma checksum "C:\Users\murph\Source\Repos\TempleTourProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca8d594d130c21a34f9843c7bfd561102006f5bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\murph\Source\Repos\TempleTourProject\Views\_ViewImports.cshtml"
using TempleTourProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\murph\Source\Repos\TempleTourProject\Views\_ViewImports.cshtml"
using TempleTourProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\murph\Source\Repos\TempleTourProject\Views\_ViewImports.cshtml"
using TempleTourProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca8d594d130c21a34f9843c7bfd561102006f5bd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66066ce0291ca973166ecfdf3b72780308c7750", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\murph\Source\Repos\TempleTourProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<img src=""LaytonTemple.jpg"" style=""background-size:cover; background-position:center;position:relative;margin-left:75px"" />
<div style=""text-align: center; position: absolute; top: 50%; left: 50%; transform: translate(-50%, -200%); color: white; "">
    <h1 style=""font-size:80px"">Welcome</h1>
    <p>Sign up for a tour of the nearly constructed Layton, Utah, USA Temple</p>
</div>


<div class=""row p-1 m-1"">

    <div class=""col"">
        <p>
            We can only add a limited number of tours at this time. They will be removing the visitors center soon
            so that they can complete the landscaping. When the trailer is gone, we anticipate being able to talk
            to groups on the lawn of the church across the street or at the Morgan's backyard. We are trying to
            facilitate as many groups as possible, so please only sign-up when you can commit to coming on the selected
            date and time. We have a lot of last minute cancelations.
        </p>

        <p>");
            WriteLiteral(@"We can do groups on Saturday, please text me at 801-628-4488.</p>
    </div>

    <div class=""col"">
        <h3>General Tour Instructions:</h3>

        <ul>
            <li>Park on Rosewood (west side of the temple) and meet at the Visitors Center trailer.</li>
            <li>Dress casual, except on Sunday</li>
        </ul>

        <h3>Special Accommodations (check the appropriate box when signing up for a tour):</h3>

        <ul>
            <li>Spanish-speaking tours are available, by request.</li>
        </ul>

        <h3>Available Tours:</h3>
        <ul>
            <li>Tour (Outdoor): We will walk on the sidewalk along Oak Hills and on Rosewood in front of the temple on uneven surfaces; please wear sturdy shoes</li>
            <li>Trailer Tour: On Sunday. Masks are required</li>
        </ul>
    </div>
</div>

<h4 class=""p-1 m-1"">Please call or text 801-628-4488 with questions or special requests.</h4>");
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
