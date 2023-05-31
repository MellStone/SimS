using UnityEngine;

public class AIParameterModifier : MonoBehaviour
{
    public DataStorage dataStorage;

    public float ManagerHP()
    {
        if (HP >= 0.1f)
            HP -= Time.deltaTime;
        return HP;
    }
    public float ManagerEnergy()
    {
        if (Energy >= 0.1f)
            Energy -= (Hunger + Thirst) / 200 * 0.05f;
        
        return Energy;
    }
    public float ManagerHunger()
    {
        if (Hunger >= 0.1f)
            Hunger -= Time.deltaTime * 0.8f;
        if (Hunger < 0)
            Hunger = 0;
        return Hunger;
    }
    public float ManagerThirst()
    {
        if (Thirst >= 0.1f)
            Thirst -= Time.deltaTime;
        if (Thirst < 0)
            Thirst = 0;
        return Thirst;
    }
    public float ManagerExhausted()
    {
        if (Exhausted >= 0.1f)
            Exhausted -= (100 - Energy) * 0.01f;
        if (Exhausted < 0)
            Exhausted = 0;
        return Exhausted;
    }
    public float ManagerWC()
    {
        if (WC >= 0.1f)
            WC -= Time.deltaTime;
        return WC;
    }
    public float ManagerWorkDemand()
    {
        if (WorkDemand >= 0.1f)
            WorkDemand -= Time.deltaTime * 0.4f;
        if (WorkDemand < 0)
            WorkDemand = 0;
        return WorkDemand;
    }
    public float ManagerMentalHP()
    {
        if (MentalHP >= 0.1f)
            MentalHP -= (WorkDemand * Energy * HP) * 0.00000001f;
        return MentalHP;
    }
    public float MangerLightDemand()
    {
        //
        return LightDemand;
    }
    float HP
    {
        get { return dataStorage.HP; }
        set { dataStorage.HP = value; }
    }
    float Hunger
    {
        get { return dataStorage.Hunger; }
        set { dataStorage.Hunger = value; }
    }
    float Thirst
    {
        get { return dataStorage.Thirst; }
        set { dataStorage.Thirst = value; }
    }
    float Energy
    {
        get { return dataStorage.Energy; }
        set { dataStorage.Energy = value; }
    }
    float WC
    {
        get { return dataStorage.WC; }
        set { dataStorage.WC = value; }
    }
    float Exhausted
    {
        get { return dataStorage.Exhausted; }
        set { dataStorage.Exhausted = value; }
    }
    float WorkDemand
    {
        get { return dataStorage.WorkDemand; }
        set { dataStorage.WorkDemand = value; }
    }
    float MentalHP
    {
        get { return dataStorage.MentalHP; }
        set { dataStorage.MentalHP = value; }
    }
    float LightDemand
    {
        get { return dataStorage.LightDemand; }
        set { dataStorage.LightDemand = value; }
    }
}
