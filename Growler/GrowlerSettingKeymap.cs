﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GrowlToToast.Growler
{
    static class GrowlerSettingKeymap
    {
        private static readonly IDictionary<GrowlerSetting, string> GrowlerSettingKeys = new Dictionary<GrowlerSetting, string>
        {
            { GrowlerSetting.Silent, "silent" },
            { GrowlerSetting.IgnoreClose, "ignore_close" },
            { GrowlerSetting.ShowAppName, "show_app_name" }
        };

        public static string GetKey(GrowlerSetting setting)
        {
            return GrowlerSettingKeys[setting];
        }
    }
}
