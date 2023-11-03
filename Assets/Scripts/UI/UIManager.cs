using UnityEngine;

public class UIManager : MonoBehaviour
{
	[SerializeField] private CursorLockMode cursorStartMode = CursorLockMode.Locked;
	[SerializeField] private bool visible;

    private void Start()
    {
        Cursor.lockState = cursorStartMode;
		Cursor.visible = visible;
    }
}
