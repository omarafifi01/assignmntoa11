using UnityEngine;

using UnityEngine.SceneManagement;

public class PuzzleManager : MonoBehaviour
{
    [Header("Assign your sockets here")]
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor redSocket;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor greenSocket;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor blueSocket;

    [Header("UI & Audio")]
    public GameObject successPanel;   // Your “Puzzle Completed” UI panel
    public AudioClip successClip;     

    bool hasFired = false;

    void Update()
    {
        if (!hasFired 
            && redSocket.hasSelection 
            && greenSocket.hasSelection 
            && blueSocket.hasSelection)
        {
            hasFired = true;
            OnPuzzleCompleted();
        }
    }

    void OnPuzzleCompleted()
    {
        if (successPanel != null)
            successPanel.SetActive(true);

        if (successClip != null && Camera.main != null)
            AudioSource.PlayClipAtPoint(successClip, Camera.main.transform.position);
    }

    public void RestartPuzzle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
