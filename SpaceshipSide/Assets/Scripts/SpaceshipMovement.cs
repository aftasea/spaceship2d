using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
	[SerializeField]
	private float speed = 1f;

	private Transform myTransform;
	private Vector2 dir;
	private float halfShipWidht;
	private float halfShipHeight;

	private void Awake()
	{
		myTransform = transform;
		CalcShipDimensions();
	}

	void Update()
    {
		UpdateDirection();
		Move();
	}

	private void CalcShipDimensions()
	{
		var ren = GetComponentInChildren<Renderer>();
		halfShipWidht = ren.bounds.extents.x;
		halfShipHeight = ren.bounds.extents.y;
	}

	private void UpdateDirection()
	{
		dir = Vector2.zero;

		if (Input.GetKey(KeyCode.LeftArrow))
			dir.x -= 1;
		if (Input.GetKey(KeyCode.RightArrow))
			dir.x += 1;
		if (Input.GetKey(KeyCode.UpArrow))
			dir.y += 1;
		if (Input.GetKey(KeyCode.DownArrow))
			dir.y -= 1;
	}

	private void Move()
	{
		if (dir != Vector2.zero)
		{
			Vector3 vel = dir.normalized * speed * Time.deltaTime;
			Vector3 destPos = myTransform.position + vel;

			ClampIntoScreenBounds(ref destPos);

			myTransform.position = destPos;
		}
	}

	private void ClampIntoScreenBounds(ref Vector3 pos)
	{
		pos.x = Mathf.Clamp(pos.x, ScreenUtils.Left + halfShipWidht, ScreenUtils.Right - halfShipWidht);
		pos.y = Mathf.Clamp(pos.y, ScreenUtils.Bottom + halfShipHeight, ScreenUtils.Top - halfShipHeight);
	}
}
