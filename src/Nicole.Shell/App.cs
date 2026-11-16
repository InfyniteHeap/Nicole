using Microsoft.UI.Reactor;
using Microsoft.UI.Reactor.Core;
using static Microsoft.UI.Reactor.Factories;

ReactorApp.Run<App>("Nicole");

class App : Component
{
    public override Element Render()
    {
        return Empty();
    }
}
