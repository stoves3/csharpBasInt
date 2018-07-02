using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stoves3.basInt.csharp.core
{
    public class Keyboard : IInput
    {
        private readonly IUI _ui;

        public Keyboard(IUI ui)
        {
            _ui = ui;
        }

        public string INKEYṨ(IScreen screen)
        {
            return _ui.GetChar();
        }

        public string Input(IScreen screen)
        {
            return _ui.GetInput();
        }
    }
}
