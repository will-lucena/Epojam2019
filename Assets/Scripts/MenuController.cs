using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject mainGO;
    [SerializeField] private GameObject howGO;
    [SerializeField] private GameObject aboutGO;
    [SerializeField] private GameObject settingsGO;

    [SerializeField] private ProducerSO team;
    [SerializeField] private Transform contentGroup;
    [SerializeField] private GameObject devCardPrefab;

    private GameObject actualMenu;
    private GameObject lastMenu;

    private void Awake()
    {
        createAboutScreen();
        SlideAnimationController.notifySlideEnd += startSlideIn;
    }

    private void Start()
    {
        actualMenu = mainGO;
    }

    public void goToAbout()
    {
        lastMenu = actualMenu;
        actualMenu.GetComponent<Animator>().SetTrigger("slide out");
        actualMenu = aboutGO;
    }

    public void goToSettings()
    {
        lastMenu = actualMenu;
        actualMenu.GetComponent<Animator>().SetTrigger("slide out");
        actualMenu = settingsGO;
    }

    public void goToMain()
    {
        lastMenu = actualMenu;
        actualMenu.GetComponent<Animator>().SetTrigger("slide out");
        actualMenu = mainGO;
    }

    public void goToHow()
    {
        lastMenu = actualMenu;
        actualMenu.GetComponent<Animator>().SetTrigger("slide out");
        actualMenu = howGO;
    }

    public void goToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    private void startSlideIn(GameObject obj)
    {
        if (obj == lastMenu)
        {
            actualMenu.GetComponent<Animator>().SetTrigger("slide in");
        }        
    }

    private void createAboutScreen()
    {
        foreach (var person in team.team)
        {
            GameObject go = Instantiate(devCardPrefab, contentGroup) as GameObject;
            Developer script = go.GetComponent<Developer>();

            script.setValues(person.name, person.role, person.photo);
        }
    }
}
