#pragma checksum "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a1894069a9799950ca37fd1dc48d69268565524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserModels_Index), @"mvc.1.0.view", @"/Views/UserModels/Index.cshtml")]
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
#line 1 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using E_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using E_Commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1894069a9799950ca37fd1dc48d69268565524", @"/Views/UserModels/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f015392c42bf201d3f4fa8f785de821ea8cb926", @"/Views/_ViewImports.cshtml")]
    public class Views_UserModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<E_Commerce.Models.UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wui-side-menu-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
  
   
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a1894069a9799950ca37fd1dc48d692685655246439", async() => {
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
<style>

    /* side menu */
    .wui-side-menu {
        position: fixed;
        top: 0;
        left: 0;
        width: 220px;
        height: 100%;
        backface-visibility: hidden;
        z-index: 3;
        -webkit-transform: translateX(-100%);
        transform: translateX(-100%);
        -webkit-transition: transform 220ms ease-in-out;
        transition: transform 220ms ease-in-out;
    }

        .wui-side-menu.open {
            -webkit-transform: translateX(0);
            transform: translateX(0);
        }

            .wui-side-menu.open ~ .content .side-menu-trigger {
                display: none;
            }

        .wui-side-menu.open {
            box-shadow: 2px 0 16px 0 rgba(0,0,0,0.3);
        }

        .wui-side-menu .header,
        .wui-content-header {
            vertical-align: baseline;
            line-height: 50px;
        }

    .wui-side-menu-pin-trigger,
    .wui-side-menu-trigger {
        width: 50px;
        height: 50px;
");
            WriteLiteral(@"        text-align: center;
        display: inline-block;
        font-size: 18px;
        line-height: 50px;
    }

    .wui-side-menu .wui-side-menu-pin-trigger {
        display: none;
        float: right;
    }

        .wui-side-menu .wui-side-menu-pin-trigger i {
            -webkit-transition: all 0.22s ease-out;
            -moz-transition: all 0.22s ease-out;
            -o-transition: all 0.22s ease-out;
            transition: all 0.22s ease-out;
        }

    .wui-side-menu .wui-side-menu-items {
        overflow-y: auto;
        height: calc(100% - 50px);
    }

    .wui-side-menu .wui-side-menu-item {
        display: block;
        width: 100%;
        padding: 15px 12px;
        border-left: 5px solid transparent;
    }

    .wui-side-menu .wui-side-menu-item {
        height: 50px
    }

        .wui-side-menu .wui-side-menu-item i.box-ico {
            margin-right: 4px;
        }

    /* overlay */
    .wui-overlay {
        position: absolute;
  ");
            WriteLiteral(@"      top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        z-index: 2;
        background-color: rgba(0, 0, 0, 0.1);
        opacity: 0.5;
        display: none;
    }

        .wui-side-menu.open ~ .wui-overlay, .wui-overlay.active {
            display: block;
        }

    /* content */
    .wui-content {
        z-index: 1;
        position: absolute;
        top: 0;
        right: 0;
        bottom: 0;
        left: 0;
        -webkit-transition: all 0.22s ease-out;
        -moz-transition: all 0.22s ease-out;
        -o-transition: all 0.22s ease-out;
        transition: all 0.22s ease-out;
        padding: 0 10px;
    }

        .wui-content .wui-side-menu-trigger {
            margin-left: -10px;
        }

    ul.wui-side-menu-items {
        list-style: none;
        padding: 0
    }

    .wui-side-menu {
        background-color: #292e34;
        color: #ddd;
    }

        .wui-side-menu .wui-side-menu-trigger:hover,
        .wui-side-m");
            WriteLiteral(@"enu-item:hover,
        .wui-side-menu-pin-trigger:hover {
            color: #fff;
            background-color: #383f45;
        }

        .wui-side-menu a {
            color: #ccc;
            text-decoration: none
        }

        .wui-side-menu .wui-side-menu-item.active {
            border-left-color: #158439;
            color: #158439
        }

    .wui-content a {
        color: #000;
    }


    /* demo */
    body {
        margin: 0;
        font-family: 'arial';
        font-weight: 100;
    }

    *, *:after, *:before {
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        box-sizing: border-box;
    }

    #events {
        background-color: #ccc;
    }
</style>


<div style=""padding-top:1.5%"" class=""wui-side-menu open pinned"" data-wui-theme=""dark"">
    <div class=""wui-side-menu-header"">
        <a href=""#"" class=""wui-side-menu-trigger""><i class=""fa fa-bars""></i></a>
        <a href=""#"" class=""wui-side-menu-pin-trig");
            WriteLiteral(@"ger"">
            <i class=""fa fa-thumb-tack""></i>
        </a>
    </div>
    <ul class=""wui-side-menu-items"">
        <li>
            <a href=""../UserModels/Index"" class=""wui-side-menu-item active"">
                <i class=""box-ico fa fa-users fa-fw""></i>
                <span class=""box-title"">All Users</span>
            </a>
        </li>
        <li>
            <a href=""../ProductModels/Index"" class=""wui-side-menu-item"">
                <i class=""box-ico fa fa-object-group fa-fw""></i>
                <span class=""box-title"">All Products</span>
            </a>
        </li>
        <li>
            <a href=""../ProductModels/Create"" class=""wui-side-menu-item"">
                <i class=""box-ico fa fa-cart-plus fa-fw""></i>
                <span class=""box-title"">Create Product</span>
            </a>
        </li>
        <li>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a1894069a9799950ca37fd1dc48d6926856552412701", async() => {
                WriteLiteral("\r\n                <i class=\"box-ico fa fa-list-alt fa-fw\"></i>\r\n                <span class=\"box-title\">All Order</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a1894069a9799950ca37fd1dc48d6926856552414529", async() => {
                WriteLiteral("\r\n                <i class=\"box-ico fas fa-sign-out-alt fa-fw\"></i>\r\n                <span class=\"box-title\">Logout as Admin</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>
    </ul>
</div>
<div class=""wui-content"">
    <div class=""wui-content-header"">
        <a href=""#"" class=""wui-side-menu-trigger"">
            <i class=""fa fa-bars"" style=""color:white;""></i>
        </a>
    </div>

    <div class=""wui-content-main"" style=""margin-left: 15%; margin-right:10%"">

      
        <table class=""table"" style=""margin-top:5%"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 228 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 231 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 234 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 238 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ContactNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 241 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 244 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 247 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 253 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 257 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 260 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 263 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
#nullable restore
#line 267 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ContactNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 270 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 273 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 276 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a1894069a9799950ca37fd1dc48d6926856552422416", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 280 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a1894069a9799950ca37fd1dc48d6926856552424626", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 281 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 284 "D:\Workspace\SEM-5\WDDN\project\EComerce\E-Commerce\E-Commerce\Views\UserModels\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<E_Commerce.Models.UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
