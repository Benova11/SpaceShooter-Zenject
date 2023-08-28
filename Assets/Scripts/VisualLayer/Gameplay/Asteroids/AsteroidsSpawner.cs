using Cysharp.Threading.Tasks;
using Zenject;

namespace Scripts.VisualLayer.Gameplay.Asteroids
{
    public class AsteroidsSpawner : IInitializable
    {
        [Inject]
        private Asteroid.Factory _factory;
        
        public async void Initialize()
        {
            for (int i = 0; i < 5; i++)
            {
                await UniTask.Delay(1000);
                var ast = _factory.Create();
            }
        }
    }
}