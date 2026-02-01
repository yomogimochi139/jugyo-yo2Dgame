using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならTrueScene2へ
            SceneManager.LoadScene("TrueScene2");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならFalseScene2へ
            SceneManager.LoadScene("FalseScene2");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
