using MaterialSkin;
using MaterialSkin.Controls;
using TdInterface.Properties;

namespace TdInterface.Forms
{
    public partial class EZTMBaseForm : MaterialForm
    {
        public EZTMBaseForm()
        {
            InitializeComponent();

            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            msm.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE);


            // Set the App Logo
            this.Icon = Resources.logo;
        }
    }
}
