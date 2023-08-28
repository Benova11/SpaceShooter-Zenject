using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Scripts.VisualLayer.Gameplay.Asteroids
{
    public class AsteroidsSpawner : IInitializable
    {
        [Inject]
        private Asteroid.AsteroidFactory _asteroidFactory;
        
        public async void Initialize()
        {
            for (int i = 0; i < 30; i++)
            {
                
                await UniTask.Delay(1000);
                var ast = _asteroidFactory.Create(new Vector2(Random.Range(-13,0) , 8 ));
            }
        }
    }
}