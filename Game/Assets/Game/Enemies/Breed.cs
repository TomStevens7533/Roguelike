using UnityEngine;
public class Breed : MonoBehaviour
{
    public enum States
    {
        patrol,
        attack
    }
    #region constructors
    public Breed()
    {
        _health = 0;
        _damage = 0;
    }
   public Breed(float health, float damage)
    {
        _health = health;
        _damage = damage;
    }
    #endregion

    #region variables
    private States _movementState = States.patrol;
    public States MovementState
    {
        get { return _movementState; }
        set { _movementState = value; }
    }
    private float _health;
    public float Health
    {
        get { return _health; }
        set { _health = value;}
    }

    private float _damage;
    public float Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    private Transform _playerTransform;
    public Transform PlayerTransform
    {
        get { return _playerTransform; }
        set { _playerTransform = value; }
    }

    private Transform _monsterTransform;
    public Transform MonsterTransform
    {
        get { return _monsterTransform; }
        set { _monsterTransform = value; }
    }

    private Rigidbody2D _rigidbody;
    public Rigidbody2D Rigidbody
    {
        get { return _rigidbody; }
        set { _rigidbody = value; }
    }

    #endregion

    virtual public void UpdateBehavior()
    {
        //needs to be implemented
    }
    virtual protected void Attack()
    {
        //needs to be implemented
    }

    virtual protected void Move()
    {
        //needs to be implemented
    }

    virtual public void OnPlayerHit(GameObject g)
    {
        //needs to be implemented
    }
}