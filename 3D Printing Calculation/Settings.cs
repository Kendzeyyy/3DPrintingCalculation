using System.Windows.Forms;

namespace _3D_Printing_Calculation
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            CheckPreviousValues();
        }

        private decimal profitMargin, workEffort, startingPrice, postProcessing;

        public void DefaultSettingsValues()
        {
            // Set default values from input fields to property
            Properties.Settings.Default.ProfitMargin = profitMargin;
            Properties.Settings.Default.WorkEffort = workEffort;
            Properties.Settings.Default.StartingPrice = startingPrice;
            Properties.Settings.Default.PostProcessing = postProcessing;
        }

        private void CheckPreviousValues()
        {
            // Save values to global variables
            profitMargin = upDownProfitMargin.Value;
            workEffort = upDownWorkEffort.Value;
            startingPrice = upDownStartingPrice.Value;
            postProcessing = upDownPostProcessing.Value;

            // Set values to input fields
            upDownProfitMargin.Value = Properties.Settings.Default.ProfitMargin;
            upDownWorkEffort.Value = Properties.Settings.Default.WorkEffort;
            upDownStartingPrice.Value = Properties.Settings.Default.StartingPrice;
            upDownPostProcessing.Value = Properties.Settings.Default.PostProcessing;
        }

        private void SaveSettings()
        {
            // Save input fields values to property
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
