using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileFireStrategy", menuName = "FiringStrategies/ProjectileFireStrategy")]
public class ProjectileFireStrategy : FireStrategy
{
	public override void FireAuthoritative(WeaponData data, Transform firePoint, GameObject owner)
	{
		
	}

	public override void FireLocal(WeaponData data, Transform firePoint, GameObject owner)
	{
		//Nothing for now. will be used for visual feedback.
	}
}
