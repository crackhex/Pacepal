using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;

[assembly: ComponentFactory(typeof(PacepalFactory))]

namespace LiveSplit.UI.Components
{
    public class PacepalFactory : IComponentFactory
    {
        public string ComponentName => "Pacepal Plugin";

        public string Description => "Determines if you are pacing, and announces it to discord/twitter";

        public ComponentCategory Category => ComponentCategory.Control;

        public IComponent Create(LiveSplitState state) => new PacepalComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.Pacepal.xml";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("1.0.0");
    }
}