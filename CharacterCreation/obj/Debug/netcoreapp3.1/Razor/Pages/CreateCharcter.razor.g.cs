#pragma checksum "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dcd5c95a505c4befb628fba66dea35f7749d911"
// <auto-generated/>
#pragma warning disable 1591
namespace CharacterCreation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using CharacterCreation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\personal\CharacterCreation\CharacterCreation\_Imports.razor"
using CharacterCreation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
using CharacterCreation.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/create-character")]
    public partial class CreateCharcter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Character Creation</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                  character

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                                             HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "label");
                __builder2.AddMarkupContent(11, "\r\n        Name\r\n        ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                      character.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => character.Name = __value, character.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "label");
                __builder2.AddMarkupContent(18, "\r\n        Class Id\r\n        ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                      character.ClassId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => character.ClassId = __value, character.ClassId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenElement(24, "label");
                __builder2.AddMarkupContent(25, "\r\n        Strength\r\n        ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                      character.Strength

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => character.Strength = __value, character.Strength));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "label");
                __builder2.AddMarkupContent(32, "\r\n        Dexterity\r\n        ");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                      character.Dexterity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => character.Dexterity = __value, character.Dexterity));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.OpenElement(38, "label");
                __builder2.AddMarkupContent(39, "\r\n        Constitution\r\n        ");
                __builder2.OpenElement(40, "input");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                      character.Constitution

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => character.Constitution = __value, character.Constitution));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenElement(45, "label");
                __builder2.AddMarkupContent(46, "\r\n        Intelligence\r\n        ");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                      character.Intelligence

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => character.Intelligence = __value, character.Intelligence));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenElement(52, "label");
                __builder2.AddMarkupContent(53, "\r\n        Spirit\r\n        ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                      character.Spirit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => character.Spirit = __value, character.Spirit));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.OpenElement(59, "label");
                __builder2.AddMarkupContent(60, "\r\n        User Id\r\n        ");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
                      character.UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => character.UserId = __value, character.UserId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n    ");
                __builder2.AddMarkupContent(66, "<button type=\"submit\">Save Character</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n\r\n\r\nWelcome to your new app.\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter.razor"
       
    private CharacterDto character = new CharacterDto();

    private async Task HandleValidSubmit()
    {
        var createdCharacter = await Http.SendJsonAsync<CharacterDto>(HttpMethod.Post, "api/characters", character);
        NavigationManager.NavigateTo($"/api/characters/{createdCharacter.Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
