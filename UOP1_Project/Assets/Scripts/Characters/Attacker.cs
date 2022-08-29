using System.Globalization;
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


		//Blank lines #3


	}

	public void TestingNames(UpperCaseForParameter)
	{

		var B = 10;

		const day = "Monday";

		//Blank Lines #3


	}

	public enum TestEnum
	{
		Idle = 0,
		Walk,
		Talk
	};



	//Blank lines #2


}
