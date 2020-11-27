using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationScript : MonoBehaviour
{
   
    [SerializeField] private GameObject replayArea;

    private Animator carAnimator;

    private void Start()
    {
        carAnimator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        StartCoroutine(Delay(3f));
    }

    public void ReplayScene()
    {
        SceneManager.LoadScene(0);
    }

    private void ShowReplayArea()
    {
        replayArea.SetActive(true);
    }

    private IEnumerator Delay(float second)
    {
        yield return new WaitForSeconds(second);
        carAnimator.SetTrigger("PlayAnim");
    }
}
