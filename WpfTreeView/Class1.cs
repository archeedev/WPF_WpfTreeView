using System.ComponentModel;
using System.Threading.Tasks;

namespace WpfTreeView
{
    public class Class1 : INotifyPropertyChanged
    {
        private string mTest;

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {  };

        public string Test
        {
            get
            {
                return mTest;
            }
            set
            {
                if (mTest == value)
                    return;

                mTest = value;

                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Test)));
            }
        }

        public Class1()
        {
            Task.Run(async () =>
           {
               int i = 0;

               while (true)
               {
                   await Task.Delay(200);
                   Test = (i++).ToString();                   
               }
           });
        }


        public override string ToString()
        {
            return "Whateva";
        }
    }
}
