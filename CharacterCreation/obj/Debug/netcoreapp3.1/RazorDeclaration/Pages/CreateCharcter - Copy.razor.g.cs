#pragma checksum "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08d4039573e91f90dfded4538e7262a6c7d50930"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter - Copy.razor"
using CharacterCreation.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/create-character")]
    public partial class CreateCharcter___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\dev\personal\CharacterCreation\CharacterCreation\Pages\CreateCharcter - Copy.razor"
       
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
