
string AddStr(int num)
{
    if ((num % 10 >= 5 && num % 10 <= 9) || (num % 100 >= 11 && num % 100 <= 14) || (num % 10 == 0))
    {
        return num + " компьютеров";
    }
    else if (num % 10 == 1)
    {
        return num + " компьютер";
    }
    else if (num % 10 >= 2 && num % 10 <= 4)
    {
        return num + " компьютера";
    }

    return "";
}