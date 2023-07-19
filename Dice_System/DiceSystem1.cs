using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_System
{
    public class DiceSystem1          // 1. 컴퓨터가 2개의 주사위를 굴려 해당 2개 주사위값을 합한 수치가 홀수인지 짝수인지 나타내기
    {
        public void DiceSystem01()
        {
            int num, rand1, rand2 = 0;        // 각각 주사위 2개를 합한 값, 랜덤 주사위값 1, 랜덤 주사위값 2

            Random random = new Random();       // 1부터 6까지 랜덤값 2개 생성하기
            rand1 = random.Next(1, 7);
            rand2 = random.Next(1, 7);

            Console.WriteLine("주사위의 수는 각각 {0} 와 {1} 입니다.", rand1, rand2);
            Console.WriteLine();

            num = rand1 + rand2;           // 2개의 랜덤 주사위값을 합하기

            if (num % 2 == 0)           // 합한 주사위값을 2로 나누었을때 나머지가 없으면 짝수로 판단, 아니면 홀수로 판단
            {
                Console.WriteLine("주사위 두개를 합한 숫자는 짝수 입니다.");
            }
            else
            {
                Console.WriteLine("주사위 두개를 합한 숫자는 홀수 입니다.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            DiceSystem2 diceSystem_ = new DiceSystem2();  // 2. 컴퓨터가 2개의 주사위를 굴려 해당 2개 주사위값을 합한 수치가 홀수인지 짝수인지 맞추기
            diceSystem_.DiceSystem02();
        }
    }
}
