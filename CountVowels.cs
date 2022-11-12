while (loop == true){
Console.WriteLine("Введите слово, чтобы подсчитать количество гласных");
char[] input = Console.ReadLine().ToLower().ToCharArray();
if (input == null) Console.WriteLine("Повторите ввод");
int CountVowels()
{
    int counting = 0;
    char[] vowels = { 'а', 'о', 'у', 'э', 'ы', 'я', 'ё', 'ю', 'е', 'и', };
    foreach (char inputCh in input)
    {
        foreach (char vowel in vowels)
        {
            if (inputCh == vowel) { counting++; }
        }
    }
    return counting;
}
Console.WriteLine(CountVowels());
Console.ReadKey();
}


