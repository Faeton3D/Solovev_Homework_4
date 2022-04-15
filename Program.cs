int N, i;

N = 15;
i = 2;

while(i <= N)
{
    if(i == N)
        Console.Write($"{i}. ");
    else 
        Console.Write($"{i}, ");
    i = i+2;
}