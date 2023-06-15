using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_for_exam_1
{
    public class Consumer
    {
        public void Start(Label label1)
        {
            var t = new Thread(() =>
            {
                var _tResult = CommonData.Get();
                var result = _tResult.Sum();

                label1.Text = result.ToString();

                
            });
            t.IsBackground = true;
            t.Start();
        }
    }
}
