using UnityEngine;

public class Attacker : MonoBehaviour
{
	[SerializeField] private GameObject _attackCollider;

	public void EnableWeapon()
	{
		_attackCollider.SetActive(true);
	}

	public void DisableWeapon()
	{
		_attackCollider.SetActive(false);

		//Empty lines 2


	}

	//Empty lines 1

	public void TestNamingConvention(UpperParameterName)
	{
		var a = UpperParameterName;
		var B = 10;

		//Empty lines 3


	}

}
