using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadArea1 : MonoBehaviour
{
    public void OnMouseButton()
    {
        SceneManager.LoadScene("Area1");
    }
}
