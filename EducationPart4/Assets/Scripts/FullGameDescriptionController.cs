using UnityEngine;

public class FullGameDescriptionController : MonoBehaviour
{
	[SerializeField] private GameObject _fullGameDescriptionPanel = null;

	private void Awake()
	{
		_fullGameDescriptionPanel.SetActive(false);
	}

	public void ShowFullDescription()
	{
		_fullGameDescriptionPanel.SetActive(true);
	}

	public void HideFullDescription()
	{
		_fullGameDescriptionPanel.SetActive(false);
	}
}
