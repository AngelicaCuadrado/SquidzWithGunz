using UnityEngine;

public abstract class FireStrategy : ScriptableObject
{
    public abstract void FireLocal(WeaponData data, Transform firePoint, GameObject owner);
    public abstract void FireAuthoritative(WeaponData data, Transform firePoint, GameObject owner);
}
