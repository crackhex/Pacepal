using LiveSplit.Model;
using LiveSplit.TimeFormatters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public class PacepalComponent : IComponent
    {

        public PacepalSettings Settings { get; set; }

        protected LiveSplitState State { get; set; }
        protected Form Form { get; set; }
        protected TimerModel Model { get; set; }
        protected ITimeFormatter DeltaFormatter { get; set; }
        protected ITimeFormatter SplitTimeFormatter { get; set; }

        public string ComponentName => "Pacepal Plugin";

        public IDictionary<string, Action> ContextMenuControls { get; protected set; }

        public float HorizontalWidth => throw new NotImplementedException();

        public float MinimumHeight => throw new NotImplementedException();

        public float VerticalHeight => throw new NotImplementedException();

        public float MinimumWidth => throw new NotImplementedException();

        public float PaddingTop => throw new NotImplementedException();

        public float PaddingBottom => throw new NotImplementedException();

        public float PaddingLeft => throw new NotImplementedException();

        public float PaddingRight => throw new NotImplementedException();

        public PacepalComponent(LiveSplitState state)
        {
            Settings = new PacepalSettings();
            Model = new TimerModel();

            ContextMenuControls = new Dictionary<string, Action>();
            ContextMenuControls.Add("Start Pacing", Start);



        }

        public void Start()
        {

            ContextMenuControls.Clear();
            ContextMenuControls.Add("Stop Pacing", Stop);
        }

        public void Stop()
        {
            ContextMenuControls.Clear();
            ContextMenuControls.Add("Start Pacing", Start);
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            throw new NotImplementedException();
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            throw new NotImplementedException();
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            throw new NotImplementedException();
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            throw new NotImplementedException();
        }

        public void SetSettings(XmlNode settings)
        {
            throw new NotImplementedException();
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    }
}
