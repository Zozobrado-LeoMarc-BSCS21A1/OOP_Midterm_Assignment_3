namespace TestProject1;
public partial class ClassRelationshipsTest
{
    public class OrderProcessor
    {
        private EmailSender emailSender;
        public OrderProcessor(EmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public Order ProcessOrder(Order order)
        {

            return order;

        }


    }
}