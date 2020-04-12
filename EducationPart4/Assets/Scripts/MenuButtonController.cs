using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    [SerializeField] private GameObject _hideMenuButton = null;
    [SerializeField] private Animator _menuButtonAnimator = null;
    private bool _menuSliding = false;

    private void Awake()
    {
        _hideMenuButton.SetActive(false);
    }

    public void ShowMenu()
    {
        if(!_menuSliding)
        {
            ChangeMenuState(!_menuSliding);
        }
    }

    public void HideMenu()
    {
        if(_menuSliding)
        {
            ChangeMenuState(!_menuSliding);
        }
    }

    private void ChangeMenuState(bool menuSliding)
    {
        _menuSliding = menuSliding;
        _menuButtonAnimator.SetBool("Sliding", _menuSliding);
        _hideMenuButton.SetActive(_menuSliding);
    }
}
