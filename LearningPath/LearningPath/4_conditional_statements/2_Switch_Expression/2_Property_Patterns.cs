namespace LearningPath.LearningPath._4_conditional_statements._2_Switch_Expression;

public class Property_Patterns {
    
    // klasik switch-case - switch-case classic
    static void Main(string[] args)
    {
        double money = 0;
        switch (job)
        {
            case "driver" ;
                money = 3000;
                break;
            case "teacher";
                money = 4000;
                break;
            case "doctor";
                money = 5000;
                break;
            
        }
        //property patterns ile yazılıan hali - written with property patterns
        double money = job switch
        {
            { "driver" } => 3000,
            { "teacher" } => 4000,
            { "doctor" } => 5000,
            _ => 0 // default
        };
    }
}