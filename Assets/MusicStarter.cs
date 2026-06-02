using UnityEngine;
using System.Collections;

public class MusicStarter : MonoBehaviour
{
    public AudioSource musicSource;

    private IEnumerator Start()
    {
        // Wait 1 second before playing music
        yield return new WaitForSeconds(.5f);

        musicSource.Play();
    }
}