using Smod2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOC
{
    public class GOC : Plugin
    {

        public static Random rand = new Random();

        public override void OnDisable()
        {

        }

        public override void OnEnable()
        {

        }

        public override void Register()
        {
            this.AddConfig(new Smod2.Config.ConfigSetting("goc_chance", 50, Smod2.Config.SettingType.NUMERIC, true, "Percent chance for the GOC to spawn."));
            this.AddConfig(new Smod2.Config.ConfigSetting("goc_hp", 200, Smod2.Config.SettingType.NUMERIC, true, "The HP for the GOC."));
            this.AddConfig(new Smod2.Config.ConfigSetting("goc_items", new[]
            {
                20,
                25,
                12,
                16,
                8,
                14
            }, Smod2.Config.SettingType.NUMERIC_LIST, true, "The items they get."));
        }
    }
}
