using UnityEditor;
using UnityEngine;

public class SceneViewFocusTool
{
    [MenuItem("Tools/Focus On Selected Object _f")] // F
    static void FocusOnSelectedObject()
    {
        if (SceneView.activeTransform != null)
            return;

        SceneView.lastActiveSceneView.pivot = Selection.activeTransform.position;
        SceneView.lastActiveSceneView.size = SceneView.lastActiveSceneView.size;
        SceneView.lastActiveSceneView.Repaint();
    }
}