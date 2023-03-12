namespace MyProjectName
{
    public class MessageList: TextualMessage
    {
        private enum BulletType
        {
            Dashed,
            Numbered,
            Star
        }
        private BulletType bulletType;

        public override Ipageable Input()
        {
            return this;
        }
    }
}