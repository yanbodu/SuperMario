﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SuperMario.SpriteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario.Sprites
{
    class IdleLeftStarBigMarioSprite : MarioStarSprite
    {
        private int TextureX = (int)MarioSpriteFactory.Instance.IdleLeftStarBigMarioCord.X;
        private int TextureY = (int)MarioSpriteFactory.Instance.IdleLeftStarBigMarioCord.Y;

        public IdleLeftStarBigMarioSprite(Texture2D texture) : base(texture)
        {
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 marioLocation)
        {
            int x = TextureX * MarioWidth;
            int y = (TextureY + currentFlashingFrame) * MarioHeight;
            int width = SourceRectangle.Width;
            int height = SourceRectangle.Height;
            SourceRectangle = new Rectangle(x, y, width, height);
            base.Draw(spriteBatch, marioLocation);
        }
    }
}
