using System;



class Game {
    
    static bool playerX(char[] array){
        Console.WriteLine($"\n {array[0]} | {array[1]} | {array[2]}\n - + - + -\n {array[3]} | {array[4]} | {array[5]}\n - + - + -\n {array[6]} | {array[7]} | {array[8]}");
        Console.WriteLine("\nEnter location x: ");
            
        int location = int.Parse(Console.ReadLine()) - 1;
        if(location >= 0 && location < 10)
        {
            if(array[location] != 'x' && array[location] != 'o')
            {
                array[location] = 'x';
            }
            else
            {
                while(true)
                {
                    if(array[location] != 'x' && array[location] != 'o')
                    {
                        array[location] = 'x';
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Eror!");
                        Console.WriteLine("\nEnter location x: ");
                    }
                }
            }
        }
        else
        {
            while(true){
                if(location >= 0 && location < 10){
                    if(array[location] != 'x' && array[location] != 'o')
                    {
                        array[location] = 'x';
                        break;
                    }
                }
                else
                {
                    while(true)
                    {
                        if(array[location] != 'x' && array[location] != 'o'){
                            array[location] = 'x';
                            break;
                        }else{
                            Console.WriteLine("Eror!");
                            Console.WriteLine("\nEnter location x: ");
                        }
                    }
                }    
            }
        }
        
        return true;
    }
    
    static bool playerO(char[] array){
        Console.WriteLine($"\n {array[0]} | {array[1]} | {array[2]}\n - + - + -\n {array[3]} | {array[4]} | {array[5]}\n - + - + -\n {array[6]} | {array[7]} | {array[8]}");
        Console.WriteLine("\nEnter location o: ");
        int location = int.Parse(Console.ReadLine()) - 1;
            
        if(location >= 0 && location < 10)
        {
            if(array[location] != 'x' && array[location] != 'o')
            {
                array[location] = 'o';
            }
            else
            {
                while(true)
                {
                    if(array[location] != 'x' && array[location] != 'o')
                    {
                        array[location] = 'o';
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Eror!");
                        Console.WriteLine("\nEnter location o: ");
                    }
                }
            }
        }
        else
        {
            while(true)
            {
                if(location >= 0 && location < 10)
                {
                    if(array[location] != 'x' && array[location] != 'o')
                    {
                        array[location] = 'o';
                        break;
                    }
                }
                else
                {
                    while(true)
                    {
                        if(array[location] != 'x' && array[location] != 'o'){
                            array[location] = 'o';
                            break;
                        }else{
                            Console.WriteLine("Eror!");
                            Console.WriteLine("\nEnter location o: ");
                        }
                    }
                }    
            }
        }
        
        return true;
    }
    
    static bool checkWinner(char[] array){
        
        if((array[0] == 'o' && array[1] == 'o' && array[2] == 'o') || 
            (array[3] == 'o' && array[4] == 'o' && array[5] == 'o') ||
            (array[6] == 'o' && array[7] == 'o' && array[8] == 'o') ||
            (array[0] == 'o' && array[3] == 'o' && array[6] == 'o') ||
            (array[1] == 'o' && array[4] == 'o' && array[7] == 'o') ||
            (array[6] == 'o' && array[7] == 'o' && array[8] == 'o') ||
            (array[0] == 'o' && array[4] == 'o' && array[8] == 'o') ||
            (array[2] == 'o' && array[4] == 'o' && array[6] == 'o'))
            {
                Console.WriteLine("Winner O!");
                return false;
            }
        else if((array[0] == 'x' && array[1] == 'x' && array[2] == 'x') || 
            (array[3] == 'x' && array[4] == 'x' && array[5] == 'x') ||
            (array[6] == 'x' && array[7] == 'x' && array[8] == 'x') ||
            (array[0] == 'x' && array[3] == 'x' && array[6] == 'x') ||
            (array[1] == 'x' && array[4] == 'x' && array[7] == 'x') ||
            (array[6] == 'x' && array[7] == 'x' && array[8] == 'x') ||
            (array[0] == 'x' && array[4] == 'x' && array[8] == 'x') ||
            (array[2] == 'x' && array[4] == 'x' && array[6] == 'x'))
            {
                Console.WriteLine("Winner X!");
                return false;
            }
               
        return true;
    }
    
    
    static void Main() {
        
        char[] array = new char[9];
        // Заповнення масиву символами
        array[0] = '1'; array[1] = '2'; array[2] = '3';
        array[3] = '4'; array[4] = '5'; array[5] = '6';
        array[6] = '7'; array[7] = '8'; array[8] = '9';
        
        Console.WriteLine("tic-tac-toe");

        while(true){
            
            playerX(array);
            
            if(!checkWinner(array)) break;
            
            playerO(array);
        }
    }
}
