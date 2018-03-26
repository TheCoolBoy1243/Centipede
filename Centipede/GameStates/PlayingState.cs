using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlayingState : GameObjectList
{
    public GameObjectList bullets;
    public Player player;

    public PlayingState()
    {
        player = new Player();
        bullets = new GameObjectList();
        this.Add(new SpriteGameObject("spr_background"));
        this.Add(bullets);
        this.Add(player);
    }

    public override void HandleInput(InputHelper inputHelper)
    {
        base.HandleInput(inputHelper);
        if (inputHelper.KeyPressed(Keys.Space))
        {
            bullets.Add(new Bullet(player.Position));
        }
    }
}

