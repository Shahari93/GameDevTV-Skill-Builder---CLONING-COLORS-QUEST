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
        GameObject block = Instantiate(blockPrefab, spawnPosition.position, Quaternion.identity);
        randColor = Random.Range(0, 3);
        // assigning random int that represent the enum index
        block.GetComponent<ColorChanger>().colors = (ColorSelect)randColor;
    }
}