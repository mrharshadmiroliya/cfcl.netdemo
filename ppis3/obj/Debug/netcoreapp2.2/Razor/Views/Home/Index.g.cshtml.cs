#pragma checksum "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46b383fe4080e68bb8b6dfdec6be711319044144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\new\source\repos\ppis3\ppis3\Views\_ViewImports.cshtml"
using ppis3;

#line default
#line hidden
#line 2 "C:\Users\new\source\repos\ppis3\ppis3\Views\_ViewImports.cshtml"
using ppis3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b383fe4080e68bb8b6dfdec6be711319044144", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8bbf57826c88987c82fe42995fb30a3ede759ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 872, true);
            WriteLiteral(@"

<ul class=""nav nav-tabs"" role=""tablist"">
    <li role=""presentation"" class=""active""><a href=""#NGSheet-1"" aria-controls=""NG Sheet-1"" role=""tab"" data-toggle=""tab""><i class=""fa fa-home""></i>  <span>NG Sheet-1</span></a></li>
    <li role=""presentation""><a href=""#NGSheet-2"" aria-controls=""NG Sheet-2"" role=""tab"" data-toggle=""tab""><i class=""fa fa-user""></i>  <span>NG Sheet-2</span></a></li>
    <li role=""presentation""><a href=""#CO2Sheet"" aria-controls=""CO2 Sheet"" role=""tab"" data-toggle=""tab""><i class=""fa fa-envelope-o""></i>  <span>CO2 Sheet</span></a></li>
    <li role=""presentation""><a href=""#Production"" aria-controls=""Production"" role=""tab"" data-toggle=""tab""><i class=""fa fa-cog""></i>  <span>Production</span></a></li>
</ul>


<div class=""tab-content"">
    <div role=""tabpanel"" class=""tab-pane active"" id=""NG Sheet-1"">
        <div class=""text-center"">
");
            EndContext();
#line 17 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
              
                string[] a = {"", "Pressure of NG to Ammonia Plant(PI 1073)(kg / cm2 g)",
                              "Temperature of NG to Ammonia Plant (TI 1308) (°C)",
"Total NG to Ammonia Plant (FQI 1042) (kNM3)",
"Pressure of NG as GT Fuel (PI 1046)(kg/cm2 g)",
"Temperature of NG as GT Fuel (TIC 1219)(°C)",
"GT Fuel NG (FQI 1026) (kg)         ",
"Pressure of NG as Reformer Fuel (PIC 1002)(kg/cm2 g)",
"Temperature of NG as Reformer Fuel (TI 8152)(°C)",
"NG Fuel to Primary Reformer (FQI 1015) (NM3)",
"Pressure of NG as Superheater Fuel (PIC 1001) (kg/cm2 g)",
"Temperature of NG as Superheater Fuel (TI 8154) (°C)",
"NG Fuel to Superheater FQI 1015 (NM3)",
"NG Fuel to Startup Heater FQI 1047 (NM3)",
"NG Fuel to Flare Stack      ",
"NG Feed (FQI 1001) (kNM3)",
"Total Fuel (kSM3)            "};

                int[] b = { 0, 3, 6, 9, 12, 13, 14, 15, 16 };
                int i;
                int j = 1;
            

#line default
#line hidden
            BeginContext(1888, 337, true);
            WriteLiteral(@"            <div class=""form-row"">
                <div class=""form-group col-md-6""></div>
                <div class=""form-group col-md-2""><b>Reading</b></div>
                <div class=""form-group col-md-2""><b>Diffrence</b></div>
                <div class=""form-group col-md-2""><b>Consumption(SM3)</b></div>
            </div>
");
            EndContext();
#line 45 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
             for (i = 1; i <= 16; i++)
            {

#line default
#line hidden
            BeginContext(2280, 149, true);
            WriteLiteral("                <div class=\"form-row\">\r\n\r\n                    <div class=\"form-group col-md-6\">\r\n                        <label for=\"control-label \">");
            EndContext();
            BeginContext(2430, 4, false);
#line 50 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                                               Write(a[i]);

#line default
#line hidden
            EndContext();
            BeginContext(2434, 129, true);
            WriteLiteral("</label>\r\n\r\n\r\n                    </div>\r\n\r\n                    <div class=\"form-group col-md-2\">\r\n                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2563, "\"", 2585, 1);
#line 56 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 2570, "A3_N1_T"+@i, 2570, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2586, "\"", 2623, 3);
#line 56 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 2594, "A3_N1_T"+@i, 2594, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2609, "form-control", 2610, 13, true);
            WriteAttributeValue(" ", 2622, "", 2623, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2624, "\"", 2653, 1);
#line 56 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 2638, "A3_N1_T"+@i, 2638, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2654, 120, true);
            WriteLiteral(" />\r\n\r\n                    </div>\r\n                    <div class=\"form-group col-md-2\">\r\n                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2774, "\"", 2799, 2);
#line 60 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 2781, "A3_N1_T"+@i, 2781, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2796, "_ID", 2796, 3, true);
            EndWriteAttribute();
            BeginContext(2800, 2, true);
            WriteLiteral(" ;");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2802, "\"", 2842, 4);
#line 60 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 2810, "A3_N1_T"+@i, 2810, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2825, "_ID", 2825, 3, true);
            WriteAttributeValue(" ", 2828, "form-control", 2829, 13, true);
            WriteAttributeValue(" ", 2841, "", 2842, 1, true);
            EndWriteAttribute();
            BeginContext(2843, 23, true);
            WriteLiteral(" tabindex=\"-1\" readonly");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2866, "\"", 2898, 2);
#line 60 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 2880, "A3_N1_T"+@i, 2880, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2895, "_ID", 2895, 3, true);
            EndWriteAttribute();
            BeginContext(2899, 35, true);
            WriteLiteral(" />\r\n                    </div>\r\n\r\n");
            EndContext();
#line 63 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                     if (i == b[j])
                    {

#line default
#line hidden
            BeginContext(2994, 93, true);
            WriteLiteral("                        <div class=\"form-group col-md-2\">\r\n                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 3087, "\"", 3113, 5);
            WriteAttributeValue("", 3094, "A3_N\'", 3094, 5, true);
#line 66 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 3099, i, 3099, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 3101, "\'_T\'", 3101, 4, true);
#line 66 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 3105, i, 3105, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 3107, "\'_CONS", 3107, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3114, "\"", 3158, 4);
#line 66 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 3122, "A3_N1_T" + @i, 3122, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 3139, "_CONS", 3139, 5, true);
            WriteAttributeValue(" ", 3144, "form-control", 3145, 13, true);
            WriteAttributeValue(" ", 3157, "", 3158, 1, true);
            EndWriteAttribute();
            BeginContext(3159, 23, true);
            WriteLiteral(" tabindex=\"-1\" readonly");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 3182, "\"", 3218, 2);
#line 66 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 3196, "A3_N1_T" + @i, 3196, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 3213, "_CONS", 3213, 5, true);
            EndWriteAttribute();
            BeginContext(3219, 37, true);
            WriteLiteral(" />\r\n                        </div>\r\n");
            EndContext();
#line 68 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                        j++;
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3358, 65, true);
            WriteLiteral("                        <div class=\"form-group col-md-2\"></div>\r\n");
            EndContext();
