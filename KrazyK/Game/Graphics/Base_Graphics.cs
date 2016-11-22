using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace KrazyK
{
	abstract public class Base_Graphics
	{
		protected Texture2D _texture;
		string _nameTexsture;
		public Vector2 position { get; private set;}

		public Base_Graphics(string NameTexsture)
		{
			_nameTexsture = NameTexsture;
		}
		public void SetPosition(Vector2 pos)
		{
			position = pos;
		}
		public void SetPosition(float x, float y) 
		{
			position = new Vector2(x, y);
		}
		public void LoadContent(ContentManager Content)
		{
			_texture = Content.Load<Texture2D>(_nameTexsture);
			if (position == null)
				position = new Vector2(0,0);
		}
		public  virtual void Draw(SpriteBatch spriteBatch)
		{ 
			spriteBatch.Draw(_texture, position);
		}
		public void Update(GameTime gameTime)
		{ 
		}
	}
}
