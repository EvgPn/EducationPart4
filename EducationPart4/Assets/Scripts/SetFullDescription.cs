using UnityEngine;
using UnityEngine.UI;

public class SetFullDescription : MonoBehaviour
{    
    [SerializeField] private Text _gameName = null;
    [SerializeField] private Text _gameGanre = null;
    [SerializeField] private Image _gameIcon = null;
    [SerializeField] private Image _screen1 = null;
    [SerializeField] private Image _screen2 = null;
    [SerializeField] private Image _screen3 = null;
    [SerializeField] private Text _gameRateText = null;
    [SerializeField] private Text _gameVolumeText = null;
    private GameDesription _gameDesription = null;

    private void SetDescription()
    {
        _gameName.text = _gameDesription.GameName;
        _gameGanre.text = _gameDesription.GameGenre;
        _gameIcon.sprite = _gameDesription.GameIcon;
        _gameRateText.text = _gameDesription.GameRate.ToString();
        _gameVolumeText.text = _gameDesription.GameVolume.ToString() + " MB";

        _screen1.sprite = _gameDesription.Screen1;
        _screen2.sprite = _gameDesription.Screen2;
        _screen3.sprite = _gameDesription.Screen3;
    }

    public void GetGameDescription(GameDesription gameDesription)
    {
        _gameDesription = gameDesription;
        SetDescription();
    }
}
