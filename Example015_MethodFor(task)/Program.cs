// Работа с текстом
// Дан текс.В тексте нужно заменить все пробелы черточками.
// маленькие буквы"к" заменить большими"К",
// а большие "С" на заменить маленькими "с".

// Ясна ли задача?

string text ="— Hello. — How are you?" 
            + "— I’m good. How are you?"
            + "— Good. Do you speak English?" 
            + "— A little. Are you American?"
            + "— Yes."
            + "— Where are you from?" 
            + "— I’m from California."
            + "— Nice to meet you."
            + "— Nice to meet you too";

// string s = "q w e r t y"
//             0 1 2 3 4 5 
// s[3] // r 

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0;i < length; i++)
    {
        if(text[i] == oldValue ) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text ,' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText ,'k', 'K');
Console.WriteLine(newText);




