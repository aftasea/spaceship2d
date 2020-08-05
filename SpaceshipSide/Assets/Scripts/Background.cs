using System.Collections;
using UnityEngine;

public class Background : MonoBehaviour
{
	[SerializeField]
	private float speed = -1f;

	private SpriteRenderer spriteRenderer;
	private Material _material;

	private float currentscroll;

	private void Awake()
	{
		var meshRenderer = GetComponent<MeshRenderer>();
		_material = meshRenderer.material;
		//spriteRenderer = GetComponent<SpriteRenderer>();
		//_material = spriteRenderer.material;

		//Space.Screen screen = new Space.Screen();
		//spriteRenderer.size = new Vector2(screen.Width, screen.Height);
	}

	void Update()
	{
		currentscroll += speed * Time.deltaTime;
		_material.mainTextureOffset = new Vector2(currentscroll, 0);
	}
}
