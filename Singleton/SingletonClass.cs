using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonClass
    {

        //객채의 갯수를 확인을 위한 타입 변수 생성
        public static int instance_count = 0;

        // 외부에서 접근 불가능한 정적 인스턴스 생성
        private static SingletonClass? _instance = null;


        // 외부에서 인스턴스를 가졍기 위한 getter
        public static SingletonClass Instance
        { 
            get
            {
                if (_instance == null)
                    _instance = new SingletonClass();
                return _instance;
            }
        }
        //private 한정자를 통해 외부 에서 생성자 진입 방지
        private SingletonClass()
        { 
            //생성자 1회 호출시 인스턴스 카운트+1
            instance_count++;
        }

        public void Say()
        {
            Console.WriteLine($"현재 생성된 인스턴스는 {instance_count} 개입니다. ");
        }

    }
}
