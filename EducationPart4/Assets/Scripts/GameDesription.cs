using UnityEngine;

[CreateAssetMenu(fileName = "New Game", menuName = "Game")]
public class GameDesription : ScriptableObject
{
	public string GameName;
	public string GameGenre;

	public Sprite GameIcon;
	public Sprite Screen1;
	public Sprite Screen2;
	public Sprite Screen3;

	public float GameRate;
	public float GameVolume;
}
