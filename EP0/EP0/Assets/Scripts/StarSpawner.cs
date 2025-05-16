using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject starPrefab;
    public int starCount = 10;
    public float radius = 5f;

    void Start()
    {
        for (int i = 0; i < starCount; i++)
        {
            Vector2 pos = Random.insideUnitCircle * radius;
            GameObject star = Instantiate(starPrefab, pos, Quaternion.identity);
            star.name = "Star_" + i;

            var info = star.AddComponent<StarInfo>();
            info.starID = i;
            info.starName = "Star " + i;
        }
    }
}

