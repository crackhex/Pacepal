using System.Xml;
using System.Windows.Forms;

namespace LiveSplit.UI.Components
{
    public partial class PacepalSettings : UserControl
    {
        public bool UseSegmentTimes { get; set; }
        public PacepalSettings()
        {
            InitializeComponent();

        }
        public void SetSettings(XmlNode node)
        {
            
        }
        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.4") ^
            SettingsHelper.CreateSetting(document, parent, "UseSegmentTimes", UseSegmentTimes);
        }
    }
}
