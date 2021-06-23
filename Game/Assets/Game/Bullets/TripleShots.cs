using UnityEngine;

public class TripleShots : Bullet
{
    [SerializeReference] protected Rigidbody2D _rigidBodyUp;
    [SerializeReference] protected Rigidbody2D _rigidBodyDown;

    protected override void Shoot()
    {
        _rigidBodyUp.velocity = _direction * _speed;
        _rigidBodyDown.velocity = _direction * _speed;
        _rigidBody.velocity = _direction * _speed;
    }
}
