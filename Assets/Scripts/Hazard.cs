// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using UnityEngine;

public class Hazard : MonoBehaviour
{
    private GameHandler gameHandler;

    void Start()
    {
        gameHandler = FindObjectOfType<GameHandler>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block") && collision.gameObject.GetComponent<SpriteRenderer>().color != this.GetComponent<SpriteRenderer>().color)
        {
            if (collision.gameObject.GetComponent<BlockMovement>().isActiveBool)
            {
                Destroy(collision.gameObject);
                gameHandler.AllPlayerBlocksArrayUpdate();
                gameHandler.DestroyedBlockUpdate();
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
}