using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger1 : MonoBehaviour
{
    // インスペクターで設定するImageのリスト
    [SerializeField] private GameObject imageA;
    [SerializeField] private GameObject imageB;

    // ボタンのOnClickイベントに登録する関数
    public void ChangeSceneBasedOnActiveImage()
    {
        if (imageA.activeSelf)
        {
            // imageAがアクティブならFalseSceneへ
            SceneManager.LoadScene("FalseScene1");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならTrueSceneへ
            SceneManager.LoadScene("TrueScene1");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
