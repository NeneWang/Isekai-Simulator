using Naninovel;
[Naninovel.ExpressionFunctions]
public static class CustomFunctions
{

    public static bool addMoney(int addMoney)
    {

        DataNani datanani = new DataNani();

        datanani.p_money += addMoney;
        datanani.p_networth += addMoney;

        datanani.saveData();
        return true;

    }

    public static bool increaseTurn(){
        
        DataNani datanani = new DataNani();
        datanani.increaseTurn();
        datanani.saveData();
        return true;

    }


    public class constant{

    }

    public class Job{
        public int payment;
        public int jobLevel;
        public string[] jobTitles;
        public string getJobName
        {
            get => jobTitles[jobLevel];
        }

    }


    //Returns the total monney, but also adds the networth on the backgroun
    public class DataNani
    {
        public int p_turn, p_age, p_health, p_mana, p_happiness, p_money, p_weeklyCashFlow;
        public int  p_missionsCompleted,  p_maxhealth, p_networth , p_stat_str, p_stat_vit, p_stat_dex, p_stat_int;
        public string p_title, p_sex;
        




        public DataNani()
        {
            fetchData();
        }

        public void increaseTurn(){
            p_turn++;
        }
        public void fetchData()
        {
            var variableManager = Engine.GetService<ICustomVariableManager>();
            variableManager.TryGetVariableValue<int>("p_turn", out p_turn);
            variableManager.TryGetVariableValue<int>("p_age", out p_age);
            variableManager.TryGetVariableValue<string>("p_sex", out p_sex);
            variableManager.TryGetVariableValue<int>("p_health", out p_health);
            variableManager.TryGetVariableValue<int>("p_mana", out p_mana);
            variableManager.TryGetVariableValue<int>("p_happiness", out p_happiness);
            variableManager.TryGetVariableValue<int>("p_money", out p_money);
            variableManager.TryGetVariableValue<int>("p_weeklyCashFlow", out p_weeklyCashFlow);
            variableManager.TryGetVariableValue<string>("p_title", out p_title);
            variableManager.TryGetVariableValue<int>("p_missionsCompleted", out p_missionsCompleted);
            variableManager.TryGetVariableValue<int>("p_maxhealth", out p_maxhealth);
            variableManager.TryGetVariableValue<int>("p_networth", out p_networth);
            variableManager.TryGetVariableValue<int>("p_stat_str", out p_stat_str);
            variableManager.TryGetVariableValue<int>("p_stat_vit", out p_stat_vit);
            variableManager.TryGetVariableValue<int>("p_stat_dex", out p_stat_dex);
            variableManager.TryGetVariableValue<int>("p_stat_int", out p_stat_int);
        }

        public void saveData()
        {
            var variableManager = Engine.GetService<ICustomVariableManager>();
            variableManager.TrySetVariableValue("p_turn", p_turn);
            variableManager.TrySetVariableValue("p_age", p_age);
            variableManager.TrySetVariableValue("p_sex", p_sex);
            variableManager.TrySetVariableValue("p_health", p_health);
            variableManager.TrySetVariableValue("p_mana", p_mana);
            variableManager.TrySetVariableValue("p_happiness", p_happiness);
            variableManager.TrySetVariableValue("p_weeklyCashFlow", p_weeklyCashFlow);
            variableManager.TrySetVariableValue("p_title", p_title);
            variableManager.TrySetVariableValue("p_missionsCompleted", p_missionsCompleted);
            variableManager.TrySetVariableValue("p_maxhealth", p_maxhealth);
            variableManager.TrySetVariableValue("p_networth", p_networth);
            variableManager.TrySetVariableValue("p_stat_str", p_stat_str);
            variableManager.TrySetVariableValue("p_stat_vit", p_stat_vit);
            variableManager.TrySetVariableValue("p_stat_dex", p_stat_dex);
            variableManager.TrySetVariableValue("p_stat_int", p_stat_int);
        }




    }

}

