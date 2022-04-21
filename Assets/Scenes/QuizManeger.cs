using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManeger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI quizText;
    [SerializeField] Image resultImage;
    int quizLabel = 0;
    int quizNumber = 0;

    string[,] quizTexts = {
        {
            "Wink", "Sugar", "BaBe", "MAX", "Qlair", "CoCo", "ribbon", "cotton", "METAMO", "DORA",
            "VENUS", "HiP", "Melody", "GAM", "ROMANS", "ZYX", "EARTH", "ChocoLe", "Carezza", "Pabo",
            "SHAKE", "JK21", "Springs", "Dream5", "9nine", "Negicco", "Perfume", "Buzy", "Pinkish", "Fine",
            "Feam", "PLIME", "Whiteberry", "GEM", "Hauptharmonie", "ekoms", "ZOC", "AqbiRec", "NILKLY", "BABYMETAL",
            "Zi:zoo", "AppleTale", "AeLL.", "RuRian", "BYOB", "BiS", "BiSH", "EMPiRE", "ASP", "WAgg",
            "E-girls", "Flower", "Happiness", "asfi", "amiinA", "IVOLVE", "uijin", "HR", "Especia", "X21",
            "Cupitron", "KNU", "kolme", "CY8ER", "splash!", "Chelip", "chuLa", "drop", "nanoRider", "notall",
            "palet", "FAKY", "pramo", "predia", "miscast", "LinQ", "RAY", "Layn", "NiziU", "PIGGS"
        },
        {
            "A", "ABC", "ABCL", "Ada", "Agena", "ALGOL", "Alice", "ash", "Apex", "Arc",
            "AutoIt", "Ballerina", "Bash", "BASIC", "Befunge", "Bioera", "Boo", "C", "Caml", "Chapel",
            "CHILL", "CLU", "Concurrent Clean", "COW", "csh", "Curl", "Dart", "Eiffel", "Elixir", "Elm",
            "Erlang", "Euphoria", "Factor", "Falcon", "Fantom", "Forth", "Fortress", "Go", "Hack", "Haxe",
            "HLASM", "HSP", "Icon", "ID", "IDL", "Inform", "Io", "IPL", "Java", "Jancy",
            "JSX", "Julia", "KEMURI", "KL1", "Lazy K", "Limbo", "Linda", "LOGO", "Lola", "Lush",
            "m4", "Mana", "Maple", "Max", "Mesa", "Mind", "Mops", "Napier88", "Nim", "Oberon",
            "Occam", "Oz", "Pascal", "Perl", "PHP", "Pic", "Pike", "pine", "Prolog", "Pxem",
        }
    };

    // Start is called before the first frame update
    void Start()
    {
        resetQuiz();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void resultJudgment(int buttonNumber){
        if (buttonNumber == quizLabel) {
            resultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("maru");
        } else {
            resultImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("batsu");
        }
    }

    public void resetQuiz() {
        quizLabel = UnityEngine.Random.Range(0, quizTexts.GetLength(0));
        quizNumber = UnityEngine.Random.Range(0, quizTexts.GetLength(1));
        quizText.text = quizTexts[quizLabel, quizNumber];
    }
}
