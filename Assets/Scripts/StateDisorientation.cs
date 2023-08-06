using UnityEngine;

public class StateDisorientation : MonoBehaviour
{
	public Vector3 GetReverseCoordinates(Vector3 normalPosition, Vector3 currentPosition)
	{
		var x = currentPosition.x - (normalPosition.x - currentPosition.x);
		var y = currentPosition.y - (normalPosition.y - currentPosition.y);
		var z = currentPosition.z - (normalPosition.z - currentPosition.z);
		return new Vector3(x, y, z);
	}
}
