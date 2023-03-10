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
        // 초기에 홈 화면 외에 모두 비활성화
        Scene_init();
        HomeScene.SetActive(true);

        // 싱글톤 받아오기
        hm = HomeManager.Instance;
    }


    private void Scene_init()    // 씬 모두 비활성화
    {
        HomeScene.SetActive(false);
        MaterialSelectScene.SetActive(false);
        PlayScene.SetActive(false);
        ResultScene.SetActive(false);
    }

    public void Scene_Change_Home()    // 홈 씬으로 전환
    {
        Scene_init();
        HomeScene.SetActive(true);
    }
    public void Scene_Change_MaterialSelect()    // 스테이지 선택 씬으로 전환
    {
        Scene_init();
        MaterialSelectScene.SetActive(true);
    }
    public void Scene_Change_GamePlay()    // 게임플레이 씬으로 전환
    {
        Scene_init();
        PlayScene.SetActive(true);
    }
    public void Scene_Change_Result()    // 결과화면 씬으로 전환
    {
        Scene_init();
        ResultScene.SetActive(true);
    }
}
