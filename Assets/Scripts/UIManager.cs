using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private TMP_Text scoreText;

    private float _playerScore;
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void UpdateScore(float scoreValue)
    {
        _playerScore += scoreValue;
        
        scoreText.text = _playerScore.ToString();
    }
}
