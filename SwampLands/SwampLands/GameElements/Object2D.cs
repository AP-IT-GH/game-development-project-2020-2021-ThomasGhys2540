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
#endregion


namespace SwampLands
{
    public abstract class Object2D
    {
        #region Abstract Methods
        public abstract void Draw(GameTime gameTime);
        public abstract void Update(GameTime gameTime);
        #endregion
    }
}
