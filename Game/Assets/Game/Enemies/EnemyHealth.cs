using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private PlayerMovement _movement;
    private bool _isImmune = false;
    private float _imuneTime = 0f;
    private float _maxImuneTime = 2f;

    private void Update()
    {
        if (_isImmune)
        {
            _imuneTime += Time.deltaTime;

            if (_imuneTime >= _maxImuneTime)
            {
                _isImmune = false;
                _imuneTime = 0;
            }
        }
    }

    public void GetHit(float health, Vector2 knockbackDir)
    {
        if (!_isImmune)
        {
            _health -= health;
            _movement.HandleKnockBack(knockbackDir);
            _isImmune = true;
        }
    }
}
