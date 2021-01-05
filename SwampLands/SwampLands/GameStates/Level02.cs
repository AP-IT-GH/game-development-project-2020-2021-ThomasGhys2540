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
    class Level02 : State
    {
        #region Variables
        private List<Platform> Platforms;
        #endregion

        #region Constructors
        public Level02(MainGame main, GraphicsDevice graphicsDevice) : base(main, graphicsDevice)
        {
            #region Initialise Variables
            Platforms = new List<Platform>();
            #endregion

            #region Creating World Platforms
            Platforms.Add(new Platform(new Vector2(0, 800), 30, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(0, 500), 7, Rotation.Vertical));
            Platforms.Add(new Platform(new Vector2(1000, 750), 10, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1050, 700), 9, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1100, 650), 8, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1150, 600), 7, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1200, 550), 6, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1250, 500), 5, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1300, 450), 4, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1350, 400), 3, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1400, 350), 2, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(1450, 300), 1, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(2200, 600), 2, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(2700, 800), 10, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(2950, 650), 8, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(3050, 500), 8, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(2950, 350), 8, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(3050, 200), 8, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(4600, 800), 2, Rotation.Horizontal));
            Platforms.Add(new Platform(new Vector2(6000, 800), 3, Rotation.Horizontal));

            #endregion

            Globals.WorldSystem = new World(Platforms, new Vector2(6050, 750));
            Globals.Level = Levels.level02;
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