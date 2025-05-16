using UnityEngine;
using TMPro;

public class StarSystemManager : MonoBehaviour
{
    public TextMeshProUGUI starLabel;
    public GameObject starPrefab;
    public GameObject planetPrefab;

    void Start()
    {
        string starName = GameManager.Instance.currentStarName;
        starLabel.text = "System: " + starName;

        // Create a star
        Instantiate(starPrefab, Vector3.zero, Quaternion.identity);

        // Spawn planets around the star
        GeneratePlanets(4);
    }
    
void GeneratePlanets(int numberOfPlanets)
{
    for (int i = 0; i < numberOfPlanets; i++)
    {
        float angle = i * Mathf.PI * 2f / numberOfPlanets;
        float radius = Random.Range(4f, 6f); // Keep some distance from center
        Vector3 position = new Vector3(
            Mathf.Cos(angle) * radius,
            Mathf.Sin(angle) * radius,
            0
        );

        string planetName = "Planet " + (char)(i + 65); // A, B, C...
        GameObject planet = Instantiate(planetPrefab, position, Quaternion.identity);
        planet.name = planetName;

        PlanetInfo info = planet.GetComponent<PlanetInfo>();
        if (info != null)
        {
            info.planetName = planetName;
        }
        Debug.Log("Spawned " + planetName);
    }
}

}
