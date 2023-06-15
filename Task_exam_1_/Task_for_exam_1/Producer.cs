using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_for_exam_1
{
    public class Producer
    {
        // Producer'у необходимо сообщить, за какую часть он отвечает
        // Первый он, 2 или 3.

        private int num;

        public int Num => num; // свойство на чтение (узнать номер Producer'а)

        public Producer(int num)
        {
            this.num = num;
        }

        // Метод, запускающий процесс, за который отвечает Прод
        public void Start(Function function, double a_thread, double b_thread)
        {

            var t = new Thread( () =>
            {                
                var result = (b_thread - a_thread) / 6 * (function.func(a_thread) + 4 * function.func((a_thread + b_thread) / 2) + function.func(b_thread));

                CommonData.Put(num, result);

            });
            
            t.IsBackground = true;
            t.Start();
        }
    }
}
