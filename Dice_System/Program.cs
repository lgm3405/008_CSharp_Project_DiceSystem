using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_System
{
    public class Program             // 컴퓨터가 2개의 주사위를 굴려 해당 2개 주사위값을 합한 수치가 홀수인지 짝수인지 맞추기
    {
        static void Main(string[] args)
        {
            DiceSystem1 diceSystem_ = new DiceSystem1();  // 1. 컴퓨터가 2개의 주사위를 굴려 해당 2개 주사위값을 합한 수치가 홀수인지 짝수인지 나타내기
            diceSystem_.DiceSystem01();
        }
    }
}
