using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RewindObject))]
public class EditorTest : Editor{

    public override void OnInspectorGUI(){
        base.OnInspectorGUI();

        RewindObject item = (RewindObject)target;
        
        GUILayout.BeginHorizontal();

        if(GUILayout.Button("Posicion 1")){
            item.originalPosition = item.transform.position;
            item.originalRotation = item.transform.rotation;
        }
        if(GUILayout.Button("Posicion 2")){
            item.unwindedPosition = item.transform.position;
            item.unwindedRotation = item.transform.rotation;
        }
        GUILayout.EndHorizontal();
    }

}
