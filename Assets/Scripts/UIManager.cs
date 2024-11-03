using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private TMP_Text scoreText;

    private float _playerScore;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
            Destroy(gameObject);
    }

    #region Score
    public void UpdateScore(float scoreValue)
    {
        _playerScore += scoreValue;
        
        scoreText.text = $"Score: {_playerScore}";
    }

    public float GetPlayerScore()
    {
        return _playerScore;
    }
    #endregion

    #region Menu
    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    #endregion
}
