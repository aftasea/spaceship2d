using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	[SerializeField]
	private GameObject enemy = null;
	[SerializeField]
	private float spawnInterval = 1f;

	private Transform myTransform;
	private float remainingTimeToSpawn;

	private void Awake()
	{
		remainingTimeToSpawn = spawnInterval;
		myTransform = transform;
	}

	private void Update()
	{
		remainingTimeToSpawn -= Time.deltaTime;

		if (remainingTimeToSpawn <= 0)
		{
			Spawn();
			remainingTimeToSpawn += spawnInterval;
		}
	}

	private void Spawn()
	{
		Vector3 pos = new Vector3(
			ScreenUtils.Right,
			Random.Range(ScreenUtils.Bottom, ScreenUtils.Top)
		);
		var go = Instantiate(enemy, pos, Quaternion.identity, myTransform);
		var motion = go.GetComponent<StraightMotion>();
		motion.Direction = Vector3.left;
	}
}
