string[] words = new string[5] {"Привет", "пока","2","кот","бот"};
List <string> words1 = new List <string> () ;
for (int i = 0 ; i < words.Length; i++)
{
    if(words[i].Length <= 3)
    {
        words1.Add (words[i]);
    }
}





