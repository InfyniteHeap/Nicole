using Microsoft.UI.Reactor;
using Microsoft.UI.Reactor.Core;
using static Microsoft.UI.Reactor.Factories;

ReactorApp.Run<Nicole>("Nicole");

class Nicole : Component
{
    public override Element Render()
    {
        return Border(null);
    }
}
