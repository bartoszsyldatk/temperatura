Console.WriteLine("1. Celsjusz \n2. Fahrenheit \n3. Kelvin");
Console.Write("Wybierz skalę wejściową: ");
int wejsciowa;
while (!int.TryParse(Console.ReadLine(), out wejsciowa) || wejsciowa > 3 || wejsciowa < 1){
    Console.Write("Podaj poprawną liczbę: ");
}

Console.WriteLine();

Console.WriteLine("1. Celsjusz \n2. Fahrenheit \n3. Kelvin");
Console.Write("Wybierz skalę wyjściową: ");
int wyjsciowa;
while (!int.TryParse(Console.ReadLine(), out wyjsciowa) || wyjsciowa > 3 || wyjsciowa < 1 || wyjsciowa == wejsciowa){
    Console.Write("Podaj poprawną liczbę: ");
}

Console.WriteLine();

Console.Write("Podaj temperaturę: ");
double temperatura;
while (!double.TryParse(Console.ReadLine(), out temperatura) ){
    Console.Write("Podaj poprawną liczbę: ");
}

switch (wyjsciowa){
    case 1:
        Console.WriteLine($"Temperatura wynosi {c(wejsciowa, temperatura):F2}");
        break;
    case 2:
        Console.WriteLine($"Temperatura wynosi {f(wejsciowa, temperatura):F2}");
        break;
    case 3:
        Console.WriteLine($"Temperatura wynosi {k(wejsciowa, temperatura):F2}");
        break;
}

double c(int wejsciowa, double temperatura){
    if (wejsciowa == 2){
        return (temperatura - 32) / 1.8;
    }
    else if (wejsciowa == 3){
        return ((temperatura - 32) / 1.8) + 273.15;
    }
    else{
        return 0;
    }
}

double f(int wejsciowa, double temperatura){
    if (wejsciowa == 1){
        return temperatura * 1.8 + 32;
    }
    else if (wejsciowa == 3){
        return ((temperatura - 273.15) * 1.8) + 32;
    }
    else{
        return 0;
    }
}

double k(int wejsciowa, double temperatura){
    if (wejsciowa == 1){
        return temperatura + 273.15;
    }
    else if (wejsciowa == 2){
        return ((temperatura - 32) / 1.8) + 273.15;
    }
    else{
        return 0;
    }
}