#line 73 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3446, 28, true);
            WriteLiteral("\r\n\r\n                </div>\r\n");
            EndContext();
#line 77 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3489, 122, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div role=\"tabpanel\" class=\"tab-pane\" id=\"NGSheet-2\">\r\n        <div class=\"text-center\">\r\n");
            EndContext();
#line 82 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
              
                string[] a1 = {"", "GAIL Meter-A",
                                  "Total NG Received (SM3)",
"",
"Pressure of NG as GT Fuel (PI 1046)(kg/cm2 g)",
"Temperature of NG as GT Fuel (TIC 1219)(°C)",
"GT Fuel NG (FQI 1026) (kg)         ",
"Pressure of NG as Reformer Fuel (PIC 1002)(kg/cm2 g)",
"Temperature of NG as Reformer Fuel (TI 8152)(°C)",
"NG Fuel to Primary Reformer (FQI 1015) (NM3)",
"Pressure of NG as Superheater Fuel (PIC 1001) (kg/cm2 g)",
"Temperature of NG as Superheater Fuel (TI 8154) (°C)",
"NG Fuel to Superheater FQI 1015 (NM3)",
"NG Fuel to Startup Heater FQI 1047 (NM3)",
"NG Fuel to Flare Stack      ",
"NG Feed (FQI 1001) (kNM3)",
"Total Fuel (kSM3)            "};

                int[] c = { 0, 3, 6, 9, 12, 13, 14, 15, 16 };
                j = 1;
                ;
            

