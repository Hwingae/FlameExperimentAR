using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/* 불꽃에 넣을 시료를 변경해줄 버튼에 대한 스크립트입니다.
 * 해당 버튼의 이름은 '시료이름 + 버튼'으로 지정해주세요. ex) Copper Button */

public class SpecimenButton : MonoBehaviour
{
    string buttonSpecimen; //해당 버튼의 시료 이름

    public GameObject Specimen; //화면에서 불꽃에 댈 시료(니크롬선) 오브젝트

    public void ChangeSpecimenButtonDown()
    //버튼에 저장된 시료의 이름을 시료(니크롬선) 오브젝트에 보냅니다. (버튼의 해당 시료를 묻힌 효과)
    {
        SpecimenInfo specimenInfo = Specimen.GetComponent<SpecimenInfo>();
        specimenInfo.ChangeSpecimenButton(buttonSpecimen);
    }

    public void NameGetterButtonDown()
    //버튼의 이름을 공백을 기준으로 분리한 뒤 첫 단어를 시료의 이름으로써 저장합니다.
    {
        string[] splitText = EventSystem.current.currentSelectedGameObject.name.Split(' ');
        buttonSpecimen = splitText[0];
    }
}