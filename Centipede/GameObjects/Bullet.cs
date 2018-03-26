using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bullet : SpriteGameObject
{
    public Bullet(Vector2 position) : base("spr_bullet")
    {
        origin = Center;
        this.position = position;
        this.position.Y -= 20;
        this.velocity = new Vector2(0 , -200);

    }
}

