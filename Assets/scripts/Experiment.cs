using UnityEngine;
using UnityEngine.SceneManagement;

public class Experiment : MonoBehaviour
{
    
    public void EndRestart()
    {
        SceneManager.LoadScene("Level01");
    }
}
