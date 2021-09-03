using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

/* UI중 만들어야하는 색에 대한 스크립트입니다.
 * 인스펙터창의 ColorValues의 값에 각 원소들의 불꽃색을 입력하세요. */

public class ColorDecision : MonoBehaviour
{
    enum Answers { COPPER, KALIUM, NATRIUM, CALCIUM, LITHIUM, BARIUM, STRONTIUM }; //구리 칼륨 나트륨 칼슘 리튬 바륨 스트론튬
    public ColorValues colorValues;
    string currentColor = "None";

    [System.Serializable]
    public struct ColorValues
    {
        public Color Copper; //구리(청록)
        public Color Kalium; //칼륨(보라)
        public Color Natrium; //나트륨(노랑)
        public Color Calcium; //칼슘(주황)
        public Color Lithium; //리튬(빨강)
        public Color Barium; //바륨(황록)
        public Color Strontium; //스트론튬(진한빨강)
    }

    public Image image; //사용자가 만들어야하는 색을 나타낼 Image 컴포넌트를 연결합니다.

    public void OnEnable()
    {
        ImageColorChanger();
    }

    public void ImageColorChanger() //정답을 랜덤으로 생성하고 이에 따라 이미지의 색을 변경합니다.
    { 
        Answers answers = (Answers)Random.Range(0, 7);
        currentColor = answers.ToString();

        switch (answers)
        {
            case Answers.COPPER:
                image.color = colorValues.Copper;
                break;

            case Answers.KALIUM:
                image.color = colorValues.Kalium;
                break;

            case Answers.NATRIUM:
                image.color = colorValues.Natrium;
                break;

            case Answers.CALCIUM:
                image.color = colorValues.Calcium;
                break;

            case Answers.LITHIUM:
                image.color = colorValues.Lithium;
                break;

            case Answers.BARIUM:
                image.color = colorValues.Barium;
                break;

            case Answers.STRONTIUM:
                image.color = colorValues.Strontium;
                break;

            default:
                Debug.Log("ColorDecision.ImageColorChanger() : Out of Index(Answers)");
                break;
        }
    }

    public string currentColorGetter()
    {
        return currentColor;
    }
}
