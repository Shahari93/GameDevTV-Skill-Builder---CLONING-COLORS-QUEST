// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv
using UnityEngine;

public class SpawnNewBlock : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] Transform spawnPosition;

    private int randColor;

    public void SpawnBlock()
    {
        randColor = Random.Range(0, 3);
        // assigning random int that represent the enum index
        blockPrefab.GetComponent<ColorChanger>().colors = (ColorSelect)randColor;
        Instantiate(blockPrefab, spawnPosition.position, Quaternion.identity);
    }
}