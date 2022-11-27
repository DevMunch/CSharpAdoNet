using AppConfiguration;

namespace AdoNetWindow
{
    public partial class ApplicationRoot : Form
    {
        protected ConfigurationMgr instance;
        public ApplicationRoot()
        {
            InitializeComponent();
            // 디자인 모드에서든 동작 x 런타임에서만 수행
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                instance = ConfigurationMgr.Instance();
            }
        }
    }
}