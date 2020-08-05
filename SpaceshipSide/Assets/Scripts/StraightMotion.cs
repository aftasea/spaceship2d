using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMotion : MonoBehaviour
{
	[SerializeField]
	private float speed = 1f;

	private Transform myTransform;
	private Renderer myRenderer;
	public Vector3 Direction
	{
		set;
		get;
	}

	private void Awake()
	{
		myTransform = transform;

		myRenderer = GetComponentInChildren<Renderer>();
	}

	void Update()
    {
		myTransform.position += Direction * speed * Time.deltaTime;

		if (!ScreenUtils.IsInsideScreen(myRenderer.bounds))
			Destroy(gameObject);
    }
}
