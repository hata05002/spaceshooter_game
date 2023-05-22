using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using System;


namespace Template{

  public class Game1:Game{
    
    private GraphicsDeviceManager graphics;
    private SpriteBatch _spriteBatch;

    Texture2D backgroundSprite;
    Texture2D playerSprite;
    Texture2D bulletSprite;
    Texture2D enemySprite;
    SpriteFont Font;
    Vector2 positionP;

   
    int PSpeed= 10;
    

    public Game1(){
      graphics= new GraphicsDeviceManager(this);
      Content.RootDirectory= "content";
positionP= new Vector2 ();
      
    }
  protected override void Initialize(){
    base.Initialize(); 
  }
protected override void LoadContent(){
  _spriteBatch= new SpriteBatch(GraphicsDevice);

  backgroundSprite = Content.Load<Texture2D>("background");
  playerSprite = Content.Load<Texture2D>("player");
  bulletSprite = Content.Load<Texture2D>("bullet");
  enemySprite = Content.Load<Texture2D> ("enemy");
  Font = Content.Load<SpriteFont>("gallery Font");
}

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            Exit();
        
        MouseState mState = Mouse.GetState();
    if (mState.LeftButton==ButtonState.Pressed){
    if(positionP.X >10){
      positionP.X=-PSpeed; 
    
    }
    }

  if (mState.RightButton==ButtonState.Pressed){
    if( positionP.X <700){
      positionP.X +=PSpeed;
    }}}

protected override void Draw(GameTime gametime){
  GraphicsDevice.Clear(Color.CornflowerBlue);
  base.Draw(gametime);
  _spriteBatch.Begin();
  
   _spriteBatch.Draw(backgroundSprite,new Vector2(0,0), Color.White);
   _spriteBatch.Draw(playerSprite, positionP , Color.White);
   _spriteBatch.Draw(bulletSprite,new Vector2(), Color.White);
   _spriteBatch.Draw(enemySprite,new Vector2(), Color.White);
   _spriteBatch.DrawString(Font,"space shooter",new Vector2(), Color.White);

  _spriteBatch.End();
}
}
}


