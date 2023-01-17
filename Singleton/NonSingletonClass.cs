using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //일반적인 클레스생성
    public class NonSingletonClass
    {

        //객채의 갯수를 확인을 위한 타입 변수 생성
        public static int instance_count = 0;

        //생성자 1회 호출시 인스턴스카운트 + 1
        public NonSingletonClass()
        {
            instance_count++; 
        }

        public void Say()
        {
            Console.WriteLine($"현재 생성된 인스턴스는 {instance_count} 개입니다. ");
        }
    }
}
