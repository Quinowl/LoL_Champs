using UnityEngine;

public class ChampionInput : MonoBehaviour
{
    private Champion _champion;
    private Camera _cam;

    void Awake()
    {
        if (!_cam) _cam = Camera.main;
    }
    void Update()
    {
        HandleClick();
        HandleAbilitiesInputs();
    }

    public void Initialize(Champion champion) => _champion = champion;

    private void HandleClick()
    {
        if (!Input.GetMouseButtonDown(1)) return;
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit)) _champion.Mediator.OnClick(hit);
    }

    private void HandleAbilitiesInputs()
    {
        if (Input.GetKeyDown(KeyCode.Q)) Debug.Log("Q pressed");
        if (Input.GetKeyDown(KeyCode.W)) Debug.Log("W pressed");
        if (Input.GetKeyDown(KeyCode.E)) Debug.Log("E pressed");
        if (Input.GetKeyDown(KeyCode.R)) Debug.Log("R pressed");
    }
}
