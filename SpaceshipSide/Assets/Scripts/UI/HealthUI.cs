using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
	[SerializeField]
	private Health target = null;

	private Text textField;

	private void Awake()
	{
		textField = GetComponent<Text>();
		target.OnChange += UpdateText;
	}

	private void OnDestroy()
	{
		target.OnChange -= UpdateText;
	}

	private void UpdateText(float health)
	{
		textField.text = health.ToString();
	}
}
