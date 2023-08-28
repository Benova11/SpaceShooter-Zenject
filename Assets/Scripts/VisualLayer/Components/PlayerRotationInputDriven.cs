using Scrips.VisualLayer.Gameplay.PlayerInput;
using UnityEngine;
using Zenject;

namespace Scrips.VisualLayer.Components
{
    public class PlayerRotationInputDriven : MonoBehaviour
    {
        #region Injects

        [Inject]
        private IPlayerInput _playerInput;

        [Inject]
        private Transform _starshipTransform;

        #endregion

        #region Methods

        private void FixedUpdate()
        {
            Rotate();
        }

        private void Rotate()
        {
            _starshipTransform.Rotate(new Vector3(0, 0, 1), -_playerInput.RotationFactor * Time.deltaTime * 200);
        }

        #endregion
    }
}