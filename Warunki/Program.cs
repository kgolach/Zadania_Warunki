class Program
{
    static void Main(string [] args)
    {

        //1
        Console.WriteLine("Exercise 1");

        int a = 5;
        int b = 5;

        Console.WriteLine($"liczba a: {a}, liczba b: {b}");

        if (a == b)
        {
            Console.WriteLine($"{a} i {b} są równe");
        }
        else
        {
            Console.WriteLine($"{a} i {b} są różne");
        }
        Console.WriteLine();
        //2
        Console.WriteLine("Exercise 2");
        Console.WriteLine("Podaj dowolna liczbę");
        string number = Console.ReadLine();
        int numb;
        Int32.TryParse(number, out numb);

        if( numb % 2 ==0 )
        {
            Console.WriteLine($"{numb} jest liczbą parzystą");
        }
        else
        {
            Console.WriteLine($"{numb} jest liczbą nieparzystą");
        }
        Console.WriteLine();
        //3
        Console.WriteLine("Exercise 3");
        Console.WriteLine("Podaj dowolną liczbę ");
        string number1 = Console.ReadLine();
        int numb1;
        Int32.TryParse(number1, out numb1); 

        if( numb1 > 0)
        {
            Console.WriteLine($"Liczba {numb1} jest liczbą dodatnią");
        }    
        else
            Console.WriteLine($"Liczba {numb1} jest liczbą ujemną");
        Console.WriteLine();

        //4
        Console.WriteLine("Exercise 4");
        Console.WriteLine("Podaj dowolny rok");
        string years = Console.ReadLine();
        int year;
        Int32.TryParse(years, out year);    

        if (year % 4 == 0 )
        {
            Console.WriteLine($"{year} jest rokiem przestępnym");
        }
        else
        {
            Console.WriteLine($"{year} nie jest rokiem przetępnym");
        }

        Console.WriteLine();

        //5
        Console.WriteLine("Exercise 5");
        Console.WriteLine("Podaj swoj wiek");
        string ages = Console.ReadLine();
        int age;

        Int32.TryParse(ages, out age);  

        if(age >= 21 && age <30)
        {
            Console.WriteLine("Możesz zostać posłem");
        }
        
        else if(age >= 30 && age <35)
        {
            Console.WriteLine("Możesz zostać senatorem");
        }
        else if (age >= 35 )
        {
            Console.WriteLine("Możesz zostać prezydentem");
        }
        else
        {
            Console.WriteLine("Jesteś za młody");
        }
        Console.WriteLine();


        //6
        Console.WriteLine("Exercise 6");
        Console.WriteLine("Podaj swój wzrost");
        string height1 = Console.ReadLine();
        int height;
        Int32.TryParse(height1, out height);    

        if(height < 150)
        {
            Console.WriteLine("Jesteś malutki");
        }
        else if (height >150 && height <160)
        {
            Console.WriteLine("Jesteś niski");
        }
        else if( height >160 && height <170)
        {
            Console.WriteLine("Jesteś trochę wyższy");

        }
        else if ( height > 170 && height <180)
        {
            Console.WriteLine("Jesteś średni wzrostem");

        }
        else if (height >180)
        {
            Console.WriteLine("Jesteś wysoki");
        }
        
        Console.WriteLine();

        //7
        Console.WriteLine("Exercise 7");
        Console.WriteLine("Podaj liczbę");
        string nnumber1 = Console.ReadLine();
        int numbb1;
        Int32.TryParse(nnumber1, out numbb1);

        Console.WriteLine("Podaj liczbę");
        string nnumber2 = Console.ReadLine();
        int numbb2;
        Int32.TryParse(nnumber2, out numbb2);

        Console.WriteLine("Podaj liczbę");
        string nnumber3 = Console.ReadLine();
        int numbb3;
        Int32.TryParse(nnumber3, out numbb3);

        int numbMax = numb1;

        if(numbb2 > numbb1) numbMax = numbb2;
       
        if( numbb3 > numbb2) numbMax = numbb3;
        
       
        Console.WriteLine($"Największa wartość to: {numbMax}");

        //8
        Console.WriteLine("Exercise 8");
        Console.WriteLine("Poniżej odpowiedź na pytania, aby uzuskać odpowiedź czy możesz ubiegać się o miejsce na studia");
        Console.WriteLine("Podaj wynik z matury z chemii");
        string chemistry = Console.ReadLine();
        int chemistryResult;
        Int32.TryParse(chemistry, out chemistryResult);
        Console.WriteLine();
        Console.WriteLine("Podaj wynik z matury z matematyki");
        string maths = Console.ReadLine();
        int mathsResult;   
        Int32.TryParse(maths, out mathsResult);
        Console.WriteLine();
        Console.WriteLine("Podaj wynik z matury z fizyki");
        string physics = Console.ReadLine();
        int physicsResult;  
        Int32.TryParse(physics, out physicsResult);

        if(chemistryResult > 45 && physicsResult > 55 && chemistryResult > 70  && mathsResult  + physicsResult + chemistryResult > 180 || mathsResult + chemistryResult >150  || mathsResult + physicsResult > 150 )
        {
          
            Console.WriteLine("Zostaleś przyjęty na studia ");

        }
        else
        {
            Console.WriteLine("Nie zostaleś przyjęty na studia ");
        }
        Console.WriteLine();

        //9
        Console.WriteLine("Exercise 9");
        Console.WriteLine("Podaj temperaturę, która jest obecnie");
        string temperatura = Console.ReadLine();
        int temp;
        Int32.TryParse(temperatura, out temp);

        if (temp < 0)
        {
            Console.WriteLine("Strasznie zimno");
        }
        else if (temp > 0 && temp <= 10)
        {
            Console.WriteLine("Zimno");
        }
        else if (temp > 10 && temp <= 20)
        {
            Console.WriteLine("Chłodno");
        }
        else if (temp > 20 && temp <= 30)
        {
            Console.WriteLine("W sam raz");
        }
        else if(temp > 30 && temp <= 40)
        {
            Console.WriteLine("Zaczyna robić się gorąco");

        }
       else
        {
            Console.WriteLine("Za gorąco, duchota");       
        }
        Console.WriteLine();

        //10
        Console.WriteLine("Exercise 10");
        Console.WriteLine("Sprawdzimy poniżej czy z podanych wartości da zbudować się trójkąt");
        Console.WriteLine("Podaj bok");
        string sideC = Console.ReadLine();
        int c;
        Int32.TryParse(sideC, out c);

        Console.WriteLine("Podaj bok");
        string sideD = Console.ReadLine();
        int d;
        Int32.TryParse(sideD, out d);

        Console.WriteLine("Podaj bok");
        string sideE = Console.ReadLine();
        int e;
        Int32.TryParse(sideE, out e);

        if ( c + d > e)
        {
            Console.WriteLine("Można zbudować z podanych boków trójkąt");
        }
        else
        {
            Console.WriteLine("Nie można zbudować z podanych boków trójkąt");
        }
        Console.WriteLine();

        //11
        Console.WriteLine("Exercise 11");
        Console.WriteLine("Podaj swoją ocenę od 1 do 6");
        var mark = Console.ReadLine();

        switch(mark)
        {

            case "6":
                Console.WriteLine("Celujący");
                break;
            case "5":
                Console.WriteLine("Bardzo dobry");
                break;
            case "4":
                Console.WriteLine("Dobry");
                break;
            case "3":
                Console.WriteLine("Dostateczny");
                break;
            case "2":
                Console.WriteLine("Dopuszczający");
                break;
            case "1":
                Console.WriteLine("Niedostateczny");
                break;
            default:
                Console.WriteLine("Podaj poprawą liczbę z podanego zakresu");
                break;
               
        }
        Console.WriteLine();

        //12
        Console.WriteLine("Exercise 12");
        Console.WriteLine("Podaj numer dnia tygodnia (od 1 do 7)");
        var week = Console.ReadLine();

        switch (week)
        {

            case "1":
                Console.WriteLine("Poniedziałek");
                break;
            case "2":
                Console.WriteLine("Wtorek");
                break;
            case "3":
                Console.WriteLine("Środa");
                break;
            case "4":
                Console.WriteLine("Czwartek");
                break;
            case "5":
                Console.WriteLine("Piątek");
                break;
            case "6":
                Console.WriteLine("Sobota");
                break;
                case "7":
                Console.WriteLine("Niedziela");
                break;
            default:
                Console.WriteLine("Podaj poprawą liczbę z podanego zakresu");
                break;

        }
        Console.WriteLine();

        //13
        Console.WriteLine("Exercise 13");
        Console.WriteLine("Poniżej kalkulator ");
        Console.WriteLine("Podaj pierwsza liczbę");
        string firstNumber = Console.ReadLine();
        int firstNumb;
        Int32.TryParse(firstNumber, out firstNumb);

        Console.WriteLine("Podaj druga liczbę");
        string secondNumber = Console.ReadLine();   
        int secondNumb;
        Int32.TryParse(secondNumber, out secondNumb);

        Console.WriteLine("Podaj wybrany numer zgodnie z tym, jaką operację matematyczną chcesz wykonać");
        Console.WriteLine("1 - Dodawanie");
        Console.WriteLine("2 - Odejmowanie");
        Console.WriteLine("3 - Mnożenie");
        Console.WriteLine("4 - Dzielenie");

        string choice = Console.ReadLine();
        int option;
        Int32.TryParse(choice, out option);
        int result;

        if(option == 1)
        {
            result = firstNumb + secondNumb;
            Console.WriteLine($"Twój wynik to: {result}");
        }
        else if(option == 2)
        {
            result = firstNumb - secondNumb;
            Console.WriteLine($"Twój wynik to: {result}");
        }
        else if (option == 3)
        {
            result = firstNumb * secondNumb;
            Console.WriteLine($"Twój wynik to: {result}");
        }
        else if (option == 4 )
        {
            result = firstNumb / secondNumb;
            Console.WriteLine($"Twój wynik to: {result}");
        }
        else
        {
            Console.WriteLine("Wprowadź poprawny numer operacji");
            
        }

        Console.ReadKey();
    }
}
