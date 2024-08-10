using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.question
{

    // abstract = inhert & implemet 
    public abstract class Question : ICloneable
    {
      

        public string Header { get;  }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        protected Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new Answer[0];
        }

        public override string ToString()
        {
            return $"Header: {Header}, Body: {Body}, Mark: {Mark}";
        }

    
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public abstract void ShowQuestion();




    }
}
