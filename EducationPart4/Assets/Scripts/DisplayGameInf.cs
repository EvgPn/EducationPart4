using UnityEngine;
using UnityEngine.UI;

public class DisplayGameInf : MonoBehaviour
{
    [SerializeField] private GameDesription _gameDesription = null;
    [SerializeField] private Text _gameName = null;
    [SerializeField] private Text _gameGanre = null;
    [SerializeField] private Image _gameIcon = null;
    [SerializeField] private Text _gameRateText = null;
    [SerializeField] private Text _gameVolumeText = null;

    private void Start()
    {
        _gameName.text = _gameDesription.GameName;
        _gameGanre.text = _gameDesription.GameGenre;
        _gameIcon.sprite = _gameDesription.GameIcon;
        _gameRateText.text = _gameDesription.GameRate.ToString();
        _gameVolumeText.text = _gameDesription.GameVolume.ToString() + " MB";
    }
}
