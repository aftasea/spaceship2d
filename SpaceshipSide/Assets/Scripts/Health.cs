using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
	[SerializeField]
	private float maxHealth = 0f;

	public event Action<float> OnChange;

	private float currentHealth;

	private void Awake()
	{
		currentHealth = maxHealth;
	}

	private void Start()
	{
		OnChange?.Invoke(currentHealth);
	}

	public void TakeDamage(float amount)
	{
		if (amount < currentHealth)
		{
			currentHealth -= amount;
		}
		else
		{
			currentHealth = 0f;
		}

		OnChange?.Invoke(currentHealth);
	}
}
