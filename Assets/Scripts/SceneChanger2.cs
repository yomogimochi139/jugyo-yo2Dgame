using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger2 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならTrueScene3へ
            SceneManager.LoadScene("TrueScene3");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならFalseScene3へ
            SceneManager.LoadScene("FalseScene3");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
