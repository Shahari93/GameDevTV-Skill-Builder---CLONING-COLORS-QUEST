using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private FlashCoin flashCoin;
    private SpriteRenderer mySpriteRenderer;

    [SerializeField] private Image winScreen;

    private void Start()
    {
        flashCoin = FindObjectOfType<FlashCoin>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        winScreen.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (flashCoin.hasCoin && collision.gameObject.GetComponent<SpriteRenderer>().color == mySpriteRenderer.color)
        {
            Time.timeScale = 0;
            winScreen.gameObject.SetActive(true);
        }
    }
}
