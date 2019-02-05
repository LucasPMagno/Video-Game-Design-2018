using UnityEngine;
using Unity Engine.SceneManagement;

public class Start : MonoBehaviour
{
   public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
