public class RegularBullet : Bullet
{
    protected override void Shoot()
    {
        _rigidBody.velocity = _direction * _speed;
    }
}
