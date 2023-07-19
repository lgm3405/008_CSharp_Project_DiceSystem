using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_System
{
    public class DiceSystem2          // 2. 컴퓨터가 2개의 주사위를 굴려 해당 2개 주사위값을 합한 수치가 홀수인지 짝수인지 맞추기
    {
        public void DiceSystem02()
        {
            int num, rand1, rand2, userInput, diceType = 0;   // 각각 주사위 합한값, 주사위 랜덤값 1, 주사위 랜덤값 2, 유저 입력값, 주사위 홀,짝 여부
            int loopCheck = 1;          // While 루프 체크값

            Random random = new Random();         // 주사위 2개 랜덤값 생성
            rand1 = random.Next(1, 7);
            rand2 = random.Next(1, 7);

            num = rand1 + rand2;        // 주사위 2개값을 합한다.

            if (num % 2 == 0)         // 주사위 2개를 합한 값에 2를 나누었을떄 나머지가 0이면 짝수, 아니면 홀수
            {
                diceType = 2;        // 짝수는 2
            }
            else
            {
                diceType = 1;        // 홀수는 1
            }

            Console.WriteLine("컴퓨터가 2개의 주사위를 굴렸습니다. 두개의 주사위의 값이 홀수인지 짝수인지 맞추시오 = > ");
            Console.WriteLine("( 홀수는 1, 짝수는 2 라고 입력해주세요. )");
            Console.WriteLine("단, 게임을 종료하시려면 숫자 0 을 입력해주세요.");
            int.TryParse(Console.ReadLine(), out userInput);

            while (loopCheck > 0)        // loopCheck가 0이면 While 을 탈출한다.
            {
                if (loopCheck == 1)
                {
                    if (0 <= userInput && userInput < 3)        // 유저 입력값 확인
                    {
                        if (userInput == 0)           // 유저 입력값이 0 이면 Game Over
                        {
                            Console.WriteLine("Game Over");
                            loopCheck = 0;
                        }
                        Console.WriteLine();
                        Console.WriteLine("1. 컴퓨터가 굴린 두개의 주사위의 값 = {0}, {1}", rand1, rand2);
                        if (diceType == 2)          // diceType 값으로 홀수인지, 짝수인지 출력
                        {
                            Console.WriteLine("2. 두개의 주사위를 굴린 값을 합한 값이 짝인지 홀인지 여부 = 짝수");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("2. 두개의 주사위를 굴린 값을 합한 값이 짝인지 홀인지 여부 = 홀수");
                            Console.WriteLine();
                        }
                        if (userInput == diceType)        // 유저 입력값과 주사위를 합친 홀,짝 여부값이 같으면 정답, 틀리면 오답 출력하기
                        {
                            Console.WriteLine("축하합니다! 정답을 맞추셨습니다!");
                            loopCheck = 0;
                        }
                        else
                        {
                            Console.WriteLine("안타깝게 정답을 맞추지 못하셨습니다...");
                            loopCheck = 0;
                        }
                    }
                    else         // 유저의 입력값이 0, 1, 2 와 다르면 다시 입력하기
                    {
                        Console.WriteLine();
                        Console.WriteLine("잘못된 숫자를 입력하셨습니다. 다시 한번 확인해주세요");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
