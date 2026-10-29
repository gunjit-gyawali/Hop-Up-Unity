using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;

    public int platformcount = 300;
    void Start()
    {
        Vector3 spwanPosition = new Vector3();
        for (int i = 0; i < platformcount; i++)
        {
            spwanPosition.y += Random.Range(.5f, 2f);
            spwanPosition.x = Random.Range(-5f, 5f);
            Instantiate(playerPrefab, spwanPosition, Quaternion.identity);
        }
    }
}
