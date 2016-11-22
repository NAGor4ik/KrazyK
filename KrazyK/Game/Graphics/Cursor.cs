using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace KrazyK
{
	public class Cursor:Base_Graphics
	{
		
		public Cursor():base("cursor")
		{
		}
		public override void Draw(SpriteBatch spriteBatch)

		{
			SetPosition(Mouse.GetState().X-17, Mouse.GetState().Y-5);
			spriteBatch.Draw(_texture, base.position,null,null,null,0f, new Vector2(0.12f,0.1f),null,0.0f);
		}
	}
}
