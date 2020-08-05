using UnityEngine;

public class BulletCollision : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Coll");
		Destroy(collision.gameObject);
		Destroy(gameObject);
	}
}
