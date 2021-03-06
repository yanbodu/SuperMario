﻿using SuperMario.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SuperMario.Enums;
namespace SuperMario.Interfaces 
{
    public interface IMario: IGameObject
    {
        IMarioState State { get; set; }
        bool IsProtected { get; set; }
        bool IsInAir { get; set; }
        Shape PreStarShape { get; set; }
        Vector2 Velocity { get; set; }
        Vector2 Acceleration { get; set; }
        float maxSpeed { get; set; }
       
    }
}
