using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Scripts.VisualLayer.Gameplay.Asteroids
{
    public class Asteroid : MonoBehaviour
    {
        #region Factory

        public class Factory : PlaceholderFactory<Asteroid>
        {
            
        }

        #endregion
        
        #region Injects

        [SerializeField]
        private Transform _bodyTransform;

        [SerializeField]
        private Rigidbody2D _rigidbody2D;

        #endregion

        #region Methods

        private void Start()
        {
            _rigidbody2D.AddForce(new Vector2(Random.Range(5, 10), -10) * 1000, ForceMode2D.Force);
            _rigidbody2D.AddTorque(Random.Range(2000, 10000));
        }

        #endregion
    }
}