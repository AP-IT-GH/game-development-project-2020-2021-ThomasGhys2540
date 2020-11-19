﻿#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using GameDev.Source.Engine.Input;
#endregion

namespace GameDev.Source.Engine
{
    public class Globals
    {
        //Loads in images
        public static ContentManager contentManager;
        
        //Helps draw the images
        public static SpriteBatch spriteBatch;

        //Keyboard
        public static InputKeyboard keyboard;
    }
}