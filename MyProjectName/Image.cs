namespace MyProjectName
{
    public class Image : Ipageable
    {
        private PageData mydata;
        private string asciimage;


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