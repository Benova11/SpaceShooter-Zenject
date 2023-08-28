using Scrips.VisualLayer.Gameplay.PlayerInput;
using Scripts.VisualLayer.Gameplay.Asteroids;
using UnityEngine;
using Zenject;

namespace Scrips.VisualLayer.Gameplay.Installers
{
    public class LevelInstaller : MonoInstaller<LevelInstaller>
    {
        [SerializeField]
        private Asteroid _asteroidPrefab;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<AsteroidsSpawner>().AsSingle();
            
            Container.Bind<IPlayerInput>().To<PlayerKeyboardInput>().AsSingle();
            
            Container
                .BindFactory<Asteroid, Asteroid.Factory>()
                .FromComponentInNewPrefab(_asteroidPrefab)
                .AsSingle();
        }
    }
}