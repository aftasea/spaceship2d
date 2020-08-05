using UnityEngine;

public class ScreenUtils
{
	public static float Width
	{
		get;
		private set;
	}

	public static float Height
	{
		get;
		private set;
	}

	public static float Left
	{
		get;
		private set;
	}

	public static float Right
	{
		get;
		private set;
	}

	public static float Top
	{
		get;
		private set;
	}

	public static float Bottom
	{
		get;
		private set;
	}

	public ScreenUtils()
	{
		Camera cam = Camera.main;

		Height = cam.orthographicSize * 2f;
		Width = Height * cam.aspect;

		Top = Height / 2f;
		Bottom = -Top;
		Right = Width / 2f;
		Left = -Right;
	}

	public static bool IsInsideScreen(Bounds b)
	{
		if (b.center.x - b.extents.x > Right)
			return false;
		if (b.center.x + b.extents.x < Left)
			return false;
		if (b.center.y - b.extents.y > Top)
			return false;
		if (b.center.y + b.extents.y < Bottom)
			return false;

		return true;
	}
}
