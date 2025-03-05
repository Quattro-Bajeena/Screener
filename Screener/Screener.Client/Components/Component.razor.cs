using Microsoft.AspNetCore.Components;

namespace Screener.Client.Components;

public partial class Component : ComponentBase
{
    private string testString = "hej";

    protected async override Task OnInitializedAsync()
    {
        testString = "cześć";
    }

    protected void ThrowException()
    {
        throw new Exception ( "DAmn" );
    }
}
