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

namespace ASP
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
    
    #line 2 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
    using Microsoft.Owin.Security;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Administration/Views/Account/_ExternalLoginsListPartial.cshtml")]
    public partial class _Areas_Administration_Views_Account__ExternalLoginsListPartial_cshtml : System.Web.Mvc.WebViewPage<AradCms.Core.ViewModel.Account.ExternalLoginListViewModel>
    {
        public _Areas_Administration_Views_Account__ExternalLoginsListPartial_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
  
    var loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes();
    var authenticationDescriptions = loginProviders as AuthenticationDescription[] ?? loginProviders.ToArray();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
 if (authenticationDescriptions.Any())
{

    using (Html.BeginForm(PaMVC.Administration.Account.ActionNames.ExternalLogin, PaMVC.Administration.Account.Name, new { ReturnUrl = Model.ReturnUrl }))
    {
        
            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
                                

        foreach (var p in authenticationDescriptions)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-danger btn-block text-capitalize\"");

WriteAttribute("id", Tuple.Create(" id=\"", 745), Tuple.Create("\"", 771)
            
            #line 17 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
           , Tuple.Create(Tuple.Create("", 750), Tuple.Create<System.Object, System.Int32>(p.AuthenticationType
            
            #line default
            #line hidden
, 750), false)
);

WriteLiteral(" name=\"provider\"");

WriteAttribute("value", Tuple.Create("\r\n                       value=\"", 788), Tuple.Create("\"", 841)
            
            #line 18 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
, Tuple.Create(Tuple.Create("", 820), Tuple.Create<System.Object, System.Int32>(p.AuthenticationType
            
            #line default
            #line hidden
, 820), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 842), Tuple.Create("\"", 873)
            
            #line 18 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
, Tuple.Create(Tuple.Create("", 850), Tuple.Create<System.Object, System.Int32>(p.Caption
            
            #line default
            #line hidden
, 850), false)
, Tuple.Create(Tuple.Create(" ", 860), Tuple.Create("ورود", 861), true)
, Tuple.Create(Tuple.Create(" ", 865), Tuple.Create("با", 866), true)
, Tuple.Create(Tuple.Create(" ", 868), Tuple.Create("حساب", 869), true)
);

WriteLiteral(" />\r\n                <hr />\r\n            </div>\r\n");

            
            #line 21 "..\..\Areas\Administration\Views\Account\_ExternalLoginsListPartial.cshtml"
        }

    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591