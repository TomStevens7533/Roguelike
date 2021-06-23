using UnityEngine;
[CreateAssetMenu(fileName = "New Attachment",menuName = "Inventory/Attachments")]
public class WeaponAttachments : Item
{
    [SerializeField] private float _damage;
    [SerializeField] private float _range;
    [SerializeField] private float _fireRate;
    [SerializeField] private float _bulletSpeed;

    public override void Use()
    {
        Debug.Log("using " + name);
       var primaryWeapon = FindObjectOfType<PrimaryWeapon>();
       primaryWeapon.AdjustDamage(_damage);
       primaryWeapon.AdjustFirerate(_fireRate);
       primaryWeapon.AdjustRange(_range);
       primaryWeapon.AdjustSpeed(_bulletSpeed);
       base.Use();
    }

    public override void OnClear()
    {
        Debug.Log("Clearing " + name);
        var primaryWeapon = FindObjectOfType<PrimaryWeapon>();
        primaryWeapon.AdjustDamage(-_damage);
        primaryWeapon.AdjustFirerate(-_fireRate);
        primaryWeapon.AdjustRange(-_range);
        primaryWeapon.AdjustSpeed(-_bulletSpeed);
        base.Use();
    }
}
