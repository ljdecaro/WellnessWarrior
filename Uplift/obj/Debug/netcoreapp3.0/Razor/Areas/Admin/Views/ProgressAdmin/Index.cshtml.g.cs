#pragma checksum "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f2f69e87f4fa226885368120790d15374f4462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProgressAdmin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProgressAdmin/Index.cshtml")]
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
#line 1 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\_ViewImports.cshtml"
using Uplift;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\_ViewImports.cshtml"
using Uplift.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62f2f69e87f4fa226885368120790d15374f4462", @"/Areas/Admin/Views/ProgressAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87bbc37cda1e571dbda615db81d13929c9935e9a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProgressAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Uplift.Models.progress>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
  
    ViewData["Title"] = "Entries Admin";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>User Entries Administrator</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f2f69e87f4fa226885368120790d15374f44625138", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped table-hover\" style=\"margin-top:50px; text-align:center;\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n                User <br />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 445, "\"", 514, 1);
#nullable restore
#line 18 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
WriteAttributeValue("", 452, Url.Action("Index", new { sortOrder = ViewBag.UserSortParm }), 452, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 19 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                     if (ViewBag.SortOrder == "user")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">expand_less</i> ");
#nullable restore
#line 20 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else if (ViewBag.SortOrder == "user_desc")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"material-icons\" style=\"font-size:18px\">expand_more</i>");
#nullable restore
#line 22 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">unfold_more</i>");
#nullable restore
#line 24 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </a>\r\n            </th>\r\n            <th>\r\n                Create Date <br />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1042, "\"", 1111, 1);
#nullable restore
#line 29 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
WriteAttributeValue("", 1049, Url.Action("Index", new { sortOrder = ViewBag.DateSortParm }), 1049, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 30 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                     if (ViewBag.SortOrder == "date")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">expand_less</i> ");
#nullable restore
#line 31 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else if (ViewBag.SortOrder == "date_desc")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"material-icons\" style=\"font-size:18px\">expand_more</i>");
#nullable restore
#line 33 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">unfold_more</i>");
#nullable restore
#line 35 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </a>\r\n            </th>\r\n            <th>\r\n                Flights Climbed <br />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1643, "\"", 1715, 1);
#nullable restore
#line 40 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
WriteAttributeValue("", 1650, Url.Action("Index", new { sortOrder = ViewBag.FlightsSortParm }), 1650, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 41 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                     if (ViewBag.SortOrder == "flights")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">expand_less</i> ");
#nullable restore
#line 42 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else if (ViewBag.SortOrder == "flights_desc")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"material-icons\" style=\"font-size:18px\">expand_more</i>");
#nullable restore
#line 44 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">unfold_more</i>");
#nullable restore
#line 46 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </a>\r\n            </th>\r\n            <th>\r\n                Steps <br />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2243, "\"", 2313, 1);
#nullable restore
#line 51 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
WriteAttributeValue("", 2250, Url.Action("Index", new { sortOrder = ViewBag.StepsSortParm }), 2250, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 52 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                     if (ViewBag.SortOrder == "steps")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">expand_less</i> ");
#nullable restore
#line 53 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else if (ViewBag.SortOrder == "steps_desc")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"material-icons\" style=\"font-size:18px\">expand_more</i>");
#nullable restore
#line 55 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">unfold_more</i>");
#nullable restore
#line 57 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </a>\r\n            </th>\r\n            <th>\r\n                Walk/Run Distance <br />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2849, "\"", 2922, 1);
#nullable restore
#line 62 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
WriteAttributeValue("", 2856, Url.Action("Index", new { sortOrder = ViewBag.DistanceSortParm }), 2856, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 63 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                     if (ViewBag.SortOrder == "distance")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">expand_less</i> ");
#nullable restore
#line 64 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else if (ViewBag.SortOrder == "distance_desc")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"material-icons\" style=\"font-size:18px\">expand_more</i>");
#nullable restore
#line 66 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                      }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"material-icons\" style=\"font-size:18px\">unfold_more</i>");
#nullable restore
#line 68 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </a>\r\n            </th>\r\n                <th style=\"width:300px\"></th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 76 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdentityUser.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.flights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.steps));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.distance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f2f69e87f4fa226885368120790d15374f446221708", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                       WriteLiteral(item.ID);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f2f69e87f4fa226885368120790d15374f446223980", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                          WriteLiteral(item.ID);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62f2f69e87f4fa226885368120790d15374f446226258", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
                                         WriteLiteral(item.ID);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 100 "C:\Users\Jake\Downloads\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Final-Project-dc5362a81257be0cba3cba1d542f11597e495454\Uplift\Areas\Admin\Views\ProgressAdmin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Uplift.Models.progress>> Html { get; private set; }
    }
}
#pragma warning restore 1591
