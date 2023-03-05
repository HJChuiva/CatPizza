using UnityEngine;

public class SceneManager : Singleton<SceneManager>
{
    [SerializeField] GameObject HomeScene;
    [SerializeField] GameObject MaterialSelectScene;
    [SerializeField] GameObject PlayScene;
    [SerializeField] GameObject ResultScene;

    private HomeManager hm = null;

    // Start is called before the first frame update
    void Start()
    {
        // �ʱ⿡ Ȩ ȭ�� �ܿ� ��� ��Ȱ��ȭ
        Scene_init();
        HomeScene.SetActive(true);

        // �̱��� �޾ƿ���
        hm = HomeManager.Instance;
    }


    private void Scene_init()    // �� ��� ��Ȱ��ȭ
    {
        HomeScene.SetActive(false);
        MaterialSelectScene.SetActive(false);
        PlayScene.SetActive(false);
        ResultScene.SetActive(false);
    }

    public void Scene_Change_Home()    // Ȩ ������ ��ȯ
    {
        Scene_init();
        HomeScene.SetActive(true);
    }
    public void Scene_Change_MaterialSelect()    // �������� ���� ������ ��ȯ
    {
        Scene_init();
        MaterialSelectScene.SetActive(true);
    }
    public void Scene_Change_GamePlay()    // �����÷��� ������ ��ȯ
    {
        Scene_init();
        PlayScene.SetActive(true);
    }
    public void Scene_Change_Result()    // ���ȭ�� ������ ��ȯ
    {
        Scene_init();
        ResultScene.SetActive(true);
    }
}