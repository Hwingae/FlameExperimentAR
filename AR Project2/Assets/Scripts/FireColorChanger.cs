using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 반응으로써 드러나는 불꽃 모습에 대한 스크립트
 * 목표 색을 보여주는 패널을 goalPanel에 등록해주세요 */

[RequireComponent (typeof (ParticleSystem))]
public class FireColorChanger : MonoBehaviour
{
    ParticleSystem particle;
    public ColorDecision goalPanel;
    public Timer timerScript;
    
    Color defaultColor;

    string fireSpecimen = "None";

    const string Copper = "Copper";
    const string Kalium = "Kalium";
    const string Natrium = "Natrium";
    const string Calcium = "Calcium";
    const string Lithium = "Lithium";
    const string Barium = "Barium";
    const string Strontium = "Strontium";

    private void Start()
    {
        particle = gameObject.GetComponentInChildren<ParticleSystem>();
        defaultColor = gameObject.GetComponent<Renderer>().material.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        SpecimenInfo specimenInfo = other.GetComponent<SpecimenInfo>();
        string currentSpecimen = specimenInfo.currentSpecimenGetter(); //현재 니크롬선에 묻혀진 시료

        var main = particle.main;

        print("Color Changed");

        switch (currentSpecimen)
        {
            case Copper:
                particle.startColor = goalPanel.colorValues.Copper;
                fireSpecimen = "COPPER";
                break;

            case Kalium:
                main.startColor = goalPanel.colorValues.Kalium;
                fireSpecimen = "KALIUM";
                break;

            case Natrium:
                main.startColor = goalPanel.colorValues.Natrium;
                fireSpecimen = "NATRIUM";
                break;

            case Calcium:
                main.startColor = goalPanel.colorValues.Calcium;
                fireSpecimen = "CALCIUM";
                break;

            case Lithium:
                main.startColor = goalPanel.colorValues.Lithium;
                fireSpecimen = "LITHIUM";
                break;

            case Barium:
                main.startColor = goalPanel.colorValues.Barium;
                fireSpecimen = "BARIUM";
                break;

            case Strontium:
                main.startColor = goalPanel.colorValues.Strontium;
                fireSpecimen = "STRONTIUM";
                break;

            default:
                main.startColor = defaultColor;
                fireSpecimen = "None";
                break;
        }

        if (fireSpecimen == goalPanel.currentColorGetter())
        {
            goalPanel.ImageColorChanger();
            timerScript.NextRound();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var main = particle.main;

        main.startColor = defaultColor;
        fireSpecimen = "None";
    }
}
