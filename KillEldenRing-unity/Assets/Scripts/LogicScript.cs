using UnityEngine;
using TMPro;
using System.IO;

public class LogicScript : MonoBehaviour
{
    [SerializeField] TMP_Text TextField_;
    [SerializeField] string PreText_;
    [SerializeField] string ScoreFilePath_; // Path to the score file

    void UpdateValue()
    {
        if (File.Exists(ScoreFilePath_))
        {
            string score = File.ReadAllText(ScoreFilePath_);
            TextField_.text = PreText_ + score;
        }
        else
        {
            TextField_.text = PreText_ + "File not found!";
        }
    }

    void Update()
    {
        UpdateValue();
    }
}
