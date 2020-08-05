using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
	[SerializeField]
	private float damage = 1f;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
		{
			Health playerHealth = collision.GetComponent<Health>();
			playerHealth.TakeDamage(damage);
		}
	}
}

