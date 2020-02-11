using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Steps : MonoBehaviour
{
  [TextArea]
  public string content;
  [TextArea]
  public string choices;
  public Steps[] steps;
  public int karmaMod;
  public Sprite image;
}