using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunkManager : MonoBehaviour
{
    public GameObject TrunkPrefab;
    public GameObject branchLeftPrefab;
    public GameObject branchRightPrefab;

    private List<GameObject> branches;
    private bool isToCreateEmpty = true;

    // Start is called before the first frame update
    void Start()
    {
        branches = new List<GameObject>();

        for (int i = 0; i < 10; i += 2)
        {
            GameObject trunkEmpty = Instantiate(TrunkPrefab);
            trunkEmpty.transform.localPosition = new Vector3(0, i * 1.6f, 0);
            branches.Add(trunkEmpty);

            GameObject trunkBranch = Instantiate(getRandomBranch());
            trunkBranch.transform.localPosition = new Vector3(0, (i + 1) * 1.6f, 0);
            branches.Add(trunkBranch);
        }
    }

    private GameObject getRandomBranch()
    {
        int random = Random.Range(0, 100);
        if (random < 30)
        {
            return TrunkPrefab;  // 30% шанс на TrunkPrefab
        }
        else if (random < 60)
        {
            return branchLeftPrefab;  // 30% шанс на branchLeftPrefab
        }
        return branchRightPrefab;  // 40% шанс на branchRightPrefab
    }

    public void CutFirstTrunk()
    {
        Destroy(branches[0]);
        branches.RemoveAt(0);

        // Позиционируем все объекты в списке
        for (int i = 0; i < branches.Count; i++)
        {
            branches[i].transform.localPosition = new Vector3(branches[i].transform.localPosition.x, i * 2.43f, branches[i].transform.localPosition.z);
        }

        // Создаем новый объект (ствол или ветку)
        GameObject trunkEmpty = Instantiate(isToCreateEmpty ? TrunkPrefab : getRandomBranch());
        trunkEmpty.transform.localPosition = new Vector3(0, branches.Count * 1.6f, 0);
        branches.Add(trunkEmpty);

        isToCreateEmpty = !isToCreateEmpty;
    }

    public string GetDirectionFirstTrunk()
    {
        Trunk trunkComponent = branches[0].GetComponent<Trunk>();
        if (trunkComponent != null)
        {
            return trunkComponent.diraction;
        }
        else
        {
            return "Unknown";  
        }
    }
}
