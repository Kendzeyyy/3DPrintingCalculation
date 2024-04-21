using System.Windows.Forms;

namespace _3D_Printing_Calculation
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.ProfitMargin = upDownProfitMargin.Value;
            Properties.Settings.Default.WorkEffort = upDownWorkEffort.Value;
            Properties.Settings.Default.StartingPrice = upDownStartingPrice.Value;
            Properties.Settings.Default.PostProcessing = upDownPostProcessing.Value;
            Properties.Settings.Default.Save();
        }

        private void btnSettingsSave_Click(object sender, System.EventArgs e)
        {
            SaveSettings();
            this.Close();
        }
    }
}
