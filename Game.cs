using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;

namespace Nirdala.GameOff2016 {

    public class Game : Core {

        const int WIDTH = 1348;
        const int HEIGHT = 900;
        const int BLEED_X = 148;
        const int BLEED_Y = 140;
        const float RATIO = (float)WIDTH / HEIGHT;

        public Game() : base(windowTitle: "Game Off 2016") {

            int width, height;

            if (Screen.monitorWidth > Screen.monitorHeight) {
                width = MathHelper.Min(WIDTH, (int)(Screen.monitorWidth * 0.75));
                height = (int)(width / RATIO);
            } else {
                height = MathHelper.Min(HEIGHT, (int)(Screen.monitorHeight * 0.75));
                width = (int)(height * RATIO);
            }

            Screen.preferredBackBufferWidth = width;
            Screen.preferredBackBufferHeight = height;
        }
        
        protected override void Initialize() {
            base.Initialize();

            Window.AllowUserResizing = true;
            Core.defaultSamplerState = SamplerState.LinearClamp;

            Scene.setDefaultDesignResolution(WIDTH, HEIGHT, Scene.SceneResolutionPolicy.BestFit, BLEED_X, BLEED_Y);

            Core.scene = Scene.createWithDefaultRenderer(Color.Black);
        }
    }
}
