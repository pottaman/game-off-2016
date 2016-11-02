using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;

namespace Nirdala.GameOff2016 {

    public class Game : Core {

        public Game() : base(windowTitle: "Game Off 2016") {
        }

        protected override void Initialize() {
            base.Initialize();

            Window.AllowUserResizing = true;
            Core.defaultSamplerState = SamplerState.LinearClamp;

            Scene.setDefaultDesignResolution(1348, 900, Scene.SceneResolutionPolicy.NoBorder);

            Core.scene = Scene.createWithDefaultRenderer(Color.Black);
        }
    }
}
