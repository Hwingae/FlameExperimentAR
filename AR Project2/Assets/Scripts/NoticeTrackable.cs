using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

//추후 내용 추가해서 마커 인식되면 그 후에 게임 실행되도록

public class NoticeTrackable : MonoBehaviour
{
    public bool gameStarted = false;

    // Update is called once per frame
    void Update()
    {
        // Get the Vuforia StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager();

        // Query the StateManager to retrieve the list of currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours();

        // Iterate through the list of active trackables
        Debug.Log("List of trackables currently active (tracked): ");
        foreach (TrackableBehaviour tb in activeTrackables)
        {
            Debug.Log("Trackable: " + tb.TrackableName);
        }
    }
}
