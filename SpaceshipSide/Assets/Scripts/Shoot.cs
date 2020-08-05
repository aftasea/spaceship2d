using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	[SerializeField]
	private GameObject bullet = null;
	[SerializeField]
	private Transform bullets = null;
	[SerializeField]
	private Transform cannon = null;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Z))
			CreateShot();
	}

	private void CreateShot()
	{
		var go = Instantiate(bullet, cannon.position, Quaternion.identity, bullets);
		var motion = go.GetComponent<StraightMotion>();
		motion.Direction = Vector3.right;
	}
}
