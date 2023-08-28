using Scrips.VisualLayer.Gameplay.PlayerInput;
using UnityEngine;
using Zenject;

namespace Scrips.VisualLayer.Components
{
    public class PlayerAccelerationInputDriven : MonoBehaviour
    {
        #region Injects

        [Inject]
        private IPlayerInput _playerInput;
        
        [Inject]
        private Transform _starshipTransform;
        
        [Inject]
        private Rigidbody2D _starshipRigidbody2D;


        #endregion

        #region Methods

        private void FixedUpdate()
        {
            Accelerate();
        }

        private void Accelerate()
        {
            Vector2 forwardDirection = _starshipTransform.up;
            
            _starshipRigidbody2D.velocity = forwardDirection * _playerInput.AccelerationFactor * (500 * Time.deltaTime);
        }

        #endregion
    }
}