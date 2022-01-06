using System;

namespace ITzza_Game
{
    public class Member
    {
        public int order;
        public string name;
        public int hp;

        public Member(int order)
        {
            this.order = order;
        }
        public Member(string name)
        {
            this.name = name;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("총 5명이 참가할 수 있는 게임입니다.");
            //Console.WriteLine("첫번째 참가자의 이름을 입력해주세요.");
            //Member firstM = new Member();
            //firstM.name = Console.ReadLine();
            //firstM.order = 1;
            //Console.WriteLine("두번째 참가자의 이름을 입력해주세요.");
            //Member secondM = new Member();
            //secondM.name = Console.ReadLine();
            //secondM.order = 2;
            //Console.WriteLine("세번째 참가자의 이름을 입력해주세요.");
            //Member thirdM = new Member();
            //thirdM.name = Console.ReadLine();
            //thirdM.order = 3;
            //Console.WriteLine("네번째 참가자의 이름을 입력해주세요.");
            //Member fourthM = new Member();
            //fourthM.name = Console.ReadLine();
            //fourthM.order = 4;
            //Console.WriteLine("다섯번째 참가자의 이름을 입력해주세요.");
            //Member fifthM = new Member();
            //fifthM.name = Console.ReadLine();
            //fifthM.order = 5;

            //Random r = new Random();
            //string[] player = { firstM.name, secondM.name, thirdM.name, fourthM.name, fifthM.name };
            //string winOne = player[r.Next(player.Length)];
            //Console.WriteLine("\n" + "술래는 " + winOne + " 입니다.");

            Console.WriteLine("총 5명이 참가할 수 있는 게임입니다.");
            Console.WriteLine("첫번째 참가자의 이름을 입력해주세요.");
            Member firstM = new Member(Console.ReadLine());
            firstM.hp = 50;
            Console.WriteLine("두번째 참가자의 이름을 입력해주세요.");
            Member secondM = new Member(Console.ReadLine());
            secondM.hp = 50;
            Console.WriteLine("세번째 참가자의 이름을 입력해주세요.");
            Member thirdM = new Member(Console.ReadLine());
            thirdM.hp = 50;
            Console.WriteLine("네번째 참가자의 이름을 입력해주세요.");
            Member fourthM = new Member(Console.ReadLine());
            fourthM.hp = 50;
            Console.WriteLine("다섯번째 참가자의 이름을 입력해주세요.");
            Member fifthM = new Member(Console.ReadLine());
            fifthM.hp = 50;


            for (int i = 50; i <= 0; i++)
            {
                Random r = new Random();
                string[] player = { firstM.name, secondM.name, thirdM.name, fourthM.name, fifthM.name };
                string winOne = player[r.Next(player.Length)];
                string winTwo = player[r.Next(player.Length)];

                if (winOne == winTwo)
                {
                    while (winOne == winTwo)
                    {
                        Random random = new Random();
                        string[] again = { firstM.name, secondM.name, thirdM.name, fourthM.name, fifthM.name };
                        string againOne = player[r.Next(again.Length)];
                        string againTwo = player[r.Next(again.Length)];
                    }
                }

                else
                {
                    Console.WriteLine("술래는 " + winOne + " 그리고 " + winTwo + " 입니다.");
                    
                }

                string[] penalty = { "벌칙주 원샷",
                                     "1단계 러브샷",
                                     "2단계 러브샷",
                                     "엉덩이로 이름쓰기",
                                     "10초 동안 막춤추기",
                                     "발라드 1소절씩 부르기",
                                     "서로 안주 먹여주기",
                                     "진실 한가지씩 대답하기",
                                     "서로 볼에 뽀뽀하기",
                                     "서로 손등에 뽀뽀하기",
                                   };
                string game = penalty[r.Next(penalty.Length)];
                Console.WriteLine("\n" + "벌칙은 " + game + " 입니다.");
                Console.WriteLine(winOne + " 그리고 " + winTwo + " 의 체력이 10씩 감소합니다.");

                if (firstM.hp == 0)
                {
                    Console.WriteLine(firstM.name + "탈락하셨습니다.");
                    Random random = new Random();
                    string[] again = { secondM.name, thirdM.name, fourthM.name, fifthM.name };
                    string againOne = player[r.Next(again.Length)];
                    string againTwo = player[r.Next(again.Length)];
                }
                else if (secondM.hp == 0)
                {
                    Console.WriteLine(secondM.name + "탈락하셨습니다.");
                    Random random = new Random();
                    string[] again = { firstM.name, thirdM.name, fourthM.name, fifthM.name };
                    string againOne = player[r.Next(again.Length)];
                    string againTwo = player[r.Next(again.Length)];
                }
                else if(secondM.hp == 0)
                {
                    Console.WriteLine(thirdM.name + "탈락하셨습니다.");
                    Random random = new Random();
                    string[] again = { firstM.name, secondM.name, fourthM.name, fifthM.name };
                    string againOne = player[r.Next(again.Length)];
                    string againTwo = player[r.Next(again.Length)];
                }
                else if(secondM.hp == 0)
                {
                    Console.WriteLine(fourthM.name + "탈락하셨습니다.");
                    Random random = new Random();
                    string[] again = { firstM.name, secondM.name, thirdM.name, fifthM.name };
                    string againOne = player[r.Next(again.Length)];
                    string againTwo = player[r.Next(again.Length)];
                }
                else if(secondM.hp == 0)
                {
                    Console.WriteLine(fifthM.name + "탈락하셨습니다.");
                    Random random = new Random();
                    string[] again = { firstM.name, secondM.name, thirdM.name, fourthM.name };
                    string againTwo = player[r.Next(again.Length)];
                }
            }
            

        }
    }
}

