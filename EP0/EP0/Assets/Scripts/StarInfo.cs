using UnityEngine;
using UnityEngine.SceneManagement;

public class StarInfo : MonoBehaviour
{
    public int starID;
    public string starName;

    void OnMouseDown()
    {
        Debug.Log($"Clicked {starName} (ID: {starID})");

        GameManager.Instance.currentStarID = starID;
        GameManager.Instance.currentStarName = starName;

        SceneManager.LoadScene("StarSystem"); // Will fail until we create it
    }
}
