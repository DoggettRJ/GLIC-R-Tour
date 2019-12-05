using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadFuseScene : MonoBehaviour {

    public void SceneLoader()
    {
        SceneManager.LoadScene("One Razor Test scene");
    }

    public void CombineVideoLoader()
    {
        SceneManager.LoadScene("Combine Video");
    }

    public void SizzleVideoLoader()
    {
        SceneManager.LoadScene("Sizzle Video");
    }

    public void CartVideoLoader()
    {
        SceneManager.LoadScene("Cart Video");
    }

    public void BladeVideoLoader()
    {
        SceneManager.LoadScene("Blade Video");
    }

    public void LubraVideoLoader()
    {
        SceneManager.LoadScene("Lubra Video");
    }
}
