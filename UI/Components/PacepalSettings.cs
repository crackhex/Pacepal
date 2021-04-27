using System.Xml;
using System.Windows.Forms;

namespace Livesplit.UI.Components
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
    }
}
