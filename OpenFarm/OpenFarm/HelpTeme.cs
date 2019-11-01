using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Help
{
   public class HelpTeme
    {
        public void InicializarTema(MaterialSkin.Controls.MaterialForm fmr)
        {
            var skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(fmr);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(
                   MaterialSkin.Primary.LightBlue500,
                  MaterialSkin.Primary.LightBlue700,
                 MaterialSkin.Primary.Amber600,
                 MaterialSkin.Accent.Blue200,
                MaterialSkin.TextShade.WHITE
                );
        }
    }
}
