namespace LearningPath.LearningPath._4_conditional_statements._2_Switch_Expression;

public class Tuple_Patterns {
    // standart pattern
    
    string message = "";
    switch (name, age)
    {
        case ("John", 20):
            message = "John is 20 years old";
            break;
        case ("Jane", 30):
            message = "Jane is 30 years old";
            break;
        case ("Doe", 40):
            message = "Doe is 40 years old";
            break;
        default:
            message = "Unknown person";
            break;
    }
    //tuple pattern
    string message = (name, age) switch
    {
        ("John", 20) => message = "John is 20 years old",
        ("Jane", 30) => message = "Jane is 30 years old",
        ("Doe", 40) => message = "Doe is 40 years old",
        _ => "Unknown person"
    };
}