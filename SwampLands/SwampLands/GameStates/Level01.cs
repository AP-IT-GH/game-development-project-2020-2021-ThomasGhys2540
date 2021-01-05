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
    class Level01 : State
    {
        #region Variables
        private List<Platform> Platforms;
        #endregion

        #region Constructors
        public Level01(MainGame main, GraphicsDevice graphicsDevice) : base(main, graphicsDevice)
        {
            #region Initialise Variables
            Platforms = new List<Platform>();
            #endregion

            #region Creating World Platforms
            Platforms.Add(new Platform(new Vector2(0, 800), 30, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(0, 500), 7, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(450, 750), 3, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(900, 750), 6, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(900, 700), 3, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1600, 650), 3, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(1900, 100), 10, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(1950, 100), 10, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(2000, 100), 10, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(2050, 100), 10, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(2000, 800), 2, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(2600, 800), 6, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(2300, 650), 4, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(2750, 450), 4, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(3000, 675), 2, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(3250, 534), 3, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(2250, 333), 3, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(2450, 180), 1, Rotation.Vertical));
            #endregion

            Globals.WorldSystem = new World(Platforms, new Vector2(1950, 50));
            Globals.Level = Levels.level01;
        }
        #endregion

        #region Draw
        public override void Draw(GameTime gameTime)
        {
            Globals.WorldSystem.Draw(gameTime);
        }
        #endregion

        #region Update
        public override void Update(GameTime gameTime)
        {
            Globals.WorldSystem.Update(gameTime);
        }
        #endregion
    }
}
