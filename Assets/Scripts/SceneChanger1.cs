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
            // imageAがアクティブならSceneAへ
            SceneManager.LoadScene("GameSceneA");
        }
        else if (imageB.activeSelf)
        {
            // imageBがアクティブならSceneBへ
            SceneManager.LoadScene("GameSceneB");
        }
        else
        {
            Debug.Log("アクティブな画像がありません。");
        }
    }
}
