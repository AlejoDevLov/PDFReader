namespace PDFReader.Utilities;


internal class USTicketFactory : TicketFactoryBase
{
    protected override DateOnly CreateDate(int[] dateAsArray)
    {
        return new DateOnly(dateAsArray[2], dateAsArray[0], dateAsArray[1]);
    }
}
