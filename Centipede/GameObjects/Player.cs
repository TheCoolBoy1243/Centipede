using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player : SpriteGameObject
{
    public Player() : base("spr_player")
    {
        Mouse.SetPosition(235, 500);
        origin = Center;
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        position = inputHelper.MousePosition;
    }

    public override void Update(GameTime gameTime)
    {
        
    }
}

