#pragma checksum "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "873124755708e6e85b58718d8af60ea31e84c5b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\_ViewImports.cshtml"
using Apartment.App.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\_ViewImports.cshtml"
using Apartment.App.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
using Apartment.App.Domain.Entities.IdentityEntities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"873124755708e6e85b58718d8af60ea31e84c5b5", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1edcc16e96f8971bdd1f91521b1b3c3d72f7cc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Apartment.App.Web.Models.UserViewModels.UserViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
   
     Layout = "~/Views/Shared/_Layout.cshtml";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(" <h1>Mevcut Kullanıcılar  </h1>\r\n \r\n <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 394, "\"", 427, 1);
#nullable restore
#line 12 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
WriteAttributeValue("", 401, Url.Action("Add", "User"), 401, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Yeni Kullanıcı Ekle</a>

 <table class=""table table-striped"">
     <thead>
     <tr>
         <th>Adı</th>
         <th>Soyadı</th>
         <th>Telefon No</th>
         <th>TC Kimlik No</th>
         <th>Email</th>
         <th>Plaka</th>
         <th>İşlemler</th>
     </tr>
     </thead>
     <tbody>
");
#nullable restore
#line 27 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
      foreach (var user in Model.Users)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\r\n             <td>");
#nullable restore
#line 30 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
            Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 31 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
            Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 32 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
            Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 33 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
            Write(user.TrIdentityNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n             <td>");
#nullable restore
#line 34 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
            Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>\r\n");
#nullable restore
#line 36 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
                  if (user.HasCar)
                 {
                     

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
                Write(user.CarPlateNumber);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
                                         
                 }
                 else
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <span class=\"label label-danger\">Araç Yok</span>\r\n");
#nullable restore
#line 43 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("             </td>\r\n             <th>\r\n                 <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1367, "\"", 1434, 1);
#nullable restore
#line 46 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
WriteAttributeValue("", 1374, Url.Action("Update", "User",new{id=@user.TrIdentityNumber}), 1374, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a>\r\n             </th>\r\n         </tr>\r\n");
#nullable restore
#line 49 "C:\Users\mac\Desktop\vs2022\Mustafa-Gundogdu_Final_Homework\Apartment.App\Apartment.App.Web\Views\User\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("     </tbody>\r\n </table>\r\n ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Apartment.App.Web.Models.UserViewModels.UserViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
