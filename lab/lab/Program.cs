
int bal = 85; // Burada balı özün dəyişə bilərsən

if (bal >= 90 && bal <= 100)
{
    Console.WriteLine("Qiymətiniz: A");
}
else if (bal >= 70 && bal <= 89)
{
    Console.WriteLine("Qiymətiniz: B");
}
else if (bal >= 50 && bal <= 69)
{
    Console.WriteLine("Qiymətiniz: C");
}
else if (bal >= 0 && bal < 50)
{
    Console.WriteLine("Qiymətiniz: F");
}
else
{
    Console.WriteLine("Yanlış bal daxil etmisiniz!");
}