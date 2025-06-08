using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Nazad()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
