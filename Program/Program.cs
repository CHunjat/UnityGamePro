using System.Numerics;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 박싱
            ////값 타입을 참조타입으로 변환하여 관리되는 힙 영역에 새로운 객체를
            ////만들고 복사하는 과정
            #endregion
            //int count = 123545;
            //object obj = count; //박싱
            //Console.WriteLine("obj : " + obj );
            //Console.WriteLine("count : " + count );
            #region  언박싱
            //관리되는 힙영역에 있는 박싱되어 있는 객체에서 값을 추출하여 값 타입으로 복사하는 과정
            long experience = 143143245235;
            object address = experience; //박싱


           // address = 900999; //박싱된 객체는 불변이므로 새로운 객체가 만들어지고 주소값이 변경됨 // 얘는 주소타입

            //long data = (long)address; //언박싱
            //Console.WriteLine("address : " + address);
            //Console.WriteLine("data : " + data);
            //Console.WriteLine("experience : " + experience);
            #endregion

            Vector3 position = new Vector3(1.0f, 2.0f, 3.0f); //이게 어떤 메모리 영역일까 => 값 타입이므로 스택 영역에 저장됨  
        }
    }
}
