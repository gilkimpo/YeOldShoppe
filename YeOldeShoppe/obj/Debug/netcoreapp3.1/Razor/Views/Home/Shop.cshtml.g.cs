#pragma checksum "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92f48da19bec24e3c0387d963c99ae336fa61d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
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
#line 1 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\_ViewImports.cshtml"
using YeOldeShoppe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\_ViewImports.cshtml"
using YeOldeShoppe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a92f48da19bec24e3c0387d963c99ae336fa61d4", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04d1c66bdaffb95254e1f125e435419822c0676", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopDBContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
  
    ViewData["Title"] = "Shop";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"">
        <h1>Shop!</h1>
        <h1>Sooo tell me what you want, what you really really want</h1>
        <h1> </h1>
    </div>


<table>
    <tr>
        <td> </td>
        <td>Item&nbsp;</td>
        <td>Description&nbsp;</td>
        <td>Price&nbsp;</td>
        <td>Stock&nbsp;</td>
        
        <td>Get it!&nbsp;</td>
    </tr>
    <tr>--------------------------------------------------------------------------------------</tr>
");
#nullable restore
#line 28 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</td>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</td>\r\n    <td>");
#nullable restore
#line 34 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</td>\r\n    <td>");
#nullable restore
#line 35 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;</td>\r\n\r\n    \r\n    \r\n");
#nullable restore
#line 39 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td><button");
            BeginWriteAttribute("onclick", " onclick=\"", 979, "\"", 1115, 3);
            WriteAttributeValue("", 989, "location.href=\'", 989, 15, true);
#nullable restore
#line 41 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
WriteAttributeValue("", 1004, Url.Action("Purchase", "Home", new { itemPrice = item.Price, quantity = item.Quantity - 1, name = item.Name}), 1004, 110, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1114, "\'", 1114, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\"  class=\"btn btn-outline-dark\">Purchase</button></td>\r\n");
#nullable restore
#line 42 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n");
#nullable restore
#line 44 "C:\Users\gilki\source\repos\YeOldeShoppe\YeOldeShoppe\Views\Home\Shop.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<style>
    body {
        background-color: mediumpurple;
        background-image: url(https://i.pinimg.com/236x/40/36/e4/4036e4b881df8d5580f5c1fea82cbcc4--emma-bunton-spice-girls.jpg);
        background-repeat: no-repeat;
        background-size: 275px;
        background-position: bottom;
        background-position: right;
    }

    #leg1 {
        color: black;
    }
</style>



");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopDBContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
