namespace MyProjectName
{
    public class TextualMessage : Ipageable
    {
        protected PageData mydata;
        protected string message;


        public virtual Ipageable Input()
        {
           return this;
        }
        
        public void Output()
        {

        }
        public PageData Mydata
        {
          get
           {
              return mydata;
          }
           set
           {
             mydata = value;
          }
        }
    }
}