using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public GameObject imageA;
    public GameObject imageB;

    // Button1が押された時
    public void ShowImageA()
    {
        imageA.SetActive(true);  // Aを表示
        imageB.SetActive(false); // Bを非表示
    }

    // Button2が押された時
    public void ShowImageB()
    {
        imageA.SetActive(false); // Aを非表示
        imageB.SetActive(true);  // Bを表示
    }
}
