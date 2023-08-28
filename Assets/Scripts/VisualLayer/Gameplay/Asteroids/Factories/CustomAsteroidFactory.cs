using UnityEngine;
using Zenject;

namespace Scripts.VisualLayer.Gameplay.Asteroids.Factories
{
    public class CustomAsteroidFactory : IFactory<Vector2,Asteroid>
    {
        private readonly DiContainer _container;
        private readonly Asteroid[] _asteroidsPrefabs;

        public CustomAsteroidFactory(DiContainer container, Asteroid[] asteroidsPrefabs)
        {
            _container = container;
            _asteroidsPrefabs = asteroidsPrefabs;
        }
        
        public Asteroid Create(Vector2 param)
        {
            var asteroidIndex = Random.Range(0, _asteroidsPrefabs.Length);
            return _container.InstantiatePrefabForComponent<Asteroid>(_asteroidsPrefabs[asteroidIndex]);
        }
    }
}