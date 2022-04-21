using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    // 2つのPanelを格納する変数
    // インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject quizPanel;
    [SerializeField] GameObject resultPanel;

    // Start is called before the first frame update
    void Start()
    {
        // openQuizPanel メソッドを呼び出す
        openQuizPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // resultPanel を開く
    public void openResultPanel()
    {
        // quizPanel.SetActive(false);
        resultPanel.SetActive(true);
    }

    // resultPanel を閉じる
    public void closeResultPanel()
    {
        quizPanel.SetActive(true);
        resultPanel.SetActive(false);
    }

    // quizPanel を開く
    public void openQuizPanel()
    {
        quizPanel.SetActive(true);
        resultPanel.SetActive(false);
    }
}
