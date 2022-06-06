using UnityEngine;

public class UrlRedirect : MonoBehaviour
{
    public string Url;



    public void OpenUpdates()
    {
        Application.OpenURL(Url);
    }
}
