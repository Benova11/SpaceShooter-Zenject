using Scrips.VisualLayer.Gameplay.PlayerInput;
using Zenject;

namespace Scrips.VisualLayer.Gameplay.Installers
{
    public class LevelInstaller : MonoInstaller<LevelInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<IPlayerInput>().To<PlayerKeyboardInput>().AsSingle();
        }
    }
}