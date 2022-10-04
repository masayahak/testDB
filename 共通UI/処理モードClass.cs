using System.Collections.Generic;
using System.Drawing;

namespace 共通UI
{
    public static class 処理モード
    {

        // ディクショナリ
        public enum 状態
        {
            初期化 = 0,
            照会中 = 1,
            追加中 = 2,
            修正中 = 3,
        }

        public static Dictionary<状態, Color> BackColors = new Dictionary<状態, Color>()
        {
            [状態.照会中] = Color.FromArgb(192, 192, 255),
            [状態.修正中] = Color.FromArgb(3, 218, 198),
            [状態.追加中] = Color.FromArgb(55, 0, 179),
        };

        public static Dictionary<状態, Color> ForeColors = new Dictionary<状態, Color>()
        {
            [状態.照会中] = Color.FromArgb(0, 0, 0),
            [状態.修正中] = Color.FromArgb(0, 0, 0),
            [状態.追加中] = Color.FromArgb(245, 245, 245),
        };

        // ディクショナリ
        public static Dictionary<状態, string> モード名 = new Dictionary<状態, string>()
        {
            [状態.照会中] = "照会中",
            [状態.追加中] = "追加中",
            [状態.修正中] = "修正中",
        };

    }
}
