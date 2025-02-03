using sprint0.Sprites;

namespace sprint0.Controllers
{
    internal interface IController
    {
        public void HandleInput(ref ISprite currentSprite);
    }
}
