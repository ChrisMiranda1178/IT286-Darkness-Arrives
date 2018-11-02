using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public GameObject Current;
    public GameObject Next;
    public SortedSet<Unit> UnitList;
    // Use this for initialization
    void Start()
    {
        UnitList = new SortedSet<Unit>(new AgilitySorter());
        Unit one = new Unit();
        one.agility = 6;
        one.type = Unit.UnitType.Heavy;
        Unit two = new Unit();
        two.agility = 5;
    }
    public void SwitchTurn()
    {
        GameObject Swap;
        Swap = Next;
        Next = Current;
        Current = Swap;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchTurn();
        }
    }
    public class Unit
    {
        public bool Player;
        public int agility;
        public enum UnitType
        {
            Heavy = 50,
            Scout = 200,
            Normal = 100
        }
        public UnitType type;
    }
    public class AgilitySorter : IComparer<Unit>
    {
        public int Compare(Unit a, Unit b)
        {
            int a_agility = a.agility * (int)a.type;
            int b_agility = b.agility * (int)b.type;
            if (a.Player)
                a_agility += 1;
            if (b.Player)
                b_agility += 1;
            if (a_agility > b_agility)
            {
                return 1;
            }
            else if (b_agility > a_agility)
            {
                return -1;
            }
            else
                return 0;
        }
    }
}

public class SortedSet<T>
{
    private TurnManager.AgilitySorter agilitySorter;

    public SortedSet(TurnManager.AgilitySorter agilitySorter)
    {
        this.agilitySorter = agilitySorter;
    }
}