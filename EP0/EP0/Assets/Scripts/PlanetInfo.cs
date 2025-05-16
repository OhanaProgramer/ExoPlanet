using UnityEngine;

public class PlanetInfo : MonoBehaviour
{
    public string planetName;

    void Start()
    {
        planetName = gameObject.name;
    }

    void OnMouseDown()
    {
        Debug.Log("Clicked " + planetName);
    }
}
