using UnityEngine;
using Zenject;

namespace Scrips.VisualLayer.Starship
{
    public class PlayerStarship : MonoBehaviour
    {
        [Inject]
        private Rigidbody2D _rigidbody2D;
        
        [Inject]
        private Transform _transform;
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            // Destroy(gameObject);
        }
    }
}