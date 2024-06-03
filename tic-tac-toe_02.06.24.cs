/******************************************************************************


*******************************************************************************/
using System;
class HelloWorld {
    static void Main() {
        
        int location;
        char[] array = new char[9];
        // Заповнення масиву символами
        array[0] = '1'; array[1] = '2'; array[2] = '3';
        array[3] = '4'; array[4] = '5'; array[5] = '6';
        array[6] = '7'; array[7] = '8'; array[8] = '9';
        
        Console.WriteLine("tic-tac-toe");

        for(int i = 0; i < 90 ; i++){
            
            Console.WriteLine($"\n {array[0]} | {array[1]} | {array[2]}\n - + - + -\n {array[3]} | {array[4]} | {array[5]}\n - + - + -\n {array[6]} | {array[7]} | {array[8]}");
            Console.WriteLine("\nEnter location x: ");
            
            location = int.Parse(Console.ReadLine()) - 1;
            if(location >= 0 && location < 10){
                if(array[location] != 'x' && array[location] != 'o'){
                    array[location] = 'x';
                }else{
                    break;
                }
            }else{
                break;
            }
            
            if((array[0] == 'o' && array[1] == 'o' && array[2] == 'o') || 
               (array[3] == 'o' && array[4] == 'o' && array[5] == 'o') ||
               (array[6] == 'o' && array[7] == 'o' && array[8] == 'o') ||
               (array[0] == 'o' && array[3] == 'o' && array[6] == 'o') ||
               (array[1] == 'o' && array[4] == 'o' && array[7] == 'o') ||
               (array[6] == 'o' && array[7] == 'o' && array[8] == 'o') ||
               (array[0] == 'o' && array[4] == 'o' && array[8] == 'o') ||
               (array[2] == 'o' && array[4] == 'o' && array[6] == 'o')){
                   Console.WriteLine("Viner O!");
                   break;
               }
            else if((array[0] == 'x' && array[1] == 'x' && array[2] == 'x') || 
                (array[3] == 'x' && array[4] == 'x' && array[5] == 'x') ||
                (array[6] == 'x' && array[7] == 'x' && array[8] == 'x') ||
                (array[0] == 'x' && array[3] == 'x' && array[6] == 'x') ||
                (array[1] == 'x' && array[4] == 'x' && array[7] == 'x') ||
                (array[6] == 'x' && array[7] == 'x' && array[8] == 'x') ||
                (array[6] == 'x' && array[7] == 'x' && array[8] == 'x') ||
                (array[6] == 'x' && array[7] == 'x' && array[8] == 'x')){
                    Console.WriteLine("Viner X!");
                    break;
            }
            
            
            Console.WriteLine($"\n {array[0]} | {array[1]} | {array[2]}\n - + - + -\n {array[3]} | {array[4]} | {array[5]}\n - + - + -\n {array[6]} | {array[7]} | {array[8]}");
            Console.WriteLine("\nEnter location o: ");
            location = int.Parse(Console.ReadLine()) - 1;
            if(location >= 0 && location < 10){
                if(array[location] != 'x' && array[location] != 'o'){
                    array[location] = 'o';
                }else{
                    break;
                }
            }else{
                break;
            }
        }
    }
}
