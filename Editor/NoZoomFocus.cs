using UnityEditor;

public class SceneViewAlignToSelected
{
	[MenuItem("Tools/Align Scene View to Selected Object _F")]
	private static void AlignSceneViewToSelectedObject()
	{
		SceneView.lastActiveSceneView.pivot = Selection.activeTransform.position;
		SceneView.lastActiveSceneView.Repaint();
	}
}