﻿using System;
using System.Collections.Generic;

namespace ManagedDoom
{
    public abstract class MenuDef
    {
        private DoomMenu menu;

        public MenuDef(DoomMenu menu)
        {
            this.menu = menu;
        }

        public abstract bool DoEvent(DoomEvent e);

        public DoomMenu Menu => menu;
    }
}
