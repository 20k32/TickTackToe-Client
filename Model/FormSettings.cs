using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Model
{
    internal sealed class FormSettings
    {
        public readonly PaletteMode PaletteMode;
        public readonly KryptonFormTitleStyle TitleStyle;
        public readonly PaletteRelativeAlign PaletteRelativeAlign;

        public FormSettings(PaletteMode paletteMode, KryptonFormTitleStyle titleStyle, PaletteRelativeAlign paletteRelativeAlign)
        {
            PaletteMode = paletteMode;
            TitleStyle = titleStyle;
            PaletteRelativeAlign = paletteRelativeAlign;
        }
    }
}
