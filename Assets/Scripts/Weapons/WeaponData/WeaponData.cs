using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "Weapons/WeaponData")]
public class WeaponData : ScriptableObject
{
    [Header("Core Stats")]
    public float damage;
    public float projectileSpeed;
    public GameObject projectilePrefab;
    public int ammoMax;
    public float force;
    public float turnRateModifier;


    [Header("Behaviour")]
	public FireStrategy fireStrategy;


}
