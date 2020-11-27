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
    class CollisionDetection
    {
        #region Variables
        private float Offset = 30;
        #endregion

        #region Methods
        #region Is there a collision
        #region Left
        public Boolean HasCollidedLeft()
        {
            foreach (Platform platform in Globals.WorldSystem.WorldObjects)
            {
                if (Globals.WorldSystem.PlayerCharacter.Hitbox.Intersects(platform.HitBox))
                {
                    if (Globals.WorldSystem.PlayerCharacter.Hitbox.Top > platform.HitBox.Top  - Offset &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Bottom < platform.HitBox.Bottom + Offset &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Left < platform.HitBox.Right &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Right > platform.HitBox.Right)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion

        #region Right
        public Boolean HasCollidedRight()
        {
            foreach (Platform platform in Globals.WorldSystem.WorldObjects)
            {
                if (Globals.WorldSystem.PlayerCharacter.Hitbox.Intersects(platform.HitBox))
                {
                    if (Globals.WorldSystem.PlayerCharacter.Hitbox.Top > platform.HitBox.Top - Offset &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Bottom < platform.HitBox.Bottom + Offset &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Left < platform.HitBox.Left &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Right > platform.HitBox.Left)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion

        #region Bottom
        public Boolean HasCollidedBottom()
        {
            foreach (Platform platform in Globals.WorldSystem.WorldObjects)
            {
                if (Globals.WorldSystem.PlayerCharacter.Hitbox.Intersects(platform.HitBox))
                {
                    if (Globals.WorldSystem.PlayerCharacter.Hitbox.Top < platform.HitBox.Top &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Bottom > platform.HitBox.Top &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Left > platform.HitBox.Left - Offset &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Right < platform.HitBox.Right + Offset)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion

        #region Top
        public Boolean HasCollidedTop()
        {
            foreach (Platform platform in Globals.WorldSystem.WorldObjects)
            {
                if (Globals.WorldSystem.PlayerCharacter.Hitbox.Intersects(platform.HitBox))
                {
                    if (Globals.WorldSystem.PlayerCharacter.Hitbox.Top < platform.HitBox.Bottom &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Bottom > platform.HitBox.Bottom &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Left > platform.HitBox.Left - Offset &&
                        Globals.WorldSystem.PlayerCharacter.Hitbox.Right < platform.HitBox.Right + Offset)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion
        #endregion


        #endregion
    }
}