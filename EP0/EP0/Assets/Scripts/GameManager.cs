using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int currentStarID;
    public string currentStarName;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // survives scene switches
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
