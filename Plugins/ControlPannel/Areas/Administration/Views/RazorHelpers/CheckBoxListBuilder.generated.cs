﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlPannel.Areas.Administration.Views.RazorHelpers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using ControlPannel;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class CheckBoxListBuilder : System.Web.WebPages.HelperPage
    {

#line 3 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
public static System.Web.WebPages.HelperResult CheckBoxList(string name, List<System.Web.Mvc.SelectListItem> items)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 4 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"row\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 6 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
        

#line default
#line hidden

#line 6 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
         foreach (var item in items)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");

WriteLiteralTo(__razor_helper_writer, "\r\n                <div");

WriteLiteralTo(__razor_helper_writer, " class=\"col-md-4\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <input");

WriteLiteralTo(__razor_helper_writer, " type=\"checkbox\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 10 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
                                            if (item.Selected) {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");

WriteLiteralTo(__razor_helper_writer, " checked=\"checked\" ");

WriteLiteralTo(__razor_helper_writer, "   ");


#line 10 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
                                                                                                    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                           id=\"");


#line 11 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
 WriteTo(__razor_helper_writer, item.Value);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\" name=\"");


#line 11 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
                    WriteTo(__razor_helper_writer, name);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\" value=\"");


#line 11 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
                                  WriteTo(__razor_helper_writer, item.Value);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\" class=\"checkbox-inline\" />\r\n                    <label");

WriteAttributeTo(__razor_helper_writer, "for", Tuple.Create(" for=\"", 503), Tuple.Create("\"", 520)

#line 12 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
, Tuple.Create(Tuple.Create("", 509), Tuple.Create<System.Object, System.Int32>(item.Value

#line default
#line hidden
, 509), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"control-label\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 12 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
                                     WriteTo(__razor_helper_writer, item.Text);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</label>\r\n                </div>\r\n            ");

WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 15 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 17 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"


#line default
#line hidden
});

#line 17 "..\..\Areas\Administration\Views\RazorHelpers\CheckBoxListBuilder.cshtml"
}
#line default
#line hidden

    }
}
#pragma warning restore 1591
