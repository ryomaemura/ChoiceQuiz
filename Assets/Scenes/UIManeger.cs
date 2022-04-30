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
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject playGuidePanel;

    // Start is called before the first frame update
    void Start() {
        closeQuizPanel();
        closeResultPanel();
        closePlayGuidePanel();
    }

    // Update is called once per frame
    void Update() {
    }

    public void openQuizPanel() {
        quizPanel.SetActive(true);
    }
    
    public void closeQuizPanel() {
        quizPanel.SetActive(false);
    }

    public void openResultPanel() {
        resultPanel.SetActive(true);
    }

    public void closeResultPanel() {
        resultPanel.SetActive(false);
    }

    public void openMenuPanel() {
        menuPanel.SetActive(true);
    }

    public void closeMenuPanel() {
        menuPanel.SetActive(false);
    }

    public void openPlayGuidePanel() {
        playGuidePanel.SetActive(true);
    }

    public void closePlayGuidePanel() {
        playGuidePanel.SetActive(false);
    }
}
