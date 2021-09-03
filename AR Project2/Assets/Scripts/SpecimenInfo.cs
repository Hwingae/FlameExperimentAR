using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 니크롬선(시료를 묻히는 도구)에 관한 스크립트입니다.
 * 불꽃과의 상호작용을 위해 니크롬선의 태그를 'Specimen'으로 등록해주세요. */

public class SpecimenInfo : MonoBehaviour
{
    string currentSpecimen; //현재 선택된 시료 이름

    public void ChangeSpecimenButton(string specimen)
    {
        currentSpecimen = specimen;
    }

    public string currentSpecimenGetter()
    {
        return currentSpecimen;
    }
}