#line default
#line hidden
            BeginContext(4469, 312, true);
            WriteLiteral(@"            <div class=""form-row"">
                <div class=""form-group col-md-6""></div>
                <div class=""form-group col-md-2""><b>Reading</b></div>
                <div class=""form-group col-md-2""><b></b></div>
                <div class=""form-group col-md-2""><b></b></div>
            </div>
");
            EndContext();
#line 110 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
             for (i = 1; i <= 8; i++)
            {

#line default
#line hidden
            BeginContext(4835, 36, true);
            WriteLiteral("            <div class=\"form-row\">\r\n");
            EndContext();
#line 113 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                 if (i % 2 == 1)
                {

#line default
#line hidden
            BeginContext(4924, 107, true);
            WriteLiteral("                    <div class=\"form-group col-md-3\">\r\n                        <label for=\"control-label \">");
            EndContext();
            BeginContext(5032, 4, false);
#line 116 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                                               Write(a[i]);

#line default
#line hidden
            EndContext();
            BeginContext(5036, 38, true);
            WriteLiteral("</label>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(5076, 85, true);
            WriteLiteral("                    <div class=\"form-group col-md-3\">\r\n                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 5161, "\"", 5185, 1);
#line 120 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 5168, "A3_N2_T" + @i, 5168, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5186, "\"", 5225, 3);
#line 120 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 5194, "A3_N2_T" + @i, 5194, 17, false);

#line default
#line hidden
            WriteAttributeValue(" ", 5211, "form-control", 5212, 13, true);
            WriteAttributeValue(" ", 5224, "", 5225, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 5226, "\"", 5257, 1);
#line 120 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 5240, "A3_N2_T" + @i, 5240, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5258, 33, true);
            WriteLiteral(" />\r\n                    </div>\r\n");
            EndContext();
#line 122 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(5351, 107, true);
            WriteLiteral("                    <div class=\"form-group col-md-3\">\r\n                        <label for=\"control-label \">");
            EndContext();
            BeginContext(5459, 4, false);
#line 126 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                                               Write(a[i]);

#line default
#line hidden
            EndContext();
            BeginContext(5463, 123, true);
            WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"form-group col-md-3\">\r\n                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 5586, "\"", 5610, 1);
#line 129 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 5593, "A3_N2_T" + @i, 5593, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5611, "\"", 5650, 3);
#line 129 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 5619, "A3_N2_T" + @i, 5619, 17, false);

#line default
#line hidden
            WriteAttributeValue(" ", 5636, "form-control", 5637, 13, true);
            WriteAttributeValue(" ", 5649, "", 5650, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 5651, "\"", 5682, 1);
#line 129 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
WriteAttributeValue("", 5665, "A3_N2_T" + @i, 5665, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5683, 33, true);
            WriteLiteral(" />\r\n                    </div>\r\n");
            EndContext();
#line 131 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5735, 26, true);
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n");
            EndContext();
#line 136 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5776, 208, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div role=\"tabpanel\" class=\"tab-pane\" id=\"CO2Sheet\">\r\n        hello\r\n    </div>\r\n    <div role=\"tabpanel\" class=\"tab-pane\" id=\"Production\">\r\n        hello\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6002, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 147 "C:\Users\new\source\repos\ppis3\ppis3\Views\Home\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(6072, 10245, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {



            $('.A3_N1_T1').change(function () {
                $('.A3_N1_T1_ID').val(100 - A3_N1_T1 / (24));
            });
            $('.A3_N1_T2').change(function () {
                $('.A3_N1_T2_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T2').val()) / (24));
            });
            $('.A3_N1_T3').change(function () {
                $('.A3_N1_T3_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T3').val()) / (24));
                $('.A3_N1_T3_CONS').val(parseFloat(""0"" + $('.A3_N1_T3_ID').val()) * 1000 * 288 / 273);
            });
            $('.A3_N1_T4').change(function () {
                $('.A3_N1_T4_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T4').val()) / (24));
            });
            $('.A3_N1_T5').change(function () {
                $('.A3_N1_T5_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T5').val()) / (24));
            });
            $('.A3_N1_T6').change(function () {
                $('.A3_N1_T6_ID').val(100 -");
                WriteLiteral(@" parseFloat(""0"" + $('.A3_N1_T6').val()) / (24));
                $('.A3_N1_T6_CONS').val(((parseFloat(""0"" + $('.A3_N1_T6_ID').val()) * 22.414 * 288) / (parseFloat(""0"" + $('.A3_N1_T4').val()) * 273)) * 1000);
            });
            $('.A3_N1_T7').change(function () {
                $('.A3_N1_T7_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T7').val()) / (24));
            });
            $('.A3_N1_T8').change(function () {
                $('.A3_N1_T8_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T8').val()) / (24));
            });
            $('.A3_N1_T9').change(function () {
                $('.A3_N1_T9_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T9').val()) / (24));
                $('.A3_N1_T9_CONS').val((parseFloat(""0"" + $('.A3_N1_T9_ID').val()) * 288) / 273);
            });
            $('.A3_N1_T10').change(function () {
                $('.A3_N1_T10_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T10').val()) / (24));
            });
            $('.A3_N1_T11').change(function () {
         ");
                WriteLiteral(@"       $('.A3_N1_T11_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T11').val()) / (24));
            });
            $('.A3_N1_T12').change(function () {
                $('.A3_N1_T12_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T12').val()) / (24));
                $('.A3_N1_T12_CONS').val((parseFloat(""0"" + $('.A3_N1_T12_ID').val()) * 288) / 273);
            });
            $('.A3_N1_T13').change(function () {
                $('.A3_N1_T13_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T13').val()) / (24));
                $('.A3_N1_T13_CONS').val(parseFloat(""0"" + $('.A3_N1_T13_ID').val()) * (288 / 273) * (((parseFloat(""0"" + $('.A3_N1_T10_ID').val()) + 1.033) * 403 * 100) / (3.3033 * (parseFloat(""0"" + $('.A3_N1_T11_ID').val()) + 273) * 16.34)) ^ 0.5);
            });
            $('.A3_N1_T15').change(function () {
                $('.A3_N1_T15_ID').val(100 - parseFloat(""0"" + $('.A3_N1_T15').val()) / (24));
                $('.A3_N1_T15_CONS').val(parseFloat(""0"" + $('.A3_N1_T15_ID').val()) * 1000 * 288 / 27");
                WriteLiteral(@"3);
            });
            $('.A3_N1_T15').change(function () {
                $('.A3_N1_T16_CONS').val(parseFloat(""0"" + $('.A3_N1_T6_CONS').val()) + parseFloat(""0"" + $('.A3_N1_T9_CONS').val()) + parseFloat(""0"" + $('.A3_N1_T12_CONS').val()) + parseFloat(""0"" + $('.A3_N1_T13_CONS').val()) + parseFloat(""0"" + $('.A3_N1_T14_CONS').val()));
            });
        });
    </script>
    <script>
        $(document).ready(function () {


            $('.A3_N2_T2').change(function () {
                $('.A3_N2_T3_CV').val(parseFloat(""0"" + $('.A3_N2_T1').val()) + parseFloat(""0"" + $('.A3_N2_T2').val()));
            });
            $('.A3_N2_T8').change(function () {
                $('.A3_N2_T8_CV').val(parseFloat(""0"" + $('.A3_N2_T8').val()) * 251999.9979 / parseFloat(""0"" + $('.A3_N2_T5').val()));
            });
            $('.A3_N2_T8').change(function () {
                if (parseFloat(""0"" + $('.A3_N2_T3_CV').val()) > parseFloat(""0"" + $('.A3_N2_T8_CV').val()))
                    $('.A3_N");
                WriteLiteral(@"2_T8_CONS').val(parseFloat(""0"" + $('.A3_N2_T8_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val()));
                else
                    $('.A3_N2_T8_CONS').val(parseFloat(""0"" + $('.A3_N2_T3_CV').val()));
            });

            $('.A3_N2_T9').change(function () {
                $('.A3_N2_T9_CV').val(parseFloat(""0"" + $('.A3_N2_T9').val()) * 251999.9979 / parseFloat(""0"" + $('.A3_N2_T5').val()));
            });
            $('.A3_N2_T9').change(function () {
                var v1 = (parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - parseFloat(""0"" + $('.A3_N2_T8_CV').val()));
                if (v1 > parseFloat(""0"" + $('.A3_N2_T9_CV').val()))
                    $('.A3_N2_T9_CONS').val(parseFloat(""0"" + $('.A3_N2_T9_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val()));
                else
                    $('.A3_N2_T9_CONS').val(parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - (parseFloat(""0"" + $('.A3_N2_T8_CV').");
                WriteLiteral(@"val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())));
            });

            $('.A3_N2_T10').change(function () {
                $('.A3_N2_T10_CV').val(parseFloat(""0"" + $('.A3_N2_T10').val()) * 251999.9979 / parseFloat(""0"" + $('.A3_N2_T5').val()));
            });
            var v2 = (parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - parseFloat(""0"" + $('.A3_N2_T8_CV').val()) - parseFloat(""0"" + $('.A3_N2_T9_CV').val()));
            $('.A3_N2_T10').change(function () {
                if (v2 > parseFloat(""0"" + $('.A3_N2_T10_CV').val()))
                    $('.A3_N2_T10_CONS').val(parseFloat(""0"" + $('.A3_N2_T10_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val()));
                else
                    $('.A3_N2_T10_CONS').val(parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - (parseFloat(""0"" + $('.A3_N2_T8_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())) - (parseFloat(""0"" + $('");
                WriteLiteral(@".A3_N2_T9_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())));
            });

            $('.A3_N2_T11').change(function () {
                $('.A3_N2_T11_CV').val(parseFloat(""0"" + $('.A3_N2_T11').val()) * 251999.9979 / parseFloat(""0"" + $('.A3_N2_T5').val()));
            });

            var v3 = (parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - parseFloat(""0"" + $('.A3_N2_T8_CV').val()) - parseFloat(""0"" + $('.A3_N2_T9_CV').val()) - parseFloat(""0"" + $('.A3_N2_T10_CV').val()));
            var v4 = (parseFloat(""0"" + $('.A3_N2_T11_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val()));
            $('.A3_N2_T11').change(function () {
                if (v3 > v4)
                    $('.A3_N2_T11_CONS').val(parseFloat(""0"" + $('.A3_N2_T11_CV').val()));
                else
                    $('.A3_N2_T11_CONS').val(
                        (parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - parseFloat(""0"" + $('.A3_N2_T8_CV");
                WriteLiteral(@"').val()) -
                            (parseFloat(""0"" + $('.A3_N2_T8_CV').val()) -
                                (parseFloat(""0"" + $('.A3_N2_T8_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())) -
                                (parseFloat(""0"" + $('.A3_N2_T9_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())) -
                                (parseFloat(""0"" + $('.A3_N2_T10_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())))));
            });
            $('.A3_N2_T12').change(function () {
                $('.A3_N2_T12_CV').val(parseFloat(""0"" + $('.A3_N2_T11').val()) * 251999.9979 / parseFloat(""0"" + $('.A3_N2_T5').val()));
            });
            $('.A3_N2_T12').change(function () {
                var v5 = (parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - parseFloat(""0"" + $('.A3_N2_T8_CV').val()) - parseFloat(""0"" + $('.A3_N2_T9_CV').val()) - parseFloat(""0"" + $('.A");
                WriteLiteral(@"3_N2_T10_CV').val()) - parseFloat(""0"" + $('.A3_N2_T11_CV').val()));

                var v6 = (parseFloat(""0"" + $('.A3_N2_T12_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val()));

                if (v5 > v6)
                    $('.A3_N2_T12_CONS').val(parseFloat(""0"" + $('.A3_N2_T12_CV').val()));
                else
                    $('.A3_N2_T12_CONS').val(parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - (parseFloat(""0"" + $('.A3_N2_T8_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())) - (parseFloat(""0"" + $('.A3_N2_T9_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())) - (parseFloat(""0"" + $('.A3_N2_T10_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())) - (parseFloat(""0"" + $('.A3_N2_T11_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())));

            });
            $('.A3_N2_T16').cha");
                WriteLiteral(@"nge(function () {
                $('.A3_N2_T19_CV').val(parseFloat(""0"" + $('.A3_N1_T16_CONS').val()));
            });
            $('.A3_N2_T16').change(function () {
                $('.A3_N2_T20_CV').val(parseFloat(""0"" + $('.A3_N2_T18_CV').val()) - parseFloat(""0"" + $('.A3_N1_T16_CONS').val()));
            });

            $('.A3_N2_T22').change(function () {
                $('.A3_N2_T22_CV').val(parseFloat(""0"" + $('.A3_N2_T22').val()) * 251999.9979 / parseFloat(""0"" + $('.A3_N2_T5').val()));
                $('.A3_N2_T22_CONS').val(parseFloat(""0"" + $('.A3_N2_T3_CV').val()) - (parseFloat(""0"" + $('.A3_N2_T8_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())) - (parseFloat(""0"" + $('.A3_N2_T9_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())) - (parseFloat(""0"" + $('.A3_N2_T10_CV').val()) * parseFloat(""0"" + $('.A3_N2_T5').val()) / parseFloat(""0"" + $('.A3_N2_T5').val())));
            });

        });
    </scri");
                WriteLiteral("pt>\r\n");
                EndContext();
            }
            );
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
