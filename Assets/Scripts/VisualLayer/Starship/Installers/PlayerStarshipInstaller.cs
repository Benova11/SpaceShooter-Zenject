using UnityEngine;
using Zenject;

namespace Scrips.VisualLayer.Starship.Installers
{
    public class PlayerStarshipInstaller : MonoInstaller<PlayerStarshipInstaller>
    {
        [SerializeField]
        private Transform _starShipTransform;

        [SerializeField]
        private Rigidbody2D _starShipRigidbody2D;
        
        public override void InstallBindings()
        {
            Container.Bind<Transform>().FromInstance(_starShipTransform);
            Container.Bind<Rigidbody2D>().FromInstance(_starShipRigidbody2D);
        }
    }
}