using Scrips.VisualLayer.Gameplay.PlayerInput;
using Scripts.VisualLayer.Gameplay.Asteroids;
using Scripts.VisualLayer.Gameplay.Asteroids.Factories;
using UnityEngine;
using Zenject;

namespace Scrips.VisualLayer.Gameplay.Installers
{
    public class LevelInstaller : MonoInstaller<LevelInstaller>
    {
        [SerializeField]
        private Asteroid[] _asteroidPrefab;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<AsteroidsSpawner>().AsSingle();
            
            Container.BindInstances(_asteroidPrefab);
            
            Container.Bind<IPlayerInput>().To<PlayerKeyboardInput>().AsSingle();
            
            Container.BindFactory<Vector2,Asteroid, Asteroid.AsteroidFactory>().FromFactory<CustomAsteroidFactory>();
        }
    }
}