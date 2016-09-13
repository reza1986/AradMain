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
    
    #line 2 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
    using AradCms.Core.Controllers.Alerts;
    
    #line default
    #line hidden
    using ControlPannel;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class BootstrapBuilder : System.Web.WebPages.HelperPage
    {

#line 5 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
public static System.Web.WebPages.HelperResult ShowBootstrapAlerts(Bootstrap bootstrap)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 6 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
 

if (bootstrap == null)
{
    return;
}

foreach (var message in bootstrap.BootstrapMessages)
{
    var dismissableClass = message.Dismissable ? "alert-dismissable" : null;


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 493), Tuple.Create("\"", 549)
, Tuple.Create(Tuple.Create("", 501), Tuple.Create("alert", 501), true)
, Tuple.Create(Tuple.Create(" ", 506), Tuple.Create("alert-", 507), true)

#line 16 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
, Tuple.Create(Tuple.Create("", 513), Tuple.Create<System.Object, System.Int32>(message.AlertType

#line default
#line hidden
, 513), false)

#line 16 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
, Tuple.Create(Tuple.Create(" ", 531), Tuple.Create<System.Object, System.Int32>(dismissableClass

#line default
#line hidden
, 532), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 17 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
            

#line default
#line hidden

#line 17 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
             if (message.Dismissable)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <button");

WriteLiteralTo(__razor_helper_writer, " type=\"button\"");

WriteLiteralTo(__razor_helper_writer, " class=\"close\"");

WriteLiteralTo(__razor_helper_writer, " data-dismiss=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-hidden=\"true\"");

WriteLiteralTo(__razor_helper_writer, ">&times;</button>\r\n");


#line 20 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");


#line 21 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
WriteTo(__razor_helper_writer, message.Message);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </div>\r\n");


#line 23 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
}


#line default
#line hidden
});

#line 24 "..\..\Areas\Administration\Views\RazorHelpers\BootstrapBuilder.cshtml"
}
#line default
#line hidden

    }
}
#pragma warning restore 1591