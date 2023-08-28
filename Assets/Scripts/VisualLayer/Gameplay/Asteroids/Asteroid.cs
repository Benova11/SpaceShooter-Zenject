using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Scripts.VisualLayer.Gameplay.Asteroids
{
    public class Asteroid : MonoBehaviour
    {
        #region Factory

        public class Factory : PlaceholderFactory<Vector2 ,Asteroid>
        {
            
        }

        #endregion
        
        #region Editor

        [SerializeField]
        private Transform _bodyTransform;

        [SerializeField]
        private Rigidbody2D _rigidbody2D;

        #endregion
        
        #region Fields

        private Vector2 _launchingPosition;
        
        #endregion

        #region Methods

        [Inject]
        private void Construct(Vector2 launchingPosition)
        {
            _launchingPosition = launchingPosition;
        }
        
        private void Start()
        {
            _rigidbody2D.transform.position = _launchingPosition;
            _rigidbody2D.AddForce(new Vector2(Random.Range(5, 10), -10) * 1000, ForceMode2D.Force);
            _rigidbody2D.AddTorque(Random.Range(2000, 10000));
        }

        #endregion
    }
}