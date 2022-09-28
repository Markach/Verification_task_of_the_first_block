string[]array1=new string[4]{"764", "number", "one", "45"};
string[]array2=new string[array1.Length];

void MakeSecondArray(string[] array1, string[] array2)
{
    int count = 0;
        for (int i = 0; i < array1.Length; i++)
            {
                if(array1[i].Length <= 3)
                    {
                        array2[count] = array1[i];
                        count++;
                    }
            }
}
void PrintArray(string[] Array)    
{
   Console.Write($"[");  
        for (int i = 0; i < Array.Length; i++)
            {
                if(i!= Array.Length-1) Console.Write($"{Array[i]} ");
                else Console.Write($"]");
            }
}
MakeSecondArray(array1, array2);
PrintArray(array2);

