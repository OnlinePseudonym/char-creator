#pragma checksum "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\Character.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f84c0f19dcad4b8a124ad6f0a661ec805af54cf"
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
#line 2 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\Character.razor"
using CharacterCreation.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/character/{Id:int}")]
    public partial class Character : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Character</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\Character.razor"
      character.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\Character.razor"
       
    [Parameter]
    public int Id { get; set; }
    CharacterDto character { get; set; } = new CharacterDto();

    protected override async Task OnInitializedAsync()
    {
        character = await Http.GetJsonAsync<CharacterDto>($"api/characters/{Id}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
