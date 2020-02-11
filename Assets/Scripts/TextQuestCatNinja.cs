using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestCatNinja : MonoBehaviour
{

  public int karmaCount;
  [Header("Elements")]
  public Text karma;
  public Text contentText; // переменная отвечает за историю
  public Text choicesText; // переменная отвечает за вывод вариантов
  public Steps activeStep; // степ, выводящийся на экран в данный момент
  public Steps instruction;
  public Steps gameOver;
  public Image contentImage;


  // public Sprite permanentCat;
  // public Sprite rainbow;
  void ResetGame(Steps any)
  {
    karmaCount = 2;
    contentText.text = any.content;
    choicesText.text = any.choices;
    karma.text = "Карма: " + karmaCount.ToString();
    activeStep = any.steps[0];
    contentImage.sprite = activeStep.image;
  }

  // Start is called before the first frame update
  void Start()
  {
    ResetGame(activeStep);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Alpha1))
    {
      checkPress(0);
    }
    else if (Input.GetKeyDown(KeyCode.Alpha2))
    {
      checkPress(1);
    }
    else if (Input.GetKeyDown(KeyCode.Alpha3))
    {
      checkPress(2);
    }
    else if (Input.GetKeyDown(KeyCode.Escape))
    {
      ResetGame(instruction);
    }

    }
    void checkPress(int index)
  {
    if (index < activeStep.steps.Length)
    {
      activeStep = activeStep.steps[index];
      contentText.text = activeStep.content;
      choicesText.text = activeStep.choices;
      karmaCount += activeStep.karmaMod;
      karma.text = "Карма: " + karmaCount.ToString();
      contentImage.sprite = activeStep.image;
            if (karmaCount == 0)
      {
        ResetGame(gameOver);
      }
    }
  }

}
