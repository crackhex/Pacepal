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

        public float PaddingTop => 0;
        public float PaddingBottom => 0;
        public float PaddingLeft => 0;
        public float PaddingRight => 0;
        public string ComponentName => "Pacepal Plugin";

        public IDictionary<string, Action> ContextMenuControls { get; protected set; }


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

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
        }

        public float VerticalHeight => 0;

        public float MinimumWidth => 0;

        public float HorizontalWidth => 0;

        public float MinimumHeight => 0;

        public Control GetSettingsControl(LayoutMode mode)
        {
            return null;
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            return null;
        }

        public void SetSettings(XmlNode settings)
        {
            
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            
        }

        public void Dispose()
        {
            
        }
    }

    
}
